//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTrackSuspension : ChPart {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChTrackSuspension(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChTrackSuspension_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTrackSuspension obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChTrackSuspension(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public GuidePinType GetType() {
    GuidePinType ret = (GuidePinType)vehiclePINVOKE.ChTrackSuspension_GetType(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChTrackWheel GetRoadWheel() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChTrackSuspension_GetRoadWheel(swigCPtr);
    ChTrackWheel ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChTrackWheel(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChBody GetWheelBody() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChTrackSuspension_GetWheelBody(swigCPtr);
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChBody GetCarrierBody() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChTrackSuspension_GetCarrierBody(swigCPtr);
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetCarrierAngle() {
    double ret = vehiclePINVOKE.ChTrackSuspension_GetCarrierAngle(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChLinkLockRevolute GetWheelRevolute() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChTrackSuspension_GetWheelRevolute(swigCPtr);
    ChLinkLockRevolute ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinkLockRevolute(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetWheelRadius() {
    double ret = vehiclePINVOKE.ChTrackSuspension_GetWheelRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Initialize(ChChassis chassis, ChVectorD location, ChTrackAssembly track) {
    vehiclePINVOKE.ChTrackSuspension_Initialize(swigCPtr, ChChassis.getCPtr(chassis), ChVectorD.getCPtr(location), ChTrackAssembly.getCPtr(track));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual ForceTorque ReportSuspensionForce() {
    ForceTorque ret = new ForceTorque(vehiclePINVOKE.ChTrackSuspension_ReportSuspensionForce(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void SetOutput(bool state) {
    vehiclePINVOKE.ChTrackSuspension_SetOutput(swigCPtr, state);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void LogConstraintViolations() {
    vehiclePINVOKE.ChTrackSuspension_LogConstraintViolations(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
