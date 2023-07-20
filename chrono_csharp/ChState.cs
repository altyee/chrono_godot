//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChState : ChVectorDynamicD {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ChState(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChState_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChState obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          corePINVOKE.delete_ChState(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChState(ChIntegrable intgr) : this(corePINVOKE.new_ChState__SWIG_0(ChIntegrable.getCPtr(intgr)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChState() : this(corePINVOKE.new_ChState__SWIG_1(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChState(SWIGTYPE_p_Eigen__Index size, ChIntegrable intgr) : this(corePINVOKE.new_ChState__SWIG_2(SWIGTYPE_p_Eigen__Index.getCPtr(size), ChIntegrable.getCPtr(intgr)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChState(SWIGTYPE_p_Eigen__RefT_Eigen__MatrixT_double_Eigen__Dynamic_1_Eigen__ColMajor_t_const_t vec, ChIntegrable intgr) : this(corePINVOKE.new_ChState__SWIG_3(SWIGTYPE_p_Eigen__RefT_Eigen__MatrixT_double_Eigen__Dynamic_1_Eigen__ColMajor_t_const_t.getCPtr(vec), ChIntegrable.getCPtr(intgr)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChState(ChState other) : this(corePINVOKE.new_ChState__SWIG_4(ChState.getCPtr(other)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setZero(SWIGTYPE_p_Eigen__Index size, ChIntegrable intgr) {
    corePINVOKE.ChState_setZero(swigCPtr, SWIGTYPE_p_Eigen__Index.getCPtr(size), ChIntegrable.getCPtr(intgr));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChIntegrable GetIntegrable() {
    global::System.IntPtr cPtr = corePINVOKE.ChState_GetIntegrable(swigCPtr);
    ChIntegrable ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChIntegrable(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
