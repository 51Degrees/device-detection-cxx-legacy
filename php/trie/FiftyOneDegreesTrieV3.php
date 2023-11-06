<?php

/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.7
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

// Try to load our extension if it's not already loaded.
if (!extension_loaded('FiftyOneDegreesTrieV3')) {
  if (strtolower(substr(PHP_OS, 0, 3)) === 'win') {
    if (!dl('php_FiftyOneDegreesTrieV3.dll')) return;
  } else {
    // PHP_SHLIB_SUFFIX gives 'dylib' on MacOS X but modules are 'so'.
    if (PHP_SHLIB_SUFFIX === 'dylib') {
      if (!dl('FiftyOneDegreesTrieV3.so')) return;
    } else {
      if (!dl('FiftyOneDegreesTrieV3.'.PHP_SHLIB_SUFFIX)) return;
    }
  }
}



abstract class FiftyOneDegreesTrieV3 {
	static function provider_get() {
		$r=provider_get();
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new Provider($r);
		}
		return $r;
	}
}

/* PHP Proxy Classes */
class MapStringString {
	public $_cPtr=null;
	protected $_pData=array();

	function __set($var,$value) {
		if ($var === 'thisown') return swig_FiftyOneDegreesTrieV3_alter_newobject($this->_cPtr,$value);
		$this->_pData[$var] = $value;
	}

	function __get($var) {
		if ($var === 'thisown') return swig_FiftyOneDegreesTrieV3_get_newobject($this->_cPtr);
		return $this->_pData[$var];
	}

	function __isset($var) {
		if ($var === 'thisown') return true;
		return array_key_exists($var, $this->_pData);
	}

	function __construct($arg1=null) {
		if (is_resource($arg1) && get_resource_type($arg1) === '_p_std__mapT_std__string_std__string_t') {
			$this->_cPtr=$arg1;
			return;
		}
		switch (func_num_args()) {
		case 0: $this->_cPtr=new_MapStringString(); break;
		default: $this->_cPtr=new_MapStringString($arg1);
		}
	}

	function size() {
		return MapStringString_size($this->_cPtr);
	}

	function clear() {
		MapStringString_clear($this->_cPtr);
	}

	function get($key) {
		return MapStringString_get($this->_cPtr,$key);
	}

	function set($key,$x) {
		MapStringString_set($this->_cPtr,$key,$x);
	}

	function del($key) {
		MapStringString_del($this->_cPtr,$key);
	}

	function has_key($key) {
		return MapStringString_has_key($this->_cPtr,$key);
	}

	function is_empty() {
		return MapStringString_is_empty($this->_cPtr);
	}
}

class VectorString {
	public $_cPtr=null;
	protected $_pData=array();

	function __set($var,$value) {
		if ($var === 'thisown') return swig_FiftyOneDegreesTrieV3_alter_newobject($this->_cPtr,$value);
		$this->_pData[$var] = $value;
	}

	function __get($var) {
		if ($var === 'thisown') return swig_FiftyOneDegreesTrieV3_get_newobject($this->_cPtr);
		return $this->_pData[$var];
	}

	function __isset($var) {
		if ($var === 'thisown') return true;
		return array_key_exists($var, $this->_pData);
	}

	function __construct($n=null) {
		if (is_resource($n) && get_resource_type($n) === '_p_std__vectorT_std__string_t') {
			$this->_cPtr=$n;
			return;
		}
		switch (func_num_args()) {
		case 0: $this->_cPtr=new_VectorString(); break;
		default: $this->_cPtr=new_VectorString($n);
		}
	}

	function size() {
		return VectorString_size($this->_cPtr);
	}

	function capacity() {
		return VectorString_capacity($this->_cPtr);
	}

	function reserve($n) {
		VectorString_reserve($this->_cPtr,$n);
	}

	function clear() {
		VectorString_clear($this->_cPtr);
	}

	function push($x) {
		VectorString_push($this->_cPtr,$x);
	}

	function is_empty() {
		return VectorString_is_empty($this->_cPtr);
	}

	function pop() {
		return VectorString_pop($this->_cPtr);
	}

	function get($i) {
		return VectorString_get($this->_cPtr,$i);
	}

	function set($i,$val) {
		VectorString_set($this->_cPtr,$i,$val);
	}
}

class Match {
	public $_cPtr=null;
	protected $_pData=array();

	function __set($var,$value) {
		if ($var === 'thisown') return swig_FiftyOneDegreesTrieV3_alter_newobject($this->_cPtr,$value);
		$this->_pData[$var] = $value;
	}

	function __get($var) {
		if ($var === 'thisown') return swig_FiftyOneDegreesTrieV3_get_newobject($this->_cPtr);
		return $this->_pData[$var];
	}

	function __isset($var) {
		if ($var === 'thisown') return true;
		return array_key_exists($var, $this->_pData);
	}
	function __construct($h) {
		$this->_cPtr=$h;
	}

	function getValues($propertyName_or_propertyIndex) {
		$r=Match_getValues($this->_cPtr,$propertyName_or_propertyIndex);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new VectorString($r);
		}
		return $r;
	}

	function getValue($propertyName_or_propertyIndex) {
		return Match_getValue($this->_cPtr,$propertyName_or_propertyIndex);
	}

	function getDeviceId() {
		return Match_getDeviceId($this->_cPtr);
	}

	function getRank() {
		return Match_getRank($this->_cPtr);
	}

	function getDifference() {
		return Match_getDifference($this->_cPtr);
	}

	function getMethod() {
		return Match_getMethod($this->_cPtr);
	}

	function getUserAgent() {
		return Match_getUserAgent($this->_cPtr);
	}
}

class Provider {
	public $_cPtr=null;
	protected $_pData=array();

	function __set($var,$value) {
		if ($var === 'thisown') return swig_FiftyOneDegreesTrieV3_alter_newobject($this->_cPtr,$value);
		$this->_pData[$var] = $value;
	}

	function __get($var) {
		if ($var === 'thisown') return swig_FiftyOneDegreesTrieV3_get_newobject($this->_cPtr);
		return $this->_pData[$var];
	}

	function __isset($var) {
		if ($var === 'thisown') return true;
		return array_key_exists($var, $this->_pData);
	}

	function __construct($fileName,$propertyString_or_propertiesArray=null) {
		if (is_resource($fileName) && get_resource_type($fileName) === '_p_Provider') {
			$this->_cPtr=$fileName;
			return;
		}
		switch (func_num_args()) {
		case 1: $this->_cPtr=new_Provider($fileName); break;
		default: $this->_cPtr=new_Provider($fileName,$propertyString_or_propertiesArray);
		}
	}

	function getHttpHeaders() {
		$r=Provider_getHttpHeaders($this->_cPtr);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new VectorString($r);
		}
		return $r;
	}

	function getAvailableProperties() {
		$r=Provider_getAvailableProperties($this->_cPtr);
		if (is_resource($r)) {
			$c=substr(get_resource_type($r), (strpos(get_resource_type($r), '__') ? strpos(get_resource_type($r), '__') + 2 : 3));
			if (class_exists($c)) return new $c($r);
			return new VectorString($r);
		}
		return $r;
	}

	function getDataSetName() {
		return Provider_getDataSetName($this->_cPtr);
	}

	function getDataSetFormat() {
		return Provider_getDataSetFormat($this->_cPtr);
	}

	function getDataSetPublishedDate() {
		return Provider_getDataSetPublishedDate($this->_cPtr);
	}

	function getDataSetNextUpdateDate() {
		return Provider_getDataSetNextUpdateDate($this->_cPtr);
	}

	function getDataSetSignatureCount() {
		return Provider_getDataSetSignatureCount($this->_cPtr);
	}

	function getDataSetDeviceCombinations() {
		return Provider_getDataSetDeviceCombinations($this->_cPtr);
	}

	function getMatch($userAgent_or_headers) {
		$r=Provider_getMatch($this->_cPtr,$userAgent_or_headers);
		if (!is_resource($r)) return $r;
		return new Match($r);
	}

	function getMatchJson($userAgent_or_headers) {
		return Provider_getMatchJson($this->_cPtr,$userAgent_or_headers);
	}
}


?>
