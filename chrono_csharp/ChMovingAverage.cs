//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChMovingAverage : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChMovingAverage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChMovingAverage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChMovingAverage() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          corePINVOKE.delete_ChMovingAverage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChMovingAverage(SWIGTYPE_p_std__valarrayT_double_t data, int n) : this(corePINVOKE.new_ChMovingAverage(SWIGTYPE_p_std__valarrayT_double_t.getCPtr(data), n), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__valarrayT_double_t Get() {
    SWIGTYPE_p_std__valarrayT_double_t ret = new SWIGTYPE_p_std__valarrayT_double_t(corePINVOKE.ChMovingAverage_Get__SWIG_0(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double Get(int i) {
    double ret = corePINVOKE.ChMovingAverage_Get__SWIG_1(swigCPtr, i);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
