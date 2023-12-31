//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class MAN_10t_RotaryArm2 : ChRotaryArm {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal MAN_10t_RotaryArm2(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.MAN_10t_RotaryArm2_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MAN_10t_RotaryArm2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_MAN_10t_RotaryArm2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public MAN_10t_RotaryArm2(string name) : this(vehiclePINVOKE.new_MAN_10t_RotaryArm2(name), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double getPitmanArmMass() {
    double ret = vehiclePINVOKE.MAN_10t_RotaryArm2_getPitmanArmMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getPitmanArmRadius() {
    double ret = vehiclePINVOKE.MAN_10t_RotaryArm2_getPitmanArmRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getPitmanArmInertiaMoments() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.MAN_10t_RotaryArm2_getPitmanArmInertiaMoments(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getPitmanArmInertiaProducts() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.MAN_10t_RotaryArm2_getPitmanArmInertiaProducts(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getMaxAngle() {
    double ret = vehiclePINVOKE.MAN_10t_RotaryArm2_getMaxAngle(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
