//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChPathSteeringController : ChSteeringController {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ChPathSteeringController(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChPathSteeringController_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChPathSteeringController obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ChPathSteeringController obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          vehiclePINVOKE.delete_ChPathSteeringController(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChPathSteeringController(ChBezierCurve path) : this(vehiclePINVOKE.new_ChPathSteeringController__SWIG_0(ChBezierCurve.getCPtr(path)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChPathSteeringController(string filename, ChBezierCurve path) : this(vehiclePINVOKE.new_ChPathSteeringController__SWIG_1(filename, ChBezierCurve.getCPtr(path)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetGains(double Kp, double Ki, double Kd) {
    vehiclePINVOKE.ChPathSteeringController_SetGains(swigCPtr, Kp, Ki, Kd);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Reset(ChVehicle vehicle) {
    vehiclePINVOKE.ChPathSteeringController_Reset(swigCPtr, ChVehicle.getCPtr(vehicle));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void CalcTargetLocation() {
    vehiclePINVOKE.ChPathSteeringController_CalcTargetLocation(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double Advance(ChVehicle vehicle, double step) {
    double ret = vehiclePINVOKE.ChPathSteeringController_Advance(swigCPtr, ChVehicle.getCPtr(vehicle), step);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
