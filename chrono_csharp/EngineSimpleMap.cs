//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class EngineSimpleMap : ChEngineSimpleMap {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal EngineSimpleMap(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.EngineSimpleMap_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EngineSimpleMap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_EngineSimpleMap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public EngineSimpleMap(string filename) : this(vehiclePINVOKE.new_EngineSimpleMap__SWIG_0(filename), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public EngineSimpleMap(SWIGTYPE_p_rapidjson__Document d) : this(vehiclePINVOKE.new_EngineSimpleMap__SWIG_1(SWIGTYPE_p_rapidjson__Document.getCPtr(d)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetMaxEngineSpeed() {
    double ret = vehiclePINVOKE.EngineSimpleMap_GetMaxEngineSpeed(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetEngineTorqueMaps(SWIGTYPE_p_ChFunction_Recorder map0, SWIGTYPE_p_ChFunction_Recorder mapF) {
    vehiclePINVOKE.EngineSimpleMap_SetEngineTorqueMaps(swigCPtr, SWIGTYPE_p_ChFunction_Recorder.getCPtr(map0), SWIGTYPE_p_ChFunction_Recorder.getCPtr(mapF));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
