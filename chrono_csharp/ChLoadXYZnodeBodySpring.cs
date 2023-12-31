//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadXYZnodeBodySpring : ChLoadXYZnodeBody {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadXYZnodeBodySpring(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChLoadXYZnodeBodySpring_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadXYZnodeBodySpring obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChLoadXYZnodeBodySpring(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoadXYZnodeBodySpring(ChNodeXYZ mnodeA, ChBody mbodyB, double mK, double mR, double mD0) : this(corePINVOKE.new_ChLoadXYZnodeBodySpring__SWIG_0(ChNodeXYZ.getCPtr(mnodeA), ChBody.getCPtr(mbodyB), mK, mR, mD0), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLoadXYZnodeBodySpring(ChNodeXYZ mnodeA, ChBody mbodyB, double mK, double mR) : this(corePINVOKE.new_ChLoadXYZnodeBodySpring__SWIG_1(ChNodeXYZ.getCPtr(mnodeA), ChBody.getCPtr(mbodyB), mK, mR), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ComputeForce(ChFrameMovingD rel_AB, ChVectorD loc_force) {
    corePINVOKE.ChLoadXYZnodeBodySpring_ComputeForce(swigCPtr, ChFrameMovingD.getCPtr(rel_AB), ChVectorD.getCPtr(loc_force));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStiffness(double mstiffness) {
    corePINVOKE.ChLoadXYZnodeBodySpring_SetStiffness(swigCPtr, mstiffness);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetStiffness() {
    double ret = corePINVOKE.ChLoadXYZnodeBodySpring_GetStiffness(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDamping(double mdamping) {
    corePINVOKE.ChLoadXYZnodeBodySpring_SetDamping(swigCPtr, mdamping);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetDamping() {
    double ret = corePINVOKE.ChLoadXYZnodeBodySpring_GetDamping(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRestLength(double mrest) {
    corePINVOKE.ChLoadXYZnodeBodySpring_SetRestLength(swigCPtr, mrest);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetRestLength() {
    double ret = corePINVOKE.ChLoadXYZnodeBodySpring_GetRestLength(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetStiff(bool ms) {
    corePINVOKE.ChLoadXYZnodeBodySpring_SetStiff(swigCPtr, ms);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
