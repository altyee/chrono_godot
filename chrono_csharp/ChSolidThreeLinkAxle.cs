//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChSolidThreeLinkAxle : ChSuspension {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChSolidThreeLinkAxle(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChSolidThreeLinkAxle_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChSolidThreeLinkAxle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChSolidThreeLinkAxle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string GetTemplateName() {
    string ret = vehiclePINVOKE.ChSolidThreeLinkAxle_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsSteerable() {
    bool ret = vehiclePINVOKE.ChSolidThreeLinkAxle_IsSteerable(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsIndependent() {
    bool ret = vehiclePINVOKE.ChSolidThreeLinkAxle_IsIndependent(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Initialize(ChChassis chassis, ChSubchassis subchassis, ChSteering steering, ChVectorD location, double left_ang_vel, double right_ang_vel) {
    vehiclePINVOKE.ChSolidThreeLinkAxle_Initialize__SWIG_0(swigCPtr, ChChassis.getCPtr(chassis), ChSubchassis.getCPtr(subchassis), ChSteering.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel, right_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, ChSubchassis subchassis, ChSteering steering, ChVectorD location, double left_ang_vel) {
    vehiclePINVOKE.ChSolidThreeLinkAxle_Initialize__SWIG_1(swigCPtr, ChChassis.getCPtr(chassis), ChSubchassis.getCPtr(subchassis), ChSteering.getCPtr(steering), ChVectorD.getCPtr(location), left_ang_vel);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChChassis chassis, ChSubchassis subchassis, ChSteering steering, ChVectorD location) {
    vehiclePINVOKE.ChSolidThreeLinkAxle_Initialize__SWIG_2(swigCPtr, ChChassis.getCPtr(chassis), ChSubchassis.getCPtr(subchassis), ChSteering.getCPtr(steering), ChVectorD.getCPtr(location));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void AddVisualizationAssets(VisualizationType vis) {
    vehiclePINVOKE.ChSolidThreeLinkAxle_AddVisualizationAssets(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void RemoveVisualizationAssets() {
    vehiclePINVOKE.ChSolidThreeLinkAxle_RemoveVisualizationAssets(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetTrack() {
    double ret = vehiclePINVOKE.ChSolidThreeLinkAxle_GetTrack(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChLinkTSDA GetSpring(VehicleSide side) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChSolidThreeLinkAxle_GetSpring(swigCPtr, (int)side);
    ChLinkTSDA ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkTSDA(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChLinkTSDA GetShock(VehicleSide side) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChSolidThreeLinkAxle_GetShock(swigCPtr, (int)side);
    ChLinkTSDA ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkTSDA(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SWIGTYPE_p_std__vectorT_chrono__vehicle__ChSuspension__ForceTSDA_t ReportSuspensionForce(VehicleSide side) {
    SWIGTYPE_p_std__vectorT_chrono__vehicle__ChSuspension__ForceTSDA_t ret = new SWIGTYPE_p_std__vectorT_chrono__vehicle__ChSuspension__ForceTSDA_t(vehiclePINVOKE.ChSolidThreeLinkAxle_ReportSuspensionForce(swigCPtr, (int)side), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSpringForce(VehicleSide side) {
    double ret = vehiclePINVOKE.ChSolidThreeLinkAxle_GetSpringForce(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSpringLength(VehicleSide side) {
    double ret = vehiclePINVOKE.ChSolidThreeLinkAxle_GetSpringLength(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSpringDeformation(VehicleSide side) {
    double ret = vehiclePINVOKE.ChSolidThreeLinkAxle_GetSpringDeformation(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockForce(VehicleSide side) {
    double ret = vehiclePINVOKE.ChSolidThreeLinkAxle_GetShockForce(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockLength(VehicleSide side) {
    double ret = vehiclePINVOKE.ChSolidThreeLinkAxle_GetShockLength(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetShockVelocity(VehicleSide side) {
    double ret = vehiclePINVOKE.ChSolidThreeLinkAxle_GetShockVelocity(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void LogConstraintViolations(VehicleSide side) {
    vehiclePINVOKE.ChSolidThreeLinkAxle_LogConstraintViolations(swigCPtr, (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LogHardpointLocations(ChVectorD ref_, bool inches) {
    vehiclePINVOKE.ChSolidThreeLinkAxle_LogHardpointLocations__SWIG_0(swigCPtr, ChVectorD.getCPtr(ref_), inches);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LogHardpointLocations(ChVectorD ref_) {
    vehiclePINVOKE.ChSolidThreeLinkAxle_LogHardpointLocations__SWIG_1(swigCPtr, ChVectorD.getCPtr(ref_));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
