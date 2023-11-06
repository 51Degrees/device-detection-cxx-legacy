//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FiftyOne.Mobile.Detection.Provider.Interop.Pattern {

public partial class Match : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Match(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Match obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Match() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FiftyOneDegreesPatternV3PINVOKE.delete_Match(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public VectorString getValues(string propertyName) {
    VectorString ret = new VectorString(FiftyOneDegreesPatternV3PINVOKE.Match_getValues__SWIG_0(swigCPtr, propertyName), true);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VectorString getValues(SWIGTYPE_p_std__string propertyName) {
    VectorString ret = new VectorString(FiftyOneDegreesPatternV3PINVOKE.Match_getValues__SWIG_1(swigCPtr, SWIGTYPE_p_std__string.getCPtr(propertyName)), true);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VectorString getValues(int propertyIndex) {
    VectorString ret = new VectorString(FiftyOneDegreesPatternV3PINVOKE.Match_getValues__SWIG_2(swigCPtr, propertyIndex), true);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getValue(string propertyName) {
    string ret = FiftyOneDegreesPatternV3PINVOKE.Match_getValue__SWIG_0(swigCPtr, propertyName);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getValue(SWIGTYPE_p_std__string propertyName) {
    string ret = FiftyOneDegreesPatternV3PINVOKE.Match_getValue__SWIG_1(swigCPtr, SWIGTYPE_p_std__string.getCPtr(propertyName));
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getValue(int propertyIndex) {
    string ret = FiftyOneDegreesPatternV3PINVOKE.Match_getValue__SWIG_2(swigCPtr, propertyIndex);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getDeviceId() {
    string ret = FiftyOneDegreesPatternV3PINVOKE.Match_getDeviceId(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getRank() {
    int ret = FiftyOneDegreesPatternV3PINVOKE.Match_getRank(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getDifference() {
    int ret = FiftyOneDegreesPatternV3PINVOKE.Match_getDifference(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getMethod() {
    int ret = FiftyOneDegreesPatternV3PINVOKE.Match_getMethod(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getUserAgent() {
    string ret = FiftyOneDegreesPatternV3PINVOKE.Match_getUserAgent(swigCPtr);
    if (FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Pending) throw FiftyOneDegreesPatternV3PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
