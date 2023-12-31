//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkMotionImposed : ChLinkMateGeneric {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinkMotionImposed(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChLinkMotionImposed_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkMotionImposed obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChLinkMotionImposed(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinkMotionImposed() : this(corePINVOKE.new_ChLinkMotionImposed__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkMotionImposed(ChLinkMotionImposed other) : this(corePINVOKE.new_ChLinkMotionImposed__SWIG_1(ChLinkMotionImposed.getCPtr(other)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetPositionFunction(ChFunctionPosition mf) {
    corePINVOKE.ChLinkMotionImposed_SetPositionFunction(swigCPtr, ChFunctionPosition.getCPtr(mf));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionPosition GetPositionFunction() {
    global::System.IntPtr cPtr = corePINVOKE.ChLinkMotionImposed_GetPositionFunction(swigCPtr);
    ChFunctionPosition ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunctionPosition(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRotationFunction(ChFunctionRotation mf) {
    corePINVOKE.ChLinkMotionImposed_SetRotationFunction(swigCPtr, ChFunctionRotation.getCPtr(mf));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionRotation GetRotationFunction() {
    global::System.IntPtr cPtr = corePINVOKE.ChLinkMotionImposed_GetRotationFunction(swigCPtr);
    ChFunctionRotation ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunctionRotation(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFrameD GetFrameM2() {
    ChFrameD ret = new ChFrameD(corePINVOKE.ChLinkMotionImposed_GetFrameM2(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChCoordsysD GetLinkRelativeCoords() {
    ChCoordsysD ret = new ChCoordsysD(corePINVOKE.ChLinkMotionImposed_GetLinkRelativeCoords(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Update(double mytime, bool update_assets) {
    corePINVOKE.ChLinkMotionImposed_Update(swigCPtr, mytime, update_assets);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadConstraint_Ct(uint off, ChVectorDynamicD Qc, double c) {
    corePINVOKE.ChLinkMotionImposed_IntLoadConstraint_Ct(swigCPtr, off, ChVectorDynamicD.getCPtr(Qc), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Ct(double factor) {
    corePINVOKE.ChLinkMotionImposed_ConstraintsBiLoad_Ct__SWIG_0(swigCPtr, factor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Ct() {
    corePINVOKE.ChLinkMotionImposed_ConstraintsBiLoad_Ct__SWIG_1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void KRMmatricesLoad(double Kfactor, double Rfactor, double Mfactor) {
    corePINVOKE.ChLinkMotionImposed_KRMmatricesLoad(swigCPtr, Kfactor, Rfactor, Mfactor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChLinkMotionImposed_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChLinkMotionImposed_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
