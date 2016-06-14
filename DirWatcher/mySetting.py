#!usr/bin/python
# -*- coding:utf-8 -*-

#品名与数据库表名对应关系
tableMap = {'FM293':'fm293.test_infos','test':'test.test_infos'}

##产品测试项目的map表：针对不同项目的表结构，构建对应的测试项目行结构。
##本map以FM293的表结构为范例，所有与FM293表结构不同的产品，必需以<品名>:<行结构>的格式
##添加到map
procMap = {'comm':('contact_vdd','contact_vdd12','contact_vdd18','contact_vdd33','contact_vdd_ct','contact_pad_in1','contact_pad_in2','contact_pad_clk','contact_pad_ct_io','contact_pad_rst','contact_pad_test_n','idd1_vdd','idd2_3V_bpmu','idd2_55_BPMU','IN1_vo_200uA_pad_in1','IN1_vo_3mA_pad_in1','IN1_vo_20mA_pad_in1','vdd12_volt1__vdd12','vdd12_volt2_vdd12','vdd18_volt_vdd18','vdd33_volt_vdd33','IILT_pad_test_n','IIL1_pad_clk','IIL1_pad_rst','IIL2_pad_ct_io','IIH1_pad_clk','IIH1_pad_rst','IIH2_bpmu_pad_ct_io','VOL_pad_ct_io')}


class pathSetting:
    workPath = None
    outputPath = workPath
    logfilePath = workPath

def get_workPath():
    return pathSetting.workPath

def get_outputPath():
    return pathSetting.outputPath

def get_logfilePath():
    return pathSetting.logfilePath
