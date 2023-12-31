//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChDataDriver : ChDriver {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChDataDriver(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChDataDriver_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChDataDriver obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChDataDriver(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChDataDriver(ChVehicle vehicle, string filename, bool sorted) : this(vehiclePINVOKE.new_ChDataDriver__SWIG_0(ChVehicle.getCPtr(vehicle), filename, sorted), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChDataDriver(ChVehicle vehicle, string filename) : this(vehiclePINVOKE.new_ChDataDriver__SWIG_1(ChVehicle.getCPtr(vehicle), filename), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChDataDriver(ChVehicle vehicle, vector_Entry data, bool sorted) : this(vehiclePINVOKE.new_ChDataDriver__SWIG_2(ChVehicle.getCPtr(vehicle), vector_Entry.getCPtr(data), sorted), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChDataDriver(ChVehicle vehicle, vector_Entry data) : this(vehiclePINVOKE.new_ChDataDriver__SWIG_3(ChVehicle.getCPtr(vehicle), vector_Entry.getCPtr(data)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Synchronize(double time) {
    vehiclePINVOKE.ChDataDriver_Synchronize(swigCPtr, time);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
