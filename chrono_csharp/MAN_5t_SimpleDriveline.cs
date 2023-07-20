//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class MAN_5t_SimpleDriveline : ChSimpleDriveline {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal MAN_5t_SimpleDriveline(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.MAN_5t_SimpleDriveline_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MAN_5t_SimpleDriveline obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_MAN_5t_SimpleDriveline(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public MAN_5t_SimpleDriveline(string name) : this(vehiclePINVOKE.new_MAN_5t_SimpleDriveline(name), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetFrontTorqueFraction() {
    double ret = vehiclePINVOKE.MAN_5t_SimpleDriveline_GetFrontTorqueFraction(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetFrontDifferentialMaxBias() {
    double ret = vehiclePINVOKE.MAN_5t_SimpleDriveline_GetFrontDifferentialMaxBias(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetRearDifferentialMaxBias() {
    double ret = vehiclePINVOKE.MAN_5t_SimpleDriveline_GetRearDifferentialMaxBias(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
