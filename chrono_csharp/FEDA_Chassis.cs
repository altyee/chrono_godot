//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class FEDA_Chassis : ChRigidChassis {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal FEDA_Chassis(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.FEDA_Chassis_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FEDA_Chassis obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_FEDA_Chassis(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public FEDA_Chassis(string name, bool fixed_, CollisionType chassis_collision_type) : this(vehiclePINVOKE.new_FEDA_Chassis__SWIG_0(name, fixed_, (int)chassis_collision_type), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public FEDA_Chassis(string name, bool fixed_) : this(vehiclePINVOKE.new_FEDA_Chassis__SWIG_1(name, fixed_), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public FEDA_Chassis(string name) : this(vehiclePINVOKE.new_FEDA_Chassis__SWIG_2(name), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChCoordsysD GetLocalDriverCoordsys() {
    ChCoordsysD ret = new ChCoordsysD(vehiclePINVOKE.FEDA_Chassis_GetLocalDriverCoordsys(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
