//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChRigidSuspension : ChSuspension {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChRigidSuspension(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChRigidSuspension_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChRigidSuspension obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChRigidSuspension(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string GetTemplateName() {
    string ret = vehiclePINVOKE.ChRigidSuspension_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsSteerable() {
    bool ret = vehiclePINVOKE.ChRigidSuspension_IsSteerable(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsIndependent() {
    bool ret = vehiclePINVOKE.ChRigidSuspension_IsIndependent(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Initialize(ChChassis chassis, ChSubchassis subchassis, ChSteering steering, ChVectorD location, double left_ang_vel, double right_ang_vel) {
    vehiclePINVOKE.ChRigidSuspension_Initialize__SWIG_0(swigCPtr, ChChassis.getCPtr(chassis), ChSubchassis.getCPtr(subchassis), ChSteering.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel, right_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, ChSubchassis subchassis, ChSteering steering, ChVectorD location, double left_ang_vel) {
    vehiclePINVOKE.ChRigidSuspension_Initialize__SWIG_1(swigCPtr, ChChassis.getCPtr(chassis), ChSubchassis.getCPtr(subchassis), ChSteering.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, ChSubchassis subchassis, ChSteering steering, ChVectorD location) {
    vehiclePINVOKE.ChRigidSuspension_Initialize__SWIG_2(swigCPtr, ChChassis.getCPtr(chassis), ChSubchassis.getCPtr(subchassis), ChSteering.getCPtr(steering), ChVectorD.getCPtr(location));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetTrack() {
    double ret = vehiclePINVOKE.ChRigidSuspension_GetTrack(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SWIGTYPE_p_std__vectorT_chrono__vehicle__ChSuspension__ForceTSDA_t ReportSuspensionForce(VehicleSide side) {
    SWIGTYPE_p_std__vectorT_chrono__vehicle__ChSuspension__ForceTSDA_t ret = new SWIGTYPE_p_std__vectorT_chrono__vehicle__ChSuspension__ForceTSDA_t(vehiclePINVOKE.ChRigidSuspension_ReportSuspensionForce(swigCPtr, (int)side), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void LogConstraintViolations(VehicleSide side) {
    vehiclePINVOKE.ChRigidSuspension_LogConstraintViolations(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
