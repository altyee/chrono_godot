//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class LoadLoaderPressure : ChLoadBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal LoadLoaderPressure(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.LoadLoaderPressure_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LoadLoaderPressure obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_LoadLoaderPressure(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoaderPressure loader {
    set {
      corePINVOKE.LoadLoaderPressure_loader_set(swigCPtr, ChLoaderPressure.getCPtr(value));
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      ChLoaderPressure ret = new ChLoaderPressure(corePINVOKE.LoadLoaderPressure_loader_get(swigCPtr), true);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public LoadLoaderPressure(ChLoadableUV mloadable) : this(corePINVOKE.new_LoadLoaderPressure(ChLoadableUV.getCPtr(mloadable)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override int LoadGet_ndof_x() {
    int ret = corePINVOKE.LoadLoaderPressure_LoadGet_ndof_x(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int LoadGet_ndof_w() {
    int ret = corePINVOKE.LoadLoaderPressure_LoadGet_ndof_w(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void LoadGetStateBlock_x(ChState mD) {
    corePINVOKE.LoadLoaderPressure_LoadGetStateBlock_x(swigCPtr, ChState.getCPtr(mD));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void LoadGetStateBlock_w(ChStateDelta mD) {
    corePINVOKE.LoadLoaderPressure_LoadGetStateBlock_w(swigCPtr, ChStateDelta.getCPtr(mD));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void LoadStateIncrement(ChState x, ChStateDelta dw, ChState x_new) {
    corePINVOKE.LoadLoaderPressure_LoadStateIncrement(swigCPtr, ChState.getCPtr(x), ChStateDelta.getCPtr(dw), ChState.getCPtr(x_new));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override int LoadGet_field_ncoords() {
    int ret = corePINVOKE.LoadLoaderPressure_LoadGet_field_ncoords(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ComputeQ(ChState state_x, ChStateDelta state_w) {
    corePINVOKE.LoadLoaderPressure_ComputeQ(swigCPtr, ChState.getCPtr(state_x), ChStateDelta.getCPtr(state_w));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void LoadIntLoadResidual_F(ChVectorDynamicD R, double c) {
    corePINVOKE.LoadLoaderPressure_LoadIntLoadResidual_F(swigCPtr, ChVectorDynamicD.getCPtr(R), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void LoadIntLoadResidual_Mv(ChVectorDynamicD R, ChVectorDynamicD w, double c) {
    corePINVOKE.LoadLoaderPressure_LoadIntLoadResidual_Mv(swigCPtr, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(w), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool IsStiff() {
    bool ret = corePINVOKE.LoadLoaderPressure_IsStiff(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void CreateJacobianMatrices() {
    corePINVOKE.LoadLoaderPressure_CreateJacobianMatrices(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
