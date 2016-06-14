#!usr/bin/python
# -*- coding:utf-8 -*-

import sys
import datetime

flag_map={
            'w':'Warning',
            'e':'Error!',
            'l':'Log'
}

def do_logging(fn,logInfo,flag):
    fp = open(fn,'a')
    logTime = datetime.datetime.now().strftime('%Y-%m-%d %H:%M:%S')
    if(flag in flag_map.keys()):
        fp.write('%s %s >> %s \n'%(flag_map[flag].ljust(8),logTime,logInfo))
    else:
        fp.write('%s %s >> %s \n'%(flag_map['l'].ljust(8),logTime,logInfo))
    fp.flush()
    fp.close()

if __name__ == "__main__":
    if len(sys.argv) < 3:
        print "Usage: %s <logMsg> <msgFlag>" % (sys.argv[0])
    else:
        do_logging('testFunc.log',sys.argv[1],sys.argv[2])
