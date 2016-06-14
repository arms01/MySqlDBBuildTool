#!usr/bin/python
# -*- coding:utf-8 -*-

'''
--------------------------------
-create by shenj 2016-6-15     -
-ver: beta 1.0                 -
-memo：解析out文件生成2个表数据   -
--------------------------------
-Modify Log                    -
---                            -
--------------------------------
'''

import sys,re,os,time
import rePatternSets
from mySetting import tableMap,tableMapCols

#传入map解析规则，解析数据，和bin代码映射字典，返回<坐标:bin>的字典
def getBinMap(re,data,MapDict):
    dictKeySet = set(MapDict.keys())
    y = 0    
    rstDict = {}
    for itm in re.finditer(data):
        #t1 = time.time()
        line = itm.group(2)
        lineSet = set(line)
        interSet = dictKeySet & lineSet
        for ch in interSet:
            x = 0
            x = line.find(ch,x)
            while x != -1:
                rstDict[(x,y)] = MapDict[ch]
                x = line.find(ch,x + 1)
        y = y + 1
        #print 'line %s used %s second' %(y,time.time() - t1)
    #print 'total used %s second' %(time.time() - t1)
    return rstDict

#解析out文本
def outfile_parse_func(fn = None):
    try:
        #binMap的字典
        bin_dict = {}
        file_paths = fn.split('\\')
        #截取源文件名
        file_name = file_paths[len(file_paths)-1]
        fileSet = file_name.split('-')
        if len(fileSet) == 3:
            product = fileSet[0]
        else:
            raise Exception('unidentified file name<%s>' %file_name)

         #创建数据库连接对象
        tblNm = tableMap['_'.join((product,'bin'))]
        f_stat = os.stat(fn)
        f_ctime = time.localtime(f_stat.st_ctime)
        year = f_ctime.tm_year
        month = f_ctime.tm_mon
        week = time.strftime('%W',f_ctime)
        date = time.strftime('%Y-%m-%d',f_ctime)        
        f = open(fn,'r')
        f_data = f.read()
        #正则规则：截取'Wafer ID:'之后的只包含数字字母及'-''_'的任意长度字符串
        wafer_re = rePatternSets.wafer_re()
        wafer = wafer_re.search(f_data).group().strip()
        lot = wafer.split('-')[0]
        #bin表读取，从bin1读取到bin35 匹配结果结构[binAA,B,CCCC,DDD.D]
        bin_re = rePatternSets.bin_re()
        bin_rst_str = ''.join(('insert into ',tblNm,' values("',date,'",',str(year),',',str(month),',',str(week),',"',lot,'","',wafer,'"'))
        for itm in bin_re.finditer(f_data):
            #建立binMap的字典
            bin_dict[itm.group(2)] = itm.group(1)
            #拼写yield表记录insert
            if itm.group(1).lower() == 'bin1':
                bin_rst_str = ','.join((bin_rst_str,str(round(float(itm.group(4))/100,3))))
            else:
                bin_rst_str = ','.join((bin_rst_str,str(itm.group(3))))

        bin_rst_str = ''.join((bin_rst_str,')'))
        #执行yield表insert语句
        #print bin_rst_str        
        #rst = cur.execute(bin_rst_str)

        #正则规则：截取bin_map信息
        map_re = rePatternSets.binMap_re(flag = 0)
        #传入map解析规则，解析数据，和bin代码映射字典，返回<坐标:bin>的字典
        binLocMap_dict = getBinMap(map_re,f_data,bin_dict)
    except Exception,e:
        raise

if __name__ == "__main__":
    if len(sys.argv) < 2:
        print 'usage:python %s <source_file_name(with path)>' %sys.argv[0]
    else:
        outfile_parse_func(sys.argv[1])
