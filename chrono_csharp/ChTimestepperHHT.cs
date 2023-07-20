//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTimestepperHHT : ChTimestepperIIorder {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChTimestepperHHT(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChTimestepperHHT_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTimestepperHHT obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChTimestepperHHT(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChTimestepperHHT(ChIntegrableIIorder intgr) : this(corePINVOKE.new_ChTimestepperHHT__SWIG_0(ChIntegrableIIorder.getCPtr(intgr)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChTimestepperHHT() : this(corePINVOKE.new_ChTimestepperHHT__SWIG_1(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChTimestepper.Type GetType() {
    ChTimestepper.Type ret = (ChTimestepper.Type)corePINVOKE.ChTimestepperHHT_GetType(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetAlpha(double malpha) {
    corePINVOKE.ChTimestepperHHT_SetAlpha(swigCPtr, malpha);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetAlpha() {
    double ret = corePINVOKE.ChTimestepperHHT_GetAlpha(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMode(ChTimestepperHHT.HHT_Mode mmode) {
    corePINVOKE.ChTimestepperHHT_SetMode(swigCPtr, (int)mmode);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetScaling(bool mscaling) {
    corePINVOKE.ChTimestepperHHT_SetScaling(swigCPtr, mscaling);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStepControl(bool val) {
    corePINVOKE.ChTimestepperHHT_SetStepControl(swigCPtr, val);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMinStepSize(double min_step) {
    corePINVOKE.ChTimestepperHHT_SetMinStepSize(swigCPtr, min_step);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaxItersSuccess(int iters) {
    corePINVOKE.ChTimestepperHHT_SetMaxItersSuccess(swigCPtr, iters);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRequiredSuccessfulSteps(int num_steps) {
    corePINVOKE.ChTimestepperHHT_SetRequiredSuccessfulSteps(swigCPtr, num_steps);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStepIncreaseFactor(double factor) {
    corePINVOKE.ChTimestepperHHT_SetStepIncreaseFactor(swigCPtr, factor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStepDecreaseFactor(double factor) {
    corePINVOKE.ChTimestepperHHT_SetStepDecreaseFactor(swigCPtr, factor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetModifiedNewton(bool val) {
    corePINVOKE.ChTimestepperHHT_SetModifiedNewton(swigCPtr, val);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Advance(double dt) {
    corePINVOKE.ChTimestepperHHT_Advance(swigCPtr, dt);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetConvergenceFlag() {
    bool ret = corePINVOKE.ChTimestepperHHT_GetConvergenceFlag(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetThreshold_R(double mv) {
    corePINVOKE.ChTimestepperHHT_SetThreshold_R(swigCPtr, mv);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetThreshold_R() {
    double ret = corePINVOKE.ChTimestepperHHT_GetThreshold_R(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut archive) {
    corePINVOKE.ChTimestepperHHT_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(archive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn archive) {
    corePINVOKE.ChTimestepperHHT_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(archive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMaxiters(int iters) {
    corePINVOKE.ChTimestepperHHT_SetMaxiters(swigCPtr, iters);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRelTolerance(double rel_tol) {
    corePINVOKE.ChTimestepperHHT_SetRelTolerance(swigCPtr, rel_tol);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAbsTolerances(double abs_tolS, double abs_tolL) {
    corePINVOKE.ChTimestepperHHT_SetAbsTolerances__SWIG_0(swigCPtr, abs_tolS, abs_tolL);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAbsTolerances(double abs_tol) {
    corePINVOKE.ChTimestepperHHT_SetAbsTolerances__SWIG_1(swigCPtr, abs_tol);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetNumIterations() {
    int ret = corePINVOKE.ChTimestepperHHT_GetNumIterations(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumSetupCalls() {
    int ret = corePINVOKE.ChTimestepperHHT_GetNumSetupCalls(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumSolveCalls() {
    int ret = corePINVOKE.ChTimestepperHHT_GetNumSolveCalls(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum HHT_Mode {
    ACCELERATION,
    POSITION
  }

}
