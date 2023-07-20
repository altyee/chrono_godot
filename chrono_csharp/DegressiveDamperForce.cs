//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class DegressiveDamperForce : ForceFunctor {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal DegressiveDamperForce(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.DegressiveDamperForce_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DegressiveDamperForce obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_DegressiveDamperForce(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public DegressiveDamperForce(double c_compression) : this(vehiclePINVOKE.new_DegressiveDamperForce__SWIG_0(c_compression), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public DegressiveDamperForce(double c_compression, double c_expansion) : this(vehiclePINVOKE.new_DegressiveDamperForce__SWIG_1(c_compression, c_expansion), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public DegressiveDamperForce(double c_compression, double degr_compression, double degr_expansion) : this(vehiclePINVOKE.new_DegressiveDamperForce__SWIG_2(c_compression, degr_compression, degr_expansion), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public DegressiveDamperForce(double c_compression, double degr_compression, double c_expansion, double degr_expansion) : this(vehiclePINVOKE.new_DegressiveDamperForce__SWIG_3(c_compression, degr_compression, c_expansion, degr_expansion), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double evaluate(double time, double rest_length, double length, double vel, ChLinkTSDA link) {
    double ret = vehiclePINVOKE.DegressiveDamperForce_evaluate(swigCPtr, time, rest_length, length, vel, ChLinkTSDA.getCPtr(link));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
