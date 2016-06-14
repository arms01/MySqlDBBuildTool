#!usr/bin/python
# -*- coding:utf-8 -*-

#create by shenj 2016/6/1
#ver: beta 1.0
#memo：解析stdf文件，将指定数据按指定格式保存到txt文件，并批量导入到数据库。
#Modify Log
#   2016-6-8 ： 截取信息增加 product,deviceNO，lot,wafer,测试时间，dieX,dieY,device测试结果 并按每deviceNO 排版数据行（行列转换）
#               Ptr信息中建立dict1（局部）,存储测试项目+pin与测试值的映射，dict2（全局），存储site与dict1的映射
#               Prr信息中建立dict3(全局)，存储device与坐标+site的映射
#               Dtr信息中建立dict4(全局), 通过device从dict3中获取site信息，通过site从dict2中获取测试项与测试值映射集，将这些信息存储在dict4中
#   2016-6-13 : 针对空字段存到文本从‘’修改为'\N',这样存储到数据库时，数值字段可以存储为null而不是0
import sys,re
import os
from time import strftime, localtime , gmtime

try:
    import gzip
    have_gzip = True
except ImportError:
    have_gzip = False
try:
    import bz2
    have_bz2 = True
except ImportError:
    have_bz2 = False

from pystdf.IO import Parser
#from pystdf.Writers import AtdfWriter
from pystdf import V4
#from MyLogging import *
#import mySetting as Setting
#from mySetting import procMap 

gzPattern = re.compile('\.g?z', re.I)
bz2Pattern = re.compile('\.bz2', re.I)

##产品测试项目的map表：针对不同项目的表结构，构建对应的测试项目行结构。
##本map以FM293的表结构为范例，所有与FM293表结构不同的产品，必需以<品名>:<行结构>的格式
##添加到map
#procMap = {'comm':('contact_vdd','contact_vdd12','contact_vdd18','contact_vdd33','contact_vdd_ct','contact_pad_in1','contact_pad_in2','contact_pad_clk','contact_pad_ct_io','contact_pad_rst','contact_pad_test_n','idd1_vdd','idd2_3V_bpmu','idd2_55_BPMU','IN1_vo_200uA_pad_in1','IN1_vo_3mA_pad_in1','IN1_vo_20mA_pad_in1','vdd12_volt1__vdd12','vdd12_volt2_vdd12','vdd18_volt_vdd18','vdd33_volt_vdd33','IILT_pad_test_n','IIL1_pad_clk','IIL1_pad_rst','IIL2_pad_ct_io','IIH1_pad_clk','IIH1_pad_rst','IIH2_bpmu_pad_ct_io','VOL_pad_ct_io')}

def format_by_type(value, field_type):
    if field_type in ('B1', 'N1'):
        return '%02X' % (value)
    else:
        return str(value)

class AtdfWriter:
    
    @staticmethod
    def atdf_format(rectype, field_index, value):
        field_type = rectype.fieldStdfTypes[field_index]
        if value is None:
            return ""
        elif rectype is V4.gdr:
            return '|'.join([str(v) for v in value])
        elif field_type[0] == 'k': # An Array of some other type
            return ','.join([format_by_type(v, field_type[2:]) for v in value])
        elif rectype is V4.mir or rectype is V4.mrr:
            field_name = rectype.fieldNames[field_index]
            if field_name.endswith('_T'): # A Date-Time in an MIR/MRR
                #print value
                #return strftime('%Y-%m-%d %H:%M:%S', localtime(value))
                return strftime('%Y-%m-%d %H:%M:%S', gmtime(value))
            else:
                return str(value)
        else:
            return str(value)
    #定义类内部变量
    def __init__(self, sourceFn = None ):
        self.sourceFn = sourceFn
        self.t_DT = None
        self.dict_testProj = {}
        self.dict3 = {}
        self.dict4 = {}
        
        
    #如果定义了结果存放文件，则在解析开始前打开结果存放文件
    def before_begin(self, dataSource):
        pass

    #如果定义了结果存放文件，则在传输事件发生后写入文件，否则输出到缓冲区
    def after_send(self, dataSource, data):
        #2016-6-8 按需求组织数据结构
        #截取所需数据（测试）
        tData = [self.atdf_format(data[0], i, val) for i, val in enumerate(data[1])]
        if (data[0].__class__.__name__ == 'Mir'):
            #print 'Mir parse begin'           
            self.product = tData[9]
            #print 'Mir parse end'     
        elif(data[0].__class__.__name__ == 'Ftr'):
            pass      
        elif(data[0].__class__.__name__ == 'Ptr'):
            #Ptr信息中建立dict1（局部）,存储测试项目+pin与测试值的映射，dict2（全局），存储site与dict1的映射                
            #print 'Ptr parse begin'  
            tmpStr = tData[6].split(' ')
            test_ping = '_'.join((tmpStr[0],tmpStr[1]))
            unit = tData[14]
            if self.dict_testProj.has_key(test_ping):
                pass
            else:
                self.dict_testProj[test_ping] = [self.product,tmpStr[0],tmpStr[1],unit]   
            #print 'Ptr parse end'
        #2016-6-8 end

    #如果定义了结果存放文件，则在解析完成后关闭结果存放文件，否则输出到输出介质
    def after_complete(self, dataSource):
        pass
            
    #如果定义了结果存放文件，则在解析取消后关闭结果存放文件
    def after_cancel(self, dataSource):
        pass

#解析stdf文本
##fn为需要解析的文本名称(含路径)
def process_file(fn = None):
    try:
        filename = fn
        f = None
        reopen_fn = None
        if filename is None:
            f = sys.stdin
        elif gzPattern.search(filename):
            if not have_gzip:
                print >>sys.stderr, "gzip is not supported on this system"
                sys.exit(1)
            reopen_fn = lambda: gzip.open(filename, 'rb')
            f = reopen_fn()
        elif bz2Pattern.search(filename):
            if not have_bz2:
                print >>sys.stderr, "bz2 is not supported on this system"
                sys.exit(1)
            reopen_fn = lambda: bz2.BZ2File(filename, 'rb')
            f = reopen_fn()
        else:
            f = open(filename, 'rb')
        #创建解析器
        p=Parser(inp=f, reopen_fn=reopen_fn)
        parserWriter = AtdfWriter(sourceFn = filename)
        p.addSink(parserWriter)
        #进行解析
        p.parse()
        
        return parserWriter.dict_testProj
    except Exception,e:
        raise e
    finally:
        if f is not None:
            f.close()

if __name__ == "__main__":
    if len(sys.argv) < 2:
        print "Usage: %s <stdf file> " % (sys.argv[0])
    else:
        process_file(sys.argv[1])
