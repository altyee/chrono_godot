//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChDoubleWishboneReduced : ChSuspension {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChDoubleWishboneReduced(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChDoubleWishboneReduced_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChDoubleWishboneReduced obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChDoubleWishboneReduced(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string GetTemplateName() {
    string ret = vehiclePINVOKE.ChDoubleWishboneReduced_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsSteerable() {
    bool ret = vehiclePINVOKE.ChDoubleWishboneReduced_IsSteerable(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsIndependent() {
    bool ret = vehiclePINVOKE.ChDoubleWishboneReduced_IsIndependent(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Initialize(ChChassis chassis, ChSubchassis subchassis, ChSteering steering, ChVectorD location, double left_ang_vel, double right_ang_vel) {
    vehiclePINVOKE.ChDoubleWishboneReduced_Initialize__SWIG_0(swigCPtr, ChChassis.getCPtr(chassis), ChSubchassis.getCPtr(subchassis), ChSteering.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel, right_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, ChSubchassis subchassis, ChSteering steering, ChVectorD location, double left_ang_vel) {
    vehiclePINVOKE.ChDoubleWishboneReduced_Initialize__SWIG_1(swigCPtr, ChChassis.getCPtr(chassis), ChSubchassis.getCPtr(subchassis), ChSteering.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, ChSubchassis subchassis, ChSteering steering, ChVectorD location) {
    vehiclePINVOKE.ChDoubleWishboneReduced_Initialize__SWIG_2(swigCPtr, ChChassis.getCPtr(chassis), ChSubchassis.getCPtr(subchassis), ChSteering.getCPtr(steering), ChVectorD.getCPtr(location));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void AddVisualizationAssets(VisualizationType vis) {
    vehiclePINVOKE.ChDoubleWishboneReduced_AddVisualizationAssets(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void RemoveVisualizationAssets() {
    vehiclePINVOKE.ChDoubleWishboneReduced_RemoveVisualizationAssets(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetTrack() {
    double ret = vehiclePINVOKE.ChDoubleWishboneReduced_GetTrack(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChLinkTSDA GetShock(VehicleSide side) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChDoubleWishboneReduced_GetShock(swigCPtr, (int)side);
    ChLinkTSDA ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkTSDA(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SWIGTYPE_p_std__vectorT_chrono__vehicle__ChSuspension__ForceTSDA_t ReportSuspensionForce(VehicleSide side) {
    SWIGTYPE_p_std__vectorT_chrono__vehicle__ChSuspension__ForceTSDA_t ret = new SWIGTYPE_p_std__vectorT_chrono__vehicle__ChSuspension__ForceTSDA_t(vehiclePINVOKE.ChDoubleWishboneReduced_ReportSuspensionForce(swigCPtr, (int)side), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChBody GetAntirollBody(VehicleSide side) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChDoubleWishboneReduced_GetAntirollBody(swigCPtr, (int)side);
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void LogConstraintViolations(VehicleSide side) {
    vehiclePINVOKE.ChDoubleWishboneReduced_LogConstraintViolations(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
