#!usr/bin/python
# -*- coding:utf-8 -*-

'''
--------------------------------
-create by shenj 2016-6-15     -
-ver: beta 1.0                 -
-memo: 预定义正则规则             -
--------------------------------
-Modify Log                    -
---                            -
--------------------------------
'''

import re
## flag = 0 相当于未定义re.I等规则
#正则规则：bin表读取，从bin1读取到bin35. 规则匹配 binAA(B)  :   CCCC  DDD.D% 匹配结果结构[binAA,B,CCCC,DDD.D]
def bin_re(product = 'FM293',flag = re.I):
    if product.upper() == 'FM293':
        return re.compile('(bin\d{1,2})\(([\S])\)[\s]*:[\s]*(\d*)[\s]*([0-9\.]{0,5})%',flag)
    else:
        return None

#正则规则：截取'Wafer ID:'之后的只包含数字字母及'-''_'的任意长度字符串
def wafer_re(product = 'FM293',flag = re.I):
    if product.upper() == 'FM293':
        return re.compile('(?<=Wafer ID:)[A-Za-z0-9_-].*',flag)
    else:
        return None

#正则规则：截取bin_map信息
def binMap_re(product = 'FM293',flag = re.I):
    if product.upper() == 'FM293':
        return re.compile('(\d{3})([ ]+[\S]+[ ]*)(?=\n)',flag)
    else:
        return None
    
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
