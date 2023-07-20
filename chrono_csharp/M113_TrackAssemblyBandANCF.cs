//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class M113_TrackAssemblyBandANCF : ChTrackAssemblyBandANCF {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal M113_TrackAssemblyBandANCF(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.M113_TrackAssemblyBandANCF_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(M113_TrackAssemblyBandANCF obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_M113_TrackAssemblyBandANCF(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public M113_TrackAssemblyBandANCF(VehicleSide side, BrakeType brake_type, ChTrackShoeBandANCF.ElementType element_type, bool constrain_curvature, int num_elements_length, int num_elements_width, bool use_suspension_bushings) : this(vehiclePINVOKE.new_M113_TrackAssemblyBandANCF((int)side, (int)brake_type, (int)element_type, constrain_curvature, num_elements_length, num_elements_width, use_suspension_bushings), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChVectorD GetSprocketLocation() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.M113_TrackAssemblyBandANCF_GetSprocketLocation(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD GetIdlerLocation() {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.M113_TrackAssemblyBandANCF_GetIdlerLocation(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorD GetRoadWhelAssemblyLocation(int which) {
    ChVectorD ret = new ChVectorD(vehiclePINVOKE.M113_TrackAssemblyBandANCF_GetRoadWhelAssemblyLocation(swigCPtr, which), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
