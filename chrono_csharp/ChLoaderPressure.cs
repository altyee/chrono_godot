//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoaderPressure : ChLoaderUVdistributed {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoaderPressure(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChLoaderPressure_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoaderPressure obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChLoaderPressure(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoaderPressure(ChLoadableUV mloadable) : this(corePINVOKE.new_ChLoaderPressure(ChLoadableUV.getCPtr(mloadable)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ComputeF(double U, double V, ChVectorDynamicD F, ChVectorDynamicD state_x, ChVectorDynamicD state_w) {
    corePINVOKE.ChLoaderPressure_ComputeF(swigCPtr, U, V, ChVectorDynamicD.getCPtr(F), ChVectorDynamicD.getCPtr(state_x), ChVectorDynamicD.getCPtr(state_w));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPressure(double mpressure) {
    corePINVOKE.ChLoaderPressure_SetPressure(swigCPtr, mpressure);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetPressure() {
    double ret = corePINVOKE.ChLoaderPressure_GetPressure(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetIntegrationPoints(int val) {
    corePINVOKE.ChLoaderPressure_SetIntegrationPoints(swigCPtr, val);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override int GetIntegrationPointsU() {
    int ret = corePINVOKE.ChLoaderPressure_GetIntegrationPointsU(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetIntegrationPointsV() {
    int ret = corePINVOKE.ChLoaderPressure_GetIntegrationPointsV(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetStiff(bool val) {
    corePINVOKE.ChLoaderPressure_SetStiff(swigCPtr, val);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool IsStiff() {
    bool ret = corePINVOKE.ChLoaderPressure_IsStiff(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
