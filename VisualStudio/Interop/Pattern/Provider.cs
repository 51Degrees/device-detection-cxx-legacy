//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FiftyOne.Mobile.Detection.Provider.Interop.Pattern {

public partial class Provider : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Provider(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Provider obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Provider() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FiftyOneDegreesPatternV3PINVOKE.delete_Provider(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Provider(string fileName) : this(FiftyOneDegreesPatternV3PINVOKE.new_Provider__SWIG_0(fileName), true) {
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
  }

  public Provider(string fileName, string propertyString) : this(FiftyOneDegreesPatternV3PINVOKE.new_Provider__SWIG_1(fileName, propertyString), true) {
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
  }

  public Provider(string fileName, string propertyString, int cacheSize, int poolSize) : this(FiftyOneDegreesPatternV3PINVOKE.new_Provider__SWIG_2(fileName, propertyString, cacheSize, poolSize), true) {
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
  }

  public Provider(string fileName, VectorString propertiesArray) : this(FiftyOneDegreesPatternV3PINVOKE.new_Provider__SWIG_3(fileName, VectorString.getCPtr(propertiesArray)), true) {
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
  }

  public Provider(string fileName, VectorString propertiesArray, int cacheSize, int poolSize) : this(FiftyOneDegreesPatternV3PINVOKE.new_Provider__SWIG_4(fileName, VectorString.getCPtr(propertiesArray), cacheSize, poolSize), true) {
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
  }

  public Provider(string fileName, int cacheSize, int poolSize) : this(FiftyOneDegreesPatternV3PINVOKE.new_Provider__SWIG_5(fileName, cacheSize, poolSize), true) {
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorString getHttpHeaders() {
    VectorString ret = new VectorString(FiftyOneDegreesPatternV3PINVOKE.Provider_getHttpHeaders(swigCPtr), true);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VectorString getAvailableProperties() {
    VectorString ret = new VectorString(FiftyOneDegreesPatternV3PINVOKE.Provider_getAvailableProperties(swigCPtr), true);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getDataSetName() {
    string ret = FiftyOneDegreesPatternV3PINVOKE.Provider_getDataSetName(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getDataSetFormat() {
    string ret = FiftyOneDegreesPatternV3PINVOKE.Provider_getDataSetFormat(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getDataSetPublishedDate() {
    string ret = FiftyOneDegreesPatternV3PINVOKE.Provider_getDataSetPublishedDate(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getDataSetNextUpdateDate() {
    string ret = FiftyOneDegreesPatternV3PINVOKE.Provider_getDataSetNextUpdateDate(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getDataSetSignatureCount() {
    int ret = FiftyOneDegreesPatternV3PINVOKE.Provider_getDataSetSignatureCount(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getDataSetDeviceCombinations() {
    int ret = FiftyOneDegreesPatternV3PINVOKE.Provider_getDataSetDeviceCombinations(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Match getMatch(string userAgent) {
    global::System.IntPtr cPtr = FiftyOneDegreesPatternV3PINVOKE.Provider_getMatch__SWIG_0(swigCPtr, userAgent);
    Match ret = (cPtr == global::System.IntPtr.Zero) ? null : new Match(cPtr, true);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Match getMatch(MapStringString headers) {
    global::System.IntPtr cPtr = FiftyOneDegreesPatternV3PINVOKE.Provider_getMatch__SWIG_1(swigCPtr, MapStringString.getCPtr(headers));
    Match ret = (cPtr == global::System.IntPtr.Zero) ? null : new Match(cPtr, true);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getMatchJson(string userAgent) {
    string ret = FiftyOneDegreesPatternV3PINVOKE.Provider_getMatchJson__SWIG_0(swigCPtr, userAgent);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getMatchJson(MapStringString headers) {
    string ret = FiftyOneDegreesPatternV3PINVOKE.Provider_getMatchJson__SWIG_1(swigCPtr, MapStringString.getCPtr(headers));
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Match getMatchForDeviceId(string deviceId) {
    global::System.IntPtr cPtr = FiftyOneDegreesPatternV3PINVOKE.Provider_getMatchForDeviceId(swigCPtr, deviceId);
    Match ret = (cPtr == global::System.IntPtr.Zero) ? null : new Match(cPtr, true);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Profiles findProfiles(string propertyName, string valueName) {
    global::System.IntPtr cPtr = FiftyOneDegreesPatternV3PINVOKE.Provider_findProfiles__SWIG_0(swigCPtr, propertyName, valueName);
    Profiles ret = (cPtr == global::System.IntPtr.Zero) ? null : new Profiles(cPtr, true);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Profiles findProfiles(string propertyName, string valueName, Profiles profiles) {
    global::System.IntPtr cPtr = FiftyOneDegreesPatternV3PINVOKE.Provider_findProfiles__SWIG_1(swigCPtr, propertyName, valueName, Profiles.getCPtr(profiles));
    Profiles ret = (cPtr == global::System.IntPtr.Zero) ? null : new Profiles(cPtr, true);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void reloadFromFile() {
    FiftyOneDegreesPatternV3PINVOKE.Provider_reloadFromFile(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
  }

  public void reloadFromMemory(string source, int length) {
    FiftyOneDegreesPatternV3PINVOKE.Provider_reloadFromMemory(swigCPtr, source, length);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
  }

  public int getCacheHits() {
    int ret = FiftyOneDegreesPatternV3PINVOKE.Provider_getCacheHits(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getCacheMisses() {
    int ret = FiftyOneDegreesPatternV3PINVOKE.Provider_getCacheMisses(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getCacheMaxIterations() {
    int ret = FiftyOneDegreesPatternV3PINVOKE.Provider_getCacheMaxIterations(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Provider(string fileName, string propertyString, int cacheSize, int poolSize, bool validate) : this(FiftyOneDegreesPatternV3PINVOKE.new_Provider__SWIG_6(fileName, propertyString, cacheSize, poolSize, validate), true) {
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
  }

}

}
