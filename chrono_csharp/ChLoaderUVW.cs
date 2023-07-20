//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoaderUVW : ChLoader {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoaderUVW(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChLoaderUVW_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoaderUVW obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChLoaderUVW(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoadableUVW loadable {
    set {
      corePINVOKE.ChLoaderUVW_loadable_set(swigCPtr, ChLoadableUVW.getCPtr(value));
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = corePINVOKE.ChLoaderUVW_loadable_get(swigCPtr);
      ChLoadableUVW ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLoadableUVW(cPtr, true);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public virtual void ComputeF(double U, double V, double W, ChVectorDynamicD F, ChVectorDynamicD state_x, ChVectorDynamicD state_w) {
    corePINVOKE.ChLoaderUVW_ComputeF(swigCPtr, U, V, W, ChVectorDynamicD.getCPtr(F), ChVectorDynamicD.getCPtr(state_x), ChVectorDynamicD.getCPtr(state_w));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetLoadable(ChLoadableUVW mloadable) {
    corePINVOKE.ChLoaderUVW_SetLoadable(swigCPtr, ChLoadableUVW.getCPtr(mloadable));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChLoadable GetLoadable() {
    global::System.IntPtr cPtr = corePINVOKE.ChLoaderUVW_GetLoadable(swigCPtr);
    ChLoadable ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLoadable(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChLoadableUVW GetLoadableUVW() {
    global::System.IntPtr cPtr = corePINVOKE.ChLoaderUVW_GetLoadableUVW(swigCPtr);
    ChLoadableUVW ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLoadableUVW(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
