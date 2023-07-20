//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChWheel : ChPart {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChWheel(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChWheel_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChWheel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChWheel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string GetTemplateName() {
    string ret = vehiclePINVOKE.ChWheel_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetRadius() {
    double ret = vehiclePINVOKE.ChWheel_GetRadius(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetWidth() {
    double ret = vehiclePINVOKE.ChWheel_GetWidth(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Initialize(ChBody spindle, VehicleSide side, double offset) {
    vehiclePINVOKE.ChWheel_Initialize__SWIG_0(swigCPtr, ChBody.getCPtr(spindle), (int)side, offset);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChBody spindle, VehicleSide side) {
    vehiclePINVOKE.ChWheel_Initialize__SWIG_1(swigCPtr, ChBody.getCPtr(spindle), (int)side);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetCollide(bool state) {
    vehiclePINVOKE.ChWheel_SetCollide(swigCPtr, state);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Synchronize() {
    vehiclePINVOKE.ChWheel_Synchronize(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChTire_t GetTire() {
    SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChTire_t ret = new SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChTire_t(vehiclePINVOKE.ChWheel_GetTire(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetTire(SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChTire_t tire) {
    vehiclePINVOKE.ChWheel_SetTire(swigCPtr, SWIGTYPE_p_std__shared_ptrT_chrono__vehicle__ChTire_t.getCPtr(tire));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBody GetSpindle() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChWheel_GetSpindle(swigCPtr);
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VehicleSide GetSide() {
    VehicleSide ret = (VehicleSide)vehiclePINVOKE.ChWheel_GetSide(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetPos() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.ChWheel_GetPos(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public WheelState GetState() {
    WheelState ret = new WheelState(vehiclePINVOKE.ChWheel_GetState(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void AddVisualizationAssets(VisualizationType vis) {
    vehiclePINVOKE.ChWheel_AddVisualizationAssets(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void RemoveVisualizationAssets() {
    vehiclePINVOKE.ChWheel_RemoveVisualizationAssets(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetMeshFilename() {
    string ret = vehiclePINVOKE.ChWheel_GetMeshFilename(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
