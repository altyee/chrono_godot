//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChRandomParticleVelocityAnyDirection : ChRandomParticleVelocity {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChRandomParticleVelocityAnyDirection(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChRandomParticleVelocityAnyDirection_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChRandomParticleVelocityAnyDirection obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChRandomParticleVelocityAnyDirection(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChRandomParticleVelocityAnyDirection() : this(corePINVOKE.new_ChRandomParticleVelocityAnyDirection(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChVectorD RandomVelocity() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChRandomParticleVelocityAnyDirection_RandomVelocity(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetModulusDistribution(ChDistribution mdistr) {
    corePINVOKE.ChRandomParticleVelocityAnyDirection_SetModulusDistribution__SWIG_0(swigCPtr, ChDistribution.getCPtr(mdistr));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetModulusDistribution(double mval) {
    corePINVOKE.ChRandomParticleVelocityAnyDirection_SetModulusDistribution__SWIG_1(swigCPtr, mval);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
