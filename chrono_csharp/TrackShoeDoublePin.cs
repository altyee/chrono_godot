//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TrackShoeDoublePin : ChTrackShoeDoublePin {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal TrackShoeDoublePin(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.TrackShoeDoublePin_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TrackShoeDoublePin obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_TrackShoeDoublePin(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public TrackShoeDoublePin(string filename) : this(vehiclePINVOKE.new_TrackShoeDoublePin__SWIG_0(filename), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public TrackShoeDoublePin(SWIGTYPE_p_rapidjson__Document d) : this(vehiclePINVOKE.new_TrackShoeDoublePin__SWIG_1(SWIGTYPE_p_rapidjson__Document.getCPtr(d)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override GuidePinType GetType() {
    GuidePinType ret = (GuidePinType)vehiclePINVOKE.TrackShoeDoublePin_GetType(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetHeight() {
    double ret = vehiclePINVOKE.TrackShoeDoublePin_GetHeight(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetShoeMass() {
    double ret = vehiclePINVOKE.TrackShoeDoublePin_GetShoeMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetShoeInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.TrackShoeDoublePin_GetShoeInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetShoeLength() {
    double ret = vehiclePINVOKE.TrackShoeDoublePin_GetShoeLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetShoeWidth() {
    double ret = vehiclePINVOKE.TrackShoeDoublePin_GetShoeWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetConnectorMass() {
    double ret = vehiclePINVOKE.TrackShoeDoublePin_GetConnectorMass(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetConnectorInertia() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.TrackShoeDoublePin_GetConnectorInertia(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetConnectorLength() {
    double ret = vehiclePINVOKE.TrackShoeDoublePin_GetConnectorLength(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetConnectorRadius() {
    double ret = vehiclePINVOKE.TrackShoeDoublePin_GetConnectorRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetConnectorWidth() {
    double ret = vehiclePINVOKE.TrackShoeDoublePin_GetConnectorWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD GetLateralContactPoint() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.TrackShoeDoublePin_GetLateralContactPoint(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override SWIGTYPE_p_ChVehicleGeometry GetGroundContactGeometry() {
    SWIGTYPE_p_ChVehicleGeometry ret = new SWIGTYPE_p_ChVehicleGeometry(vehiclePINVOKE.TrackShoeDoublePin_GetGroundContactGeometry(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
