//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class MAN_5t_EngineSimpleMap : ChEngineSimpleMap {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal MAN_5t_EngineSimpleMap(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.MAN_5t_EngineSimpleMap_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MAN_5t_EngineSimpleMap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_MAN_5t_EngineSimpleMap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public MAN_5t_EngineSimpleMap(string name) : this(vehiclePINVOKE.new_MAN_5t_EngineSimpleMap(name), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetMaxEngineSpeed() {
    double ret = vehiclePINVOKE.MAN_5t_EngineSimpleMap_GetMaxEngineSpeed(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetEngineTorqueMaps(SWIGTYPE_p_ChFunction_Recorder map0, SWIGTYPE_p_ChFunction_Recorder mapF) {
    vehiclePINVOKE.MAN_5t_EngineSimpleMap_SetEngineTorqueMaps(swigCPtr, SWIGTYPE_p_ChFunction_Recorder.getCPtr(map0), SWIGTYPE_p_ChFunction_Recorder.getCPtr(mapF));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
