//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Sedan_AutomaticTransmissionSimpleMap : ChAutomaticTransmissionSimpleMap {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal Sedan_AutomaticTransmissionSimpleMap(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.Sedan_AutomaticTransmissionSimpleMap_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Sedan_AutomaticTransmissionSimpleMap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_Sedan_AutomaticTransmissionSimpleMap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public Sedan_AutomaticTransmissionSimpleMap(string name) : this(vehiclePINVOKE.new_Sedan_AutomaticTransmissionSimpleMap(name), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetGearRatios(vector_double fwd, SWIGTYPE_p_double rev) {
    vehiclePINVOKE.Sedan_AutomaticTransmissionSimpleMap_SetGearRatios(swigCPtr, vector_double.getCPtr(fwd), SWIGTYPE_p_double.getCPtr(rev));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetShiftPoints(SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t shift_bands) {
    vehiclePINVOKE.Sedan_AutomaticTransmissionSimpleMap_SetShiftPoints(swigCPtr, SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t.getCPtr(shift_bands));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
