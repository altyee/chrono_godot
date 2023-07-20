//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadXYZnodeForceAbsolute : ChLoadXYZnodeForce {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLoadXYZnodeForceAbsolute(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChLoadXYZnodeForceAbsolute_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadXYZnodeForceAbsolute obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChLoadXYZnodeForceAbsolute(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLoadXYZnodeForceAbsolute(ChNodeXYZ node, ChVectorD force) : this(corePINVOKE.new_ChLoadXYZnodeForceAbsolute(ChNodeXYZ.getCPtr(node), ChVectorD.getCPtr(force)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ComputeForce(ChVectorD abs_pos, ChVectorD abs_vel, ChVectorD abs_force) {
    corePINVOKE.ChLoadXYZnodeForceAbsolute_ComputeForce(swigCPtr, ChVectorD.getCPtr(abs_pos), ChVectorD.getCPtr(abs_vel), ChVectorD.getCPtr(abs_force));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetForceBase(ChVectorD force) {
    corePINVOKE.ChLoadXYZnodeForceAbsolute_SetForceBase(swigCPtr, ChVectorD.getCPtr(force));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public new ChVectorD GetForce() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChLoadXYZnodeForceAbsolute_GetForce(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetModulationFunction(ChFunction modulation) {
    corePINVOKE.ChLoadXYZnodeForceAbsolute_SetModulationFunction(swigCPtr, ChFunction.getCPtr(modulation));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
