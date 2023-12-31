/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.10
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef PHP_FIFTYONEDEGREESTRIEV3_H
#define PHP_FIFTYONEDEGREESTRIEV3_H

extern zend_module_entry FiftyOneDegreesTrieV3_module_entry;
#define phpext_FiftyOneDegreesTrieV3_ptr &FiftyOneDegreesTrieV3_module_entry

#ifdef PHP_WIN32
# define PHP_FIFTYONEDEGREESTRIEV3_API __declspec(dllexport)
#else
# define PHP_FIFTYONEDEGREESTRIEV3_API
#endif

#ifdef ZTS
#include "TSRM.h"
#endif

PHP_MINIT_FUNCTION(FiftyOneDegreesTrieV3);
PHP_MSHUTDOWN_FUNCTION(FiftyOneDegreesTrieV3);
PHP_RINIT_FUNCTION(FiftyOneDegreesTrieV3);
PHP_RSHUTDOWN_FUNCTION(FiftyOneDegreesTrieV3);
PHP_MINFO_FUNCTION(FiftyOneDegreesTrieV3);

ZEND_NAMED_FUNCTION(_wrap_new_MapStringString);
ZEND_NAMED_FUNCTION(_wrap_MapStringString_size);
ZEND_NAMED_FUNCTION(_wrap_MapStringString_clear);
ZEND_NAMED_FUNCTION(_wrap_MapStringString_get);
ZEND_NAMED_FUNCTION(_wrap_MapStringString_set);
ZEND_NAMED_FUNCTION(_wrap_MapStringString_del);
ZEND_NAMED_FUNCTION(_wrap_MapStringString_has_key);
ZEND_NAMED_FUNCTION(_wrap_MapStringString_is_empty);
ZEND_NAMED_FUNCTION(_wrap_new_VectorString);
ZEND_NAMED_FUNCTION(_wrap_VectorString_size);
ZEND_NAMED_FUNCTION(_wrap_VectorString_capacity);
ZEND_NAMED_FUNCTION(_wrap_VectorString_reserve);
ZEND_NAMED_FUNCTION(_wrap_VectorString_clear);
ZEND_NAMED_FUNCTION(_wrap_VectorString_push);
ZEND_NAMED_FUNCTION(_wrap_VectorString_is_empty);
ZEND_NAMED_FUNCTION(_wrap_VectorString_pop);
ZEND_NAMED_FUNCTION(_wrap_VectorString_get);
ZEND_NAMED_FUNCTION(_wrap_VectorString_set);
ZEND_NAMED_FUNCTION(_wrap_provider_get);
ZEND_NAMED_FUNCTION(_wrap_Match_getValues);
ZEND_NAMED_FUNCTION(_wrap_Match_getValue);
ZEND_NAMED_FUNCTION(_wrap_Match_getDeviceId);
ZEND_NAMED_FUNCTION(_wrap_Match_getRank);
ZEND_NAMED_FUNCTION(_wrap_Match_getDifference);
ZEND_NAMED_FUNCTION(_wrap_Match_getMethod);
ZEND_NAMED_FUNCTION(_wrap_Match_getUserAgent);
ZEND_NAMED_FUNCTION(_wrap_Provider_getHttpHeaders);
ZEND_NAMED_FUNCTION(_wrap_Provider_getAvailableProperties);
ZEND_NAMED_FUNCTION(_wrap_Provider_getDataSetName);
ZEND_NAMED_FUNCTION(_wrap_Provider_getDataSetFormat);
ZEND_NAMED_FUNCTION(_wrap_Provider_getDataSetPublishedDate);
ZEND_NAMED_FUNCTION(_wrap_Provider_getDataSetNextUpdateDate);
ZEND_NAMED_FUNCTION(_wrap_Provider_getDataSetSignatureCount);
ZEND_NAMED_FUNCTION(_wrap_Provider_getDataSetDeviceCombinations);
ZEND_NAMED_FUNCTION(_wrap_Provider_getMatch);
ZEND_NAMED_FUNCTION(_wrap_Provider_getMatchJson);
ZEND_NAMED_FUNCTION(_wrap_Provider_reloadFromFile);
ZEND_NAMED_FUNCTION(_wrap_Provider_reloadFromMemory);
ZEND_NAMED_FUNCTION(_wrap_new_Provider);
#endif /* PHP_FIFTYONEDEGREESTRIEV3_H */
