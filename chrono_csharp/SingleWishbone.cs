//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class SingleWishbone : ChSingleWishbone {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal SingleWishbone(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.SingleWishbone_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SingleWishbone obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_SingleWishbone(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public SingleWishbone(string filename) : this(vehiclePINVOKE.new_SingleWishbone__SWIG_0(filename), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public SingleWishbone(SWIGTYPE_p_rapidjson__Document d) : this(vehiclePINVOKE.new_SingleWishbone__SWIG_1(SWIGTYPE_p_rapidjson__Document.getCPtr(d)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool UseTierodBodies() {
    bool ret = vehiclePINVOKE.SingleWishbone_UseTierodBodies(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getCamberAngle() {
    double ret = vehiclePINVOKE.SingleWishbone_getCamberAngle(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getToeAngle() {
    double ret = vehiclePINVOKE.SingleWishbone_getToeAngle(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getSpindleMass() {
    double ret = vehiclePINVOKE.SingleWishbone_getSpindleMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getCAMass() {
    double ret = vehiclePINVOKE.SingleWishbone_getCAMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getUprightMass() {
    double ret = vehiclePINVOKE.SingleWishbone_getUprightMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getTierodMass() {
    double ret = vehiclePINVOKE.SingleWishbone_getTierodMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double getSpindleRadius() {
    double ret = vehiclePINVOKE.SingleWishbone_getSpindleRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double getSpindleWidth() {
    double ret = vehiclePINVOKE.SingleWishbone_getSpindleWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getCARadius() {
    double ret = vehiclePINVOKE.SingleWishbone_getCARadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getUprightRadius() {
    double ret = vehiclePINVOKE.SingleWishbone_getUprightRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getTierodRadius() {
    double ret = vehiclePINVOKE.SingleWishbone_getTierodRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getSpindleInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.SingleWishbone_getSpindleInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getCAInertiaMoments() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.SingleWishbone_getCAInertiaMoments(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getCAInertiaProducts() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.SingleWishbone_getCAInertiaProducts(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getUprightInertiaMoments() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.SingleWishbone_getUprightInertiaMoments(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getUprightInertiaProducts() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.SingleWishbone_getUprightInertiaProducts(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD getTierodInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.SingleWishbone_getTierodInertia(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getAxleInertia() {
    double ret = vehiclePINVOKE.SingleWishbone_getAxleInertia(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getShockRestLength() {
    double ret = vehiclePINVOKE.SingleWishbone_getShockRestLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ForceFunctor getShockForceFunctor() {
    global::System.IntPtr cPtr = vehiclePINVOKE.SingleWishbone_getShockForceFunctor(swigCPtr);
    ForceFunctor ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceFunctor(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_std__shared_ptrT_ChVehicleBushingData_t getCABushingData() {
    SWIGTYPE_p_std__shared_ptrT_ChVehicleBushingData_t ret = new SWIGTYPE_p_std__shared_ptrT_ChVehicleBushingData_t(vehiclePINVOKE.SingleWishbone_getCABushingData(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_std__shared_ptrT_ChVehicleBushingData_t getTierodBushingData() {
    SWIGTYPE_p_std__shared_ptrT_ChVehicleBushingData_t ret = new SWIGTYPE_p_std__shared_ptrT_ChVehicleBushingData_t(vehiclePINVOKE.SingleWishbone_getTierodBushingData(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
