#!/usr/bin/env python

from FiftyOneDegrees import fiftyone_degrees_mobile_detector_v3_wrapper

import sys
import os
import time
import resource

liteDataFile = "../../data/51Degrees-LiteV3.2.dat"
premiumDataFile = "../../data/51Degrees-PremiumV3.2.dat"
enterpriseDataFile = "../../data/51Degrees-EnterpriseV3.2.dat"
inputFile = '../../data/20000 User Agents.csv'
properties = "IsMobile"

def speedtest(provider):
	fin = open(inputFile, 'r')
	speedtest_start = time.time()
	i = 0
	while i < 20000 :
		userAgent = fin.readline().rstrip('\n')
		match = provider.getMatch(userAgent)
		i += 1
	speedtest_end = time.time()
	fin.close()
	return (speedtest_end - speedtest_start)/(i/1000)

def runtests(dataFile):
	if (os.path.isfile(dataFile)):
		start = time.time()
		provider = fiftyone_degrees_mobile_detector_v3_wrapper.Provider(
			dataFile,
			properties)
		end = time.time()

		print "   Initialization time: %s ms" % ((end - start)*1000)
		print "   Time per detection: %s ms" % speedtest(provider)
		print "   Memory usage: %d Mb" % (resource.getrusage(resource.RUSAGE_SELF).ru_maxrss/1000)

		del(provider)
	else:
		print "   %s could not be found." % dataFile

print "Lite Tests:"
runtests(liteDataFile)

print "Premium Tests:"
runtests(liteDataFile)

print "Enterprise Tests:"
runtests(enterpriseDataFile)

