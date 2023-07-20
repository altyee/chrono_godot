//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChFunctionRotation_SQUAD : ChFunctionRotation {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChFunctionRotation_SQUAD(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChFunctionRotation_SQUAD_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChFunctionRotation_SQUAD obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChFunctionRotation_SQUAD(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChFunctionRotation_SQUAD() : this(corePINVOKE.new_ChFunctionRotation_SQUAD__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionRotation_SQUAD(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t mrotations, ChVectorDynamicD mknots) : this(corePINVOKE.new_ChFunctionRotation_SQUAD__SWIG_1(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t.getCPtr(mrotations), ChVectorDynamicD.getCPtr(mknots)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionRotation_SQUAD(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t mrotations) : this(corePINVOKE.new_ChFunctionRotation_SQUAD__SWIG_2(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t.getCPtr(mrotations)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunctionRotation_SQUAD(ChFunctionRotation_SQUAD other) : this(corePINVOKE.new_ChFunctionRotation_SQUAD__SWIG_3(ChFunctionRotation_SQUAD.getCPtr(other)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double ComputeUfromKnotU(double u) {
    double ret = corePINVOKE.ChFunctionRotation_SQUAD_ComputeUfromKnotU(swigCPtr, u);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double ComputeKnotUfromU(double U) {
    double ret = corePINVOKE.ChFunctionRotation_SQUAD_ComputeKnotUfromU(swigCPtr, U);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t Rotations() {
    SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t ret = new SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t(corePINVOKE.ChFunctionRotation_SQUAD_Rotations(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorDynamicD Knots() {
    ChVectorDynamicD ret = new ChVectorDynamicD(corePINVOKE.ChFunctionRotation_SQUAD_Knots(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetOrder() {
    int ret = corePINVOKE.ChFunctionRotation_SQUAD_GetOrder(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetupData(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t mrotations, ChVectorDynamicD mknots) {
    corePINVOKE.ChFunctionRotation_SQUAD_SetupData__SWIG_0(swigCPtr, SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t.getCPtr(mrotations), ChVectorDynamicD.getCPtr(mknots));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetupData(SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t mrotations) {
    corePINVOKE.ChFunctionRotation_SQUAD_SetupData__SWIG_1(swigCPtr, SWIGTYPE_p_std__vectorT_chrono__ChQuaternionT_double_t_t.getCPtr(mrotations));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction GetSpaceFunction() {
    global::System.IntPtr cPtr = corePINVOKE.ChFunctionRotation_SQUAD_GetSpaceFunction(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSpaceFunction(ChFunction m_funct) {
    corePINVOKE.ChFunctionRotation_SQUAD_SetSpaceFunction(swigCPtr, ChFunction.getCPtr(m_funct));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetClosed(bool mc) {
    corePINVOKE.ChFunctionRotation_SQUAD_SetClosed(swigCPtr, mc);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetClosed() {
    bool ret = corePINVOKE.ChFunctionRotation_SQUAD_GetClosed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChQuaternionD Get_q(double s) {
    ChQuaternionD ret = new ChQuaternionD(corePINVOKE.ChFunctionRotation_SQUAD_Get_q(swigCPtr, s), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChFunctionRotation_SQUAD_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChFunctionRotation_SQUAD_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
