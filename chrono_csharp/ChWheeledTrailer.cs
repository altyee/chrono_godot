//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChWheeledTrailer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChWheeledTrailer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChWheeledTrailer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChWheeledTrailer() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          vehiclePINVOKE.delete_ChWheeledTrailer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string GetName() {
    string ret = vehiclePINVOKE.ChWheeledTrailer_GetName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetName(string name) {
    vehiclePINVOKE.ChWheeledTrailer_SetName(swigCPtr, name);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int GetNumberAxles() {
    int ret = vehiclePINVOKE.ChWheeledTrailer_GetNumberAxles(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string GetTemplateName() {
    string ret = vehiclePINVOKE.ChWheeledTrailer_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChChassisRear GetChassis() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChWheeledTrailer_GetChassis(swigCPtr);
    ChChassisRear ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChChassisRear(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChAxleList GetAxles() {
    ChAxleList ret = new ChAxleList(vehiclePINVOKE.ChWheeledTrailer_GetAxles(swigCPtr), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChAxle GetAxle(int id) {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChWheeledTrailer_GetAxle(swigCPtr, id);
    ChAxle ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChAxle(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetChassisVisualizationType(VisualizationType vis) {
    vehiclePINVOKE.ChWheeledTrailer_SetChassisVisualizationType(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSuspensionVisualizationType(VisualizationType vis) {
    vehiclePINVOKE.ChWheeledTrailer_SetSuspensionVisualizationType(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetWheelVisualizationType(VisualizationType vis) {
    vehiclePINVOKE.ChWheeledTrailer_SetWheelVisualizationType(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTireVisualizationType(VisualizationType vis) {
    vehiclePINVOKE.ChWheeledTrailer_SetTireVisualizationType(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Initialize(ChChassis frontChassis) {
    vehiclePINVOKE.ChWheeledTrailer_Initialize(swigCPtr, ChChassis.getCPtr(frontChassis));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InitializeTire(ChTire tire, ChWheel wheel, VisualizationType tire_vis, ChTire.CollisionType tire_coll) {
    vehiclePINVOKE.ChWheeledTrailer_InitializeTire__SWIG_0(swigCPtr, ChTire.getCPtr(tire), ChWheel.getCPtr(wheel), (int)tire_vis, (int)tire_coll);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InitializeTire(ChTire tire, ChWheel wheel, VisualizationType tire_vis) {
    vehiclePINVOKE.ChWheeledTrailer_InitializeTire__SWIG_1(swigCPtr, ChTire.getCPtr(tire), ChWheel.getCPtr(wheel), (int)tire_vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InitializeTire(ChTire tire, ChWheel wheel) {
    vehiclePINVOKE.ChWheeledTrailer_InitializeTire__SWIG_2(swigCPtr, ChTire.getCPtr(tire), ChWheel.getCPtr(wheel));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Synchronize(double time, DriverInputs driver_inputs, ChTerrain terrain) {
    vehiclePINVOKE.ChWheeledTrailer_Synchronize(swigCPtr, time, DriverInputs.getCPtr(driver_inputs), ChTerrain.getCPtr(terrain));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Advance(double step) {
    vehiclePINVOKE.ChWheeledTrailer_Advance(swigCPtr, step);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
