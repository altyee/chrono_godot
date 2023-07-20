//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadBodyBody : ChLoadCustomMultiple {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadBodyBody(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChLoadBodyBody_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadBodyBody obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChLoadBodyBody(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual void ComputeBodyBodyForceTorque(ChFrameMovingD rel_AB, ChVectorD loc_force, ChVectorD loc_torque) {
    corePINVOKE.ChLoadBodyBody_ComputeBodyBodyForceTorque(swigCPtr, ChFrameMovingD.getCPtr(rel_AB), ChVectorD.getCPtr(loc_force), ChVectorD.getCPtr(loc_torque));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetForce() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChLoadBodyBody_GetForce(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetTorque() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChLoadBodyBody_GetTorque(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetApplicationFrameA(ChFrameD mpA) {
    corePINVOKE.ChLoadBodyBody_SetApplicationFrameA(swigCPtr, ChFrameD.getCPtr(mpA));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFrameD GetApplicationFrameA() {
    ChFrameD ret = new ChFrameD(corePINVOKE.ChLoadBodyBody_GetApplicationFrameA(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetApplicationFrameB(ChFrameD mpB) {
    corePINVOKE.ChLoadBodyBody_SetApplicationFrameB(swigCPtr, ChFrameD.getCPtr(mpB));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFrameD GetApplicationFrameB() {
    ChFrameD ret = new ChFrameD(corePINVOKE.ChLoadBodyBody_GetApplicationFrameB(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFrameMovingD GetAbsoluteFrameA() {
    ChFrameMovingD ret = new ChFrameMovingD(corePINVOKE.ChLoadBodyBody_GetAbsoluteFrameA(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFrameMovingD GetAbsoluteFrameB() {
    ChFrameMovingD ret = new ChFrameMovingD(corePINVOKE.ChLoadBodyBody_GetAbsoluteFrameB(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChBody GetBodyA() {
    global::System.IntPtr cPtr = corePINVOKE.ChLoadBodyBody_GetBodyA(swigCPtr);
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChBody GetBodyB() {
    global::System.IntPtr cPtr = corePINVOKE.ChLoadBodyBody_GetBodyB(swigCPtr);
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
