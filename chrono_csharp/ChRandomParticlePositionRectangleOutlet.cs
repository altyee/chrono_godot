//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChRandomParticlePositionRectangleOutlet : ChRandomParticlePosition {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChRandomParticlePositionRectangleOutlet(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChRandomParticlePositionRectangleOutlet_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChRandomParticlePositionRectangleOutlet obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChRandomParticlePositionRectangleOutlet(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChRandomParticlePositionRectangleOutlet() : this(corePINVOKE.new_ChRandomParticlePositionRectangleOutlet(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChVectorD RandomPosition() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChRandomParticlePositionRectangleOutlet_RandomPosition(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChCoordsysD Outlet() {
    ChCoordsysD ret = new ChCoordsysD(corePINVOKE.ChRandomParticlePositionRectangleOutlet_Outlet(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double OutletWidth() {
    SWIGTYPE_p_double ret = new SWIGTYPE_p_double(corePINVOKE.ChRandomParticlePositionRectangleOutlet_OutletWidth(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double OutletHeight() {
    SWIGTYPE_p_double ret = new SWIGTYPE_p_double(corePINVOKE.ChRandomParticlePositionRectangleOutlet_OutletHeight(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
