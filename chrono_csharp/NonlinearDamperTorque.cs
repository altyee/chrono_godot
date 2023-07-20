//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class NonlinearDamperTorque : TorqueFunctor {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal NonlinearDamperTorque(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.NonlinearDamperTorque_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NonlinearDamperTorque obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_NonlinearDamperTorque(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public NonlinearDamperTorque() : this(vehiclePINVOKE.new_NonlinearDamperTorque__SWIG_0(), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public NonlinearDamperTorque(SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t dataC) : this(vehiclePINVOKE.new_NonlinearDamperTorque__SWIG_1(SWIGTYPE_p_std__vectorT_std__pairT_double_double_t_t.getCPtr(dataC)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_pointC(double x, double y) {
    vehiclePINVOKE.NonlinearDamperTorque_add_pointC(swigCPtr, x, y);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double evaluate(double time, double rest_angle, double angle, double vel, ChLinkRSDA link) {
    double ret = vehiclePINVOKE.NonlinearDamperTorque_evaluate(swigCPtr, time, rest_angle, angle, vel, ChLinkRSDA.getCPtr(link));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
