#!usr/bin/python
# -*- coding:utf-8 -*-

#create by shenj 2016/6/6
#ver: beta 1.0
#memo：解析txt文件，将指定数据按指定格式保存到txt文件，并批量导入到数据库。

import os,re
import datetime

patt = None

#拼接浮点数的re表达式
#功能：传入pattern表达式在pattern之后添加浮点数的正则表达式
#add_prefix 为真，则在添加浮点数的表达式前先添加默认分隔符' '
#add_suffix 为真，则在添加浮点数的表达式之后再添加默认分隔符' '
def float_rePattern_add(ptn,add_prefix = False,add_suffix = False):
    if(add_prefix):
        ptn = ''.join( [ptn,r'('' ''+)'] )        

    ptn = ''.join( [ptn,r'(((-?\d*)(\.?\d+))|(n/a))'] )
    
    if(add_suffix):
        ptn = ''.join( [ptn,r'('' ''+)'] )
        
    return ptn

#拼接字符串的re表达式
def str_rePattern_add(ptn,add_prefix = False,add_suffix = False):
    if(add_prefix):
        ptn = ''.join( [ptn,r'('' ''+)'] )        

    ptn = ''.join( [ptn,r'(([A-Za-z0-9_]+)|(n/a))'] )
    
    if(add_suffix):
        ptn = ''.join( [ptn,r'('' ''+)'] )
        
    return ptn

#拼接计量单位的re表达式
def unitPart_rePattern_add(ptn,add_prefix = False,add_suffix = False):
    if(add_prefix):
        ptn = ''.join( [ptn,r'('' ''+)'] )        

    ptn = ''.join( [ptn,r'((A)|(uA)|(mA)|(V)|(uV)|(mV)|(n/a))'] )
    
    if(add_suffix):
        ptn = ''.join( [ptn,r'('' ''+)'] )
        
    return ptn

#拼接整数的re表达式,negative_flag为真 则为非负整数
def int_rePattern_add(ptn,negative_flag = False,add_prefix = False,add_suffix = False):
    if(add_prefix):
        ptn = ''.join( [ptn,r'('' ''+)'] )        

    if negative_flag:
        ptn = ''.join( [ptn,'((\d+)|(n/a))'])
    else:
        ptn = ''.join( [ptn,'((-?\d+)|(n/a))'])
    
    if(add_suffix):
        ptn = ''.join( [ptn,r'('' ''+)'] )

    return ptn

#拼接测试结果RE表达式
def PassFail_rePattern_add(ptn,add_prefix = False,add_suffix = False):
    if(add_prefix):
        ptn = ''.join( [ptn,r'('' ''+)'] )

    ptn = ''.join([ptn,'((PASS)|(FAIL))'])

    if(add_suffix):
        ptn = ''.join( [ptn,r'('' ''+)'] )
        
    return ptn

#获取正则表达式
def getPattern():
    patt = ""
    patt = int_rePattern_add(ptn = patt,add_suffix = True)
    patt = int_rePattern_add(ptn = patt,add_suffix = True)
    patt = PassFail_rePattern_add(ptn = patt,add_suffix = True)
    patt = str_rePattern_add(ptn = patt,add_suffix = True)
    patt = str_rePattern_add(ptn = patt,add_suffix = True)
    patt = int_rePattern_add(ptn = patt,add_suffix = True)
    patt = float_rePattern_add(ptn = patt,add_suffix = True)
    patt = unitPart_rePattern_add(ptn = patt,add_suffix = True)
    patt = float_rePattern_add(ptn = patt,add_suffix = True)
    patt = unitPart_rePattern_add(ptn = patt,add_suffix = True)
    patt = float_rePattern_add(ptn = patt,add_suffix = True)
    patt = unitPart_rePattern_add(ptn = patt,add_suffix = True)
    patt = float_rePattern_add(ptn = patt,add_suffix = True)
    patt = unitPart_rePattern_add(ptn = patt,add_suffix = True)
    patt = int_rePattern_add(ptn = patt)
    return patt
    
#解析文本
def process_file():
    f = open('d:/fm222.txt','r')
    f_tar = open('d:/fm222_translate.txt','w')
    patt = getPattern()
    #f_tar.write('patt: <%s>%s'%(patt,'\n'))
    print 'patt = %s '%patt
    t1 = datetime.datetime.now()
    try:
        
        r=re.compile(patt,re.I)
        f_data = f.read()        
        for it in r.finditer(f_data):
            f_tar.write('%s%s'%(it.group(),'\n'))

        t2 = datetime.datetime.now()
        print t2-t1
    except Exception,e:
        print '%s %s'%(type(e),e)
    finally:
        f.close()
        f_tar.close()
    
def __init__(self):
    pass


if __name__ == "__main__":
    process_file()


