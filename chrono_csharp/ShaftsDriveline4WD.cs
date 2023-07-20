//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ShaftsDriveline4WD : ChShaftsDriveline4WD {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ShaftsDriveline4WD(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ShaftsDriveline4WD_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ShaftsDriveline4WD obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ShaftsDriveline4WD(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ShaftsDriveline4WD(string filename) : this(vehiclePINVOKE.new_ShaftsDriveline4WD__SWIG_0(filename), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ShaftsDriveline4WD(SWIGTYPE_p_rapidjson__Document d) : this(vehiclePINVOKE.new_ShaftsDriveline4WD__SWIG_1(SWIGTYPE_p_rapidjson__Document.getCPtr(d)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetCentralDifferentialBoxInertia() {
    double ret = vehiclePINVOKE.ShaftsDriveline4WD_GetCentralDifferentialBoxInertia(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetFrontDifferentialBoxInertia() {
    double ret = vehiclePINVOKE.ShaftsDriveline4WD_GetFrontDifferentialBoxInertia(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetRearDifferentialBoxInertia() {
    double ret = vehiclePINVOKE.ShaftsDriveline4WD_GetRearDifferentialBoxInertia(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetDriveshaftInertia() {
    double ret = vehiclePINVOKE.ShaftsDriveline4WD_GetDriveshaftInertia(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToFrontDiffShaftInertia() {
    double ret = vehiclePINVOKE.ShaftsDriveline4WD_GetToFrontDiffShaftInertia(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToRearDiffShaftInertia() {
    double ret = vehiclePINVOKE.ShaftsDriveline4WD_GetToRearDiffShaftInertia(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetFrontConicalGearRatio() {
    double ret = vehiclePINVOKE.ShaftsDriveline4WD_GetFrontConicalGearRatio(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetRearConicalGearRatio() {
    double ret = vehiclePINVOKE.ShaftsDriveline4WD_GetRearConicalGearRatio(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetAxleDifferentialLockingLimit() {
    double ret = vehiclePINVOKE.ShaftsDriveline4WD_GetAxleDifferentialLockingLimit(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetCentralDifferentialLockingLimit() {
    double ret = vehiclePINVOKE.ShaftsDriveline4WD_GetCentralDifferentialLockingLimit(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}