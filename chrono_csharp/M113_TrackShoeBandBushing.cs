//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class M113_TrackShoeBandBushing : ChTrackShoeBandBushing {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal M113_TrackShoeBandBushing(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.M113_TrackShoeBandBushing_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(M113_TrackShoeBandBushing obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_M113_TrackShoeBandBushing(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public M113_TrackShoeBandBushing(string name) : this(vehiclePINVOKE.new_M113_TrackShoeBandBushing(name), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override GuidePinType GetType() {
    GuidePinType ret = (GuidePinType)vehiclePINVOKE.M113_TrackShoeBandBushing_GetType(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetHeight() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetHeight(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTreadMass() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetTreadMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetWebMass() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetWebMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetTreadInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.M113_TrackShoeBandBushing_GetTreadInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetWebInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.M113_TrackShoeBandBushing_GetWebInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetGuideBoxDimensions() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.M113_TrackShoeBandBushing_GetGuideBoxDimensions(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetGuideBoxOffsetX() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetGuideBoxOffsetX(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetBeltWidth() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetBeltWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToothTipLength() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetToothTipLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToothBaseLength() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetToothBaseLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToothWidth() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetToothWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToothHeight() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetToothHeight(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetToothArcRadius() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetToothArcRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetNumWebSegments() {
    int ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetNumWebSegments(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetWebLength() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetWebLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetWebThickness() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetWebThickness(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTreadLength() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetTreadLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetTreadThickness() {
    double ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetTreadThickness(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_std__shared_ptrT_ChVehicleBushingData_t GetBushingData() {
    SWIGTYPE_p_std__shared_ptrT_ChVehicleBushingData_t ret = new SWIGTYPE_p_std__shared_ptrT_ChVehicleBushingData_t(vehiclePINVOKE.M113_TrackShoeBandBushing_GetBushingData(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string GetTreadVisualizationMeshName() {
    string ret = vehiclePINVOKE.M113_TrackShoeBandBushing_GetTreadVisualizationMeshName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
