#!usr/bin/python
# -*- coding: utf8 -*-

#create by shenj 2016/6/1
#ver: beta 1.0
#memo：监控工作目录，当有文件新增时，调用解析脚本进行文件分析
#Modify Log
# 2016/6/2  bug:当新增文件时，有几率出现文件访问读取失败。 方案：判断错误类别，当为IOError时，重新调用解析脚本
# 2016/6/2  放弃多线程，性能反而下降。有待学习研究。
# 2016/6/3  将数据文本导入到数据库

import os
import sys
import time
import logging
import re
import threading
from watchdog.observers import Observer
from watchdog.events import LoggingEventHandler
from watchdog.events import FileSystemEventHandler
from MyLogging import *
from MyUnpackSTDF import *
from mySqlInsertByFile import *


#解析线程    
def decodeThread(handler,event): 
        #Event.src_path为发生新增文件的完全路径
        full_name = event.src_path
        file_paths = full_name.split('\\')
        #截取源文件名
        file_name = file_paths[len(file_paths)-1]
        #截取工作路径
        file_path = '\\'.join(file_paths[0:len(file_paths)-1])
        #分割源文件名，截取不带文件名后缀的文件名，拼接出目标文件名
        tar_names = file_name.split('.')
        cnt_tars = len(tar_names)
        tar_name = '.'.join(tar_names[0:cnt_tars - 1]) + '.txt'

        #从预设的正则规则中匹配文件类型，选择合适的文本解析方案
        moduleName = ''
        for key in parse_map.keys():
            if(re.match(key,file_name,re.I)):
                moduleName = parse_map[key]
                break
            
        if(moduleName != ''):
            try:
                ##动态加载相应的module
                ##parseModule =  imp.load_module(moduleName,*imp.find_module(moduleName,['./scripts/']))
                ##print '  load module: ' + moduleName
                ##parseModule.parse(file_name)

                #根据文件名动态调用相应文本解析方案
                ##STDF格式文件解析
                if(moduleName == 'STDF'):
                    print 'decoding... %s' %file_name.encode('utf-8')
                    do_logging(file_path+'\\workLog.log','decoding... %s' %file_name.encode('utf-8'),'l')
                    process_file(full_name,'\\'.join([file_path,tar_name]))
                    do_logging(file_path+'\\workLog.log','decode %s is done!' %file_name.encode('utf-8'),'l')
                    print 'decode %s is done!' %file_name.encode('utf-8')
                    ##2016/6/3 创建并启动线程，将生成的数据文件导入到数据库  
                    thd = threading.Thread(target = doImportDB,args=(file_path,tar_name))
                    thd.setDaemon(False)
                    thd.start()
                    print 'thread(%d) start ... import %s to db'%(thd.ident,tar_name)
                    ##2016/6/3 end
                ##TXT格式文件解析
                elif(moduleName == 'TXT'):
                    pass
            except IOError,e:
                decodeThread(handler,event)
            except Exception,e:
                print 'error msg: %s' %e
                print 'decode %s is failed!' %file_name.encode('utf-8')
                do_logging(file_path+'\\workLog.log','%s %s' %(type(e),e),'e')
                
class CreatedEventHandler(FileSystemEventHandler):  
    
    def __init__(self):
        FileSystemEventHandler.__init__(self) 
                
    #当有文件或文件夹创建时执行
    def on_created(handler,event):
        #启用解析线程 --性能反而没有单进程高，有待研究改进
        #thd = threading.Thread(target = decodeThread,args=(handler,event))
        #thd.setDaemon(False)
        #thd.start()

        #调用解析方法
        decodeThread(handler,event)

#正则匹配，将文件match到相应的解析脚本上
parse_map={
            '.*.stdf$':'STDF',
            '.*.txt$':'TXT'
}

def do_process(tar_path):
    if os.path.isdir(sys.argv[1]) :        
        path = sys.argv[1]
        event_handler = CreatedEventHandler()
        observer = Observer()
        observer.schedule(event_handler, path, recursive=True)
        observer.start()
        print 'Watching...'
        try:
            while True:
                time.sleep(1)
        except KeyboardInterrupt:
            print 'Quit!'
            observer.stop()
        observer.join()

if __name__ == "__main__":
    #logging.basicConfig(level=logging.INFO,
    #                    format='%(asctime)s - %(message)s',
    #                    datefmt='%Y-%m-%d %H:%M:%S')
    #判断传入参数数量（注意：Python后都算参数，所以脚本名是第一个参数，目录是第二个参数）
    if len(sys.argv) < 2 :
        print 'usage:python MyWatchDog.py <dir>'
    else :
        #判断传入的目录是否存在
        if os.path.isdir(sys.argv[1]) :
            path = sys.argv[1]
            event_handler = CreatedEventHandler()
            observer = Observer()
            observer.schedule(event_handler, path, recursive=True)
            observer.start()
            print 'Watching...'
            try:
                while True:
                    time.sleep(1)
            except KeyboardInterrupt:
                print 'Quit!'
                observer.stop()
            observer.join()
        else :
            print 'dir <%s> is not exits!\nusage:python MyWatchDog.py <dir>'%(sys.argv[1])



