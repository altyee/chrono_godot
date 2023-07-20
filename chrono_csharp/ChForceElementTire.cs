//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChForceElementTire : ChTire {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChForceElementTire(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChForceElementTire_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChForceElementTire obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChForceElementTire(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override TerrainForce ReportTireForce(ChTerrain terrain) {
    TerrainForce ret = new TerrainForce(vehiclePINVOKE.ChForceElementTire_ReportTireForce__SWIG_0(swigCPtr, ChTerrain.getCPtr(terrain)), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TerrainForce ReportTireForce(ChTerrain terrain, ChCoordsysD tire_frame) {
    TerrainForce ret = new TerrainForce(vehiclePINVOKE.ChForceElementTire_ReportTireForce__SWIG_1(swigCPtr, ChTerrain.getCPtr(terrain), ChCoordsysD.getCPtr(tire_frame)), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
