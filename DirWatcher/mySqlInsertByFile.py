#!usr/bin/python
# -*- coding: utf8 -*-

#create by shenj 2016/6/3
#ver: beta 1.0
#memo：将指定格式的数据信息文档导入到指定数据库表
#Modify Log
#
#
#

import os
#import time,re
import MySQLdb
from MyLogging import *
from mySetting import tableMap 

#tableMap = {'FM293':'fm293.test_infos'}

def getColMapValue(colsMap,col_Key):
    if colsMap.has_key(col_Key):
        return colsMap[col_Key]
    else:
        raise Exception('col set not matched in db!')
    
def doImportDB(work_path,tagFN):
    try:
       
        #创建数据库连接对象
        conn = MySQLdb.connect(host="192.168.34.39",user="root",passwd="123456",db="fm293")
        cur = conn.cursor()

        f = open('/'.join((work_path,tagFN)).replace('\\','/'),'r')
        colsettings = f.readline().replace('\n','').split(',')
        colMap = {}        

        #从数据库获取列名字典
        if len(colsettings) > 1:            
            rst = cur.execute('select test_pin,col_name from fm293.fm293_testcol_map')
            map(lambda x:colMap.setdefault(x[0], x[1]),cur.fetchall())
        else:
            raise Exception('cols seting not found!')

        #根据文件首行信息，拼取插入数据的列顺序
        productNm = colsettings[0:1][0]
        cols = [getColMapValue(colMap, x) for x in colsettings[1:]]
        #print cols
        colstr = ','.join(cols)
        #根据品名获取数据表名
        tb_name = tableMap[productNm]
        #time1 = time.time()
        #拼接sql语句
        '''
        sql = ''.join(("load data local infile '",'/'.join((work_path,tagFN)).replace('\\','/') IGNORE
                      ,"' into table  testrecord character set UTF8 "
                       ,"FIELDS TERMINATED BY '|' "
                       ,"lines terminated BY '\n' "
                       ,"(number,site,@test_item_no,@pin_no,channel,low,measured,High,unit)"
                       ," set test_item_no = (select test_item_no from test_item where test_item_name = @test_item_no),pin_no = (select pin_no from pin_info where pin_name = @pin_no) ;"))
        #print sql
        '''
        sql = ''.join(("load data local infile '",'/'.join((work_path,tagFN)).replace('\\','/')
                      ,"' into table "
                       ,tb_name
                       ," character set UTF8 "
                       ,"FIELDS TERMINATED BY '|' "
                       ,"OPTIONALLY ENCLOSED BY '''' "
                       ,"lines terminated BY '\n' "
                       ,"IGNORE 1 LINES "
                       ,"(Product,LOT,wafer,DeviceNO,DieX,DieY,test_date,result,"
                       ,colstr
                       ,")")
                      )

        #print sql
        #执行sql语句
        rst = cur.execute( sql )
        #print rst
        conn.commit()
        #print  'use translate: %s' %(time.time() - time1)
        do_logging(work_path+'\\workLog.log','%s import to db finished!' %(tagFN),'l')
        print 'import %s to db done!'%tagFN
    except MySQLdb.Error,e:
        #出错回滚
        conn.rollback()
        print "Mysql Error %d: %s" % (e.args[0], e.args[1])
        do_logging(work_path+'\\workLog.log','%s %s at file:%s' %(type(e),e,tagFN),'e')
    except Exception,e:
        raise
    finally:
        #释放数据库对象
        cur.close() 
        conn.close()


#通过命令行形式执行此脚本时，执行以下代码(单元测试用)
if __name__ == "__main__":
    #判断传入参数数量（注意：Python后都算参数，所以脚本名是第一个参数）
    if len(sys.argv) < 3:
        print 'usage:python mySqlInsertByFile.py <work_dir> <source_file_name>'
    else:
        #判断传入的目录是否存在
        if os.path.isdir(sys.argv[1]):
            '''
            for path,d,filelist in os.walk(sys.argv[1]):
                for filename in filelist:
                    if re.match('^FM.*.txt',filename,re.I):
                        doImportDB(path,filename)
                        #print os.path.join(path,filename)
            '''
            doImportDB(sys.argv[1],sys.argv[2])
        else:
            print 'dir <%s> is not exits!\nusage:python mySqlInsertByFile.py <work_dir> <source_file_name>'%(sys.argv[1])

    
