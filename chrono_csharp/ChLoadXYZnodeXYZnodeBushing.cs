//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadXYZnodeXYZnodeBushing : ChLoadXYZnodeXYZnode {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadXYZnodeXYZnodeBushing(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChLoadXYZnodeXYZnodeBushing_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadXYZnodeXYZnodeBushing obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChLoadXYZnodeXYZnodeBushing(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoadXYZnodeXYZnodeBushing(ChNodeXYZ mnodeA, ChNodeXYZ mnodeB) : this(corePINVOKE.new_ChLoadXYZnodeXYZnodeBushing(ChNodeXYZ.getCPtr(mnodeA), ChNodeXYZ.getCPtr(mnodeB)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ComputeForce(ChVectorD rel_pos, ChVectorD rel_vel, ChVectorD abs_force) {
    corePINVOKE.ChLoadXYZnodeXYZnodeBushing_ComputeForce(swigCPtr, ChVectorD.getCPtr(rel_pos), ChVectorD.getCPtr(rel_vel), ChVectorD.getCPtr(abs_force));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFunctionForceX(ChFunction fx) {
    corePINVOKE.ChLoadXYZnodeXYZnodeBushing_SetFunctionForceX(swigCPtr, ChFunction.getCPtr(fx));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFunctionForceY(ChFunction fy) {
    corePINVOKE.ChLoadXYZnodeXYZnodeBushing_SetFunctionForceY(swigCPtr, ChFunction.getCPtr(fy));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFunctionForceZ(ChFunction fz) {
    corePINVOKE.ChLoadXYZnodeXYZnodeBushing_SetFunctionForceZ(swigCPtr, ChFunction.getCPtr(fz));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDamping(ChVectorD mdamping) {
    corePINVOKE.ChLoadXYZnodeXYZnodeBushing_SetDamping(swigCPtr, ChVectorD.getCPtr(mdamping));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetDamping() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChLoadXYZnodeXYZnodeBushing_GetDamping(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetStiff(bool ms) {
    corePINVOKE.ChLoadXYZnodeXYZnodeBushing_SetStiff(swigCPtr, ms);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
