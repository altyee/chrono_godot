//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class NonlinearSpringDamperForce : SpringForce {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal NonlinearSpringDamperForce(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.NonlinearSpringDamperForce_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NonlinearSpringDamperForce obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_NonlinearSpringDamperForce(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public NonlinearSpringDamperForce(double preload) : this(vehiclePINVOKE.new_NonlinearSpringDamperForce__SWIG_0(preload), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public NonlinearSpringDamperForce() : this(vehiclePINVOKE.new_NonlinearSpringDamperForce__SWIG_1(), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public NonlinearSpringDamperForce(SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t dataK, SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t dataC, double preload) : this(vehiclePINVOKE.new_NonlinearSpringDamperForce__SWIG_2(SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t.getCPtr(dataK), SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t.getCPtr(dataC), preload), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public NonlinearSpringDamperForce(SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t dataK, SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t dataC) : this(vehiclePINVOKE.new_NonlinearSpringDamperForce__SWIG_3(SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t.getCPtr(dataK), SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t.getCPtr(dataC)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_pointK(double x, double y) {
    vehiclePINVOKE.NonlinearSpringDamperForce_add_pointK(swigCPtr, x, y);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_pointC(double x, double y) {
    vehiclePINVOKE.NonlinearSpringDamperForce_add_pointC(swigCPtr, x, y);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double evaluate(double time, double rest_length, double length, double vel, ChLinkTSDA link) {
    double ret = vehiclePINVOKE.NonlinearSpringDamperForce_evaluate(swigCPtr, time, rest_length, length, vel, ChLinkTSDA.getCPtr(link));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
