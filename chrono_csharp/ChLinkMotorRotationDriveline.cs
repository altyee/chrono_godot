//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkMotorRotationDriveline : ChLinkMotorRotation {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinkMotorRotationDriveline(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChLinkMotorRotationDriveline_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkMotorRotationDriveline obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChLinkMotorRotationDriveline(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinkMotorRotationDriveline() : this(corePINVOKE.new_ChLinkMotorRotationDriveline__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkMotorRotationDriveline(ChLinkMotorRotationDriveline other) : this(corePINVOKE.new_ChLinkMotorRotationDriveline__SWIG_1(ChLinkMotorRotationDriveline.getCPtr(other)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetSystem(ChSystem m_system) {
    corePINVOKE.ChLinkMotorRotationDriveline_SetSystem(swigCPtr, ChSystem.getCPtr(m_system));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChShaft GetInnerShaft1() {
    global::System.IntPtr cPtr = corePINVOKE.ChLinkMotorRotationDriveline_GetInnerShaft1(swigCPtr);
    ChShaft ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChShaft(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChShaft GetInnerShaft2() {
    global::System.IntPtr cPtr = corePINVOKE.ChLinkMotorRotationDriveline_GetInnerShaft2(swigCPtr);
    ChShaft ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChShaft(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetInnerTorque1() {
    double ret = corePINVOKE.ChLinkMotorRotationDriveline_GetInnerTorque1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetInnerTorque2() {
    double ret = corePINVOKE.ChLinkMotorRotationDriveline_GetInnerTorque2(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetMotorTorque() {
    double ret = corePINVOKE.ChLinkMotorRotationDriveline_GetMotorTorque(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Initialize(ChBodyFrame mbody1, ChBodyFrame mbody2, ChFrameD mabsframe) {
    corePINVOKE.ChLinkMotorRotationDriveline_Initialize__SWIG_0(swigCPtr, ChBodyFrame.getCPtr(mbody1), ChBodyFrame.getCPtr(mbody2), ChFrameD.getCPtr(mabsframe));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChBodyFrame mbody1, ChBodyFrame mbody2, bool pos_are_relative, ChFrameD mframe1, ChFrameD mframe2) {
    corePINVOKE.ChLinkMotorRotationDriveline_Initialize__SWIG_1(swigCPtr, ChBodyFrame.getCPtr(mbody1), ChBodyFrame.getCPtr(mbody2), pos_are_relative, ChFrameD.getCPtr(mframe1), ChFrameD.getCPtr(mframe2));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Initialize(ChBodyFrame mbody1, ChBodyFrame mbody2, bool pos_are_relative, ChVectorD mpt1, ChVectorD mpt2, ChVectorD mnorm1, ChVectorD mnorm2) {
    corePINVOKE.ChLinkMotorRotationDriveline_Initialize__SWIG_2(swigCPtr, ChBodyFrame.getCPtr(mbody1), ChBodyFrame.getCPtr(mbody2), pos_are_relative, ChVectorD.getCPtr(mpt1), ChVectorD.getCPtr(mpt2), ChVectorD.getCPtr(mnorm1), ChVectorD.getCPtr(mnorm2));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Setup() {
    corePINVOKE.ChLinkMotorRotationDriveline_Setup(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mytime, bool update_assets) {
    corePINVOKE.ChLinkMotorRotationDriveline_Update__SWIG_0(swigCPtr, mytime, update_assets);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mytime) {
    corePINVOKE.ChLinkMotorRotationDriveline_Update__SWIG_1(swigCPtr, mytime);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override int GetDOF() {
    int ret = corePINVOKE.ChLinkMotorRotationDriveline_GetDOF(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOC() {
    int ret = corePINVOKE.ChLinkMotorRotationDriveline_GetDOC(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOC_c() {
    int ret = corePINVOKE.ChLinkMotorRotationDriveline_GetDOC_c(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void IntStateGather(uint off_x, ChState x, uint off_v, ChStateDelta v, SWIGTYPE_p_double T) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntStateGather(swigCPtr, off_x, ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(v), SWIGTYPE_p_double.getCPtr(T));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatter(uint off_x, ChState x, uint off_v, ChStateDelta v, double T, bool full_update) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntStateScatter(swigCPtr, off_x, ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(v), T, full_update);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateGatherAcceleration(uint off_a, ChStateDelta a) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntStateGatherAcceleration(swigCPtr, off_a, ChStateDelta.getCPtr(a));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatterAcceleration(uint off_a, ChStateDelta a) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntStateScatterAcceleration(swigCPtr, off_a, ChStateDelta.getCPtr(a));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateIncrement(uint off_x, ChState x_new, ChState x, uint off_v, ChStateDelta Dv) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntStateIncrement(swigCPtr, off_x, ChState.getCPtr(x_new), ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(Dv));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateGetIncrement(uint off_x, ChState x_new, ChState x, uint off_v, ChStateDelta Dv) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntStateGetIncrement(swigCPtr, off_x, ChState.getCPtr(x_new), ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(Dv));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateGatherReactions(uint off_L, ChVectorDynamicD L) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntStateGatherReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatterReactions(uint off_L, ChVectorDynamicD L) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntStateScatterReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_F(uint off, ChVectorDynamicD R, double c) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntLoadResidual_F(swigCPtr, off, ChVectorDynamicD.getCPtr(R), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_Mv(uint off, ChVectorDynamicD R, ChVectorDynamicD w, double c) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntLoadResidual_Mv(swigCPtr, off, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(w), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_CqL(uint off_L, ChVectorDynamicD R, ChVectorDynamicD L, double c) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntLoadResidual_CqL(swigCPtr, off_L, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(L), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadConstraint_C(uint off, ChVectorDynamicD Qc, double c, bool do_clamp, double recovery_clamp) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntLoadConstraint_C(swigCPtr, off, ChVectorDynamicD.getCPtr(Qc), c, do_clamp, recovery_clamp);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadConstraint_Ct(uint off, ChVectorDynamicD Qc, double c) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntLoadConstraint_Ct(swigCPtr, off, ChVectorDynamicD.getCPtr(Qc), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntToDescriptor(uint off_v, ChStateDelta v, ChVectorDynamicD R, uint off_L, ChVectorDynamicD L, ChVectorDynamicD Qc) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntToDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), ChVectorDynamicD.getCPtr(R), off_L, ChVectorDynamicD.getCPtr(L), ChVectorDynamicD.getCPtr(Qc));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntFromDescriptor(uint off_v, ChStateDelta v, uint off_L, ChVectorDynamicD L) {
    corePINVOKE.ChLinkMotorRotationDriveline_IntFromDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), off_L, ChVectorDynamicD.getCPtr(L));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InjectConstraints(SWIGTYPE_p_ChSystemDescriptor mdescriptor) {
    corePINVOKE.ChLinkMotorRotationDriveline_InjectConstraints(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(mdescriptor));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiReset() {
    corePINVOKE.ChLinkMotorRotationDriveline_ConstraintsBiReset(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp, bool do_clamp) {
    corePINVOKE.ChLinkMotorRotationDriveline_ConstraintsBiLoad_C__SWIG_0(swigCPtr, factor, recovery_clamp, do_clamp);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp) {
    corePINVOKE.ChLinkMotorRotationDriveline_ConstraintsBiLoad_C__SWIG_1(swigCPtr, factor, recovery_clamp);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor) {
    corePINVOKE.ChLinkMotorRotationDriveline_ConstraintsBiLoad_C__SWIG_2(swigCPtr, factor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C() {
    corePINVOKE.ChLinkMotorRotationDriveline_ConstraintsBiLoad_C__SWIG_3(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Ct(double factor) {
    corePINVOKE.ChLinkMotorRotationDriveline_ConstraintsBiLoad_Ct__SWIG_0(swigCPtr, factor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_Ct() {
    corePINVOKE.ChLinkMotorRotationDriveline_ConstraintsBiLoad_Ct__SWIG_1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsLoadJacobians() {
    corePINVOKE.ChLinkMotorRotationDriveline_ConstraintsLoadJacobians(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react(double factor) {
    corePINVOKE.ChLinkMotorRotationDriveline_ConstraintsFetch_react__SWIG_0(swigCPtr, factor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react() {
    corePINVOKE.ChLinkMotorRotationDriveline_ConstraintsFetch_react__SWIG_1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InjectVariables(SWIGTYPE_p_ChSystemDescriptor mdescriptor) {
    corePINVOKE.ChLinkMotorRotationDriveline_InjectVariables(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(mdescriptor));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbReset() {
    corePINVOKE.ChLinkMotorRotationDriveline_VariablesFbReset(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbLoadForces(double factor) {
    corePINVOKE.ChLinkMotorRotationDriveline_VariablesFbLoadForces__SWIG_0(swigCPtr, factor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbLoadForces() {
    corePINVOKE.ChLinkMotorRotationDriveline_VariablesFbLoadForces__SWIG_1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbLoadSpeed() {
    corePINVOKE.ChLinkMotorRotationDriveline_VariablesQbLoadSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbIncrementMq() {
    corePINVOKE.ChLinkMotorRotationDriveline_VariablesFbIncrementMq(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbSetSpeed(double step) {
    corePINVOKE.ChLinkMotorRotationDriveline_VariablesQbSetSpeed__SWIG_0(swigCPtr, step);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbSetSpeed() {
    corePINVOKE.ChLinkMotorRotationDriveline_VariablesQbSetSpeed__SWIG_1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbIncrementPosition(double step) {
    corePINVOKE.ChLinkMotorRotationDriveline_VariablesQbIncrementPosition(swigCPtr, step);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChLinkMotorRotationDriveline_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChLinkMotorRotationDriveline_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}