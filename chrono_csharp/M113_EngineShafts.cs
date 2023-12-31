//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class M113_EngineShafts : ChEngineShafts {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal M113_EngineShafts(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.M113_EngineShafts_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(M113_EngineShafts obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_M113_EngineShafts(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public M113_EngineShafts(string name) : this(vehiclePINVOKE.new_M113_EngineShafts(name), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetMotorBlockInertia() {
    double ret = vehiclePINVOKE.M113_EngineShafts_GetMotorBlockInertia(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetMotorshaftInertia() {
    double ret = vehiclePINVOKE.M113_EngineShafts_GetMotorshaftInertia(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetEngineTorqueMap(SWIGTYPE_p_std__shared_ptrT_ChFunction_Recorder_t map) {
    vehiclePINVOKE.M113_EngineShafts_SetEngineTorqueMap(swigCPtr, SWIGTYPE_p_std__shared_ptrT_ChFunction_Recorder_t.getCPtr(map));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetEngineLossesMap(SWIGTYPE_p_std__shared_ptrT_ChFunction_Recorder_t map) {
    vehiclePINVOKE.M113_EngineShafts_SetEngineLossesMap(swigCPtr, SWIGTYPE_p_std__shared_ptrT_ChFunction_Recorder_t.getCPtr(map));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
