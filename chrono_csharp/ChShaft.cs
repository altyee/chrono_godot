//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChShaft : ChPhysicsItem {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChShaft(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChShaft_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChShaft obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChShaft(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChShaft() : this(corePINVOKE.new_ChShaft__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChShaft(ChShaft other) : this(corePINVOKE.new_ChShaft__SWIG_1(ChShaft.getCPtr(other)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetShaftFixed(bool mev) {
    corePINVOKE.ChShaft_SetShaftFixed(swigCPtr, mev);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetShaftFixed() {
    bool ret = corePINVOKE.ChShaft_GetShaftFixed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLimitSpeed(bool mlimit) {
    corePINVOKE.ChShaft_SetLimitSpeed(swigCPtr, mlimit);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetLimitSpeed() {
    bool ret = corePINVOKE.ChShaft_GetLimitSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetUseSleeping(bool ms) {
    corePINVOKE.ChShaft_SetUseSleeping(swigCPtr, ms);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetUseSleeping() {
    bool ret = corePINVOKE.ChShaft_GetUseSleeping(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSleeping(bool ms) {
    corePINVOKE.ChShaft_SetSleeping(swigCPtr, ms);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetSleeping() {
    bool ret = corePINVOKE.ChShaft_GetSleeping(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool TrySleeping() {
    bool ret = corePINVOKE.ChShaft_TrySleeping(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool IsActive() {
    bool ret = corePINVOKE.ChShaft_IsActive(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetId(uint identifier) {
    corePINVOKE.ChShaft_SetId(swigCPtr, identifier);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetId() {
    uint ret = corePINVOKE.ChShaft_GetId(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOF() {
    int ret = corePINVOKE.ChShaft_GetDOF(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_ChVariablesShaft Variables() {
    SWIGTYPE_p_ChVariablesShaft ret = new SWIGTYPE_p_ChVariablesShaft(corePINVOKE.ChShaft_Variables(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void IntStateGather(uint off_x, ChState x, uint off_v, ChStateDelta v, SWIGTYPE_p_double T) {
    corePINVOKE.ChShaft_IntStateGather(swigCPtr, off_x, ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(v), SWIGTYPE_p_double.getCPtr(T));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatter(uint off_x, ChState x, uint off_v, ChStateDelta v, double T, bool full_update) {
    corePINVOKE.ChShaft_IntStateScatter(swigCPtr, off_x, ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(v), T, full_update);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateGatherAcceleration(uint off_a, ChStateDelta a) {
    corePINVOKE.ChShaft_IntStateGatherAcceleration(swigCPtr, off_a, ChStateDelta.getCPtr(a));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatterAcceleration(uint off_a, ChStateDelta a) {
    corePINVOKE.ChShaft_IntStateScatterAcceleration(swigCPtr, off_a, ChStateDelta.getCPtr(a));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_F(uint off, ChVectorDynamicD R, double c) {
    corePINVOKE.ChShaft_IntLoadResidual_F(swigCPtr, off, ChVectorDynamicD.getCPtr(R), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_Mv(uint off, ChVectorDynamicD R, ChVectorDynamicD w, double c) {
    corePINVOKE.ChShaft_IntLoadResidual_Mv(swigCPtr, off, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(w), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntToDescriptor(uint off_v, ChStateDelta v, ChVectorDynamicD R, uint off_L, ChVectorDynamicD L, ChVectorDynamicD Qc) {
    corePINVOKE.ChShaft_IntToDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), ChVectorDynamicD.getCPtr(R), off_L, ChVectorDynamicD.getCPtr(L), ChVectorDynamicD.getCPtr(Qc));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntFromDescriptor(uint off_v, ChStateDelta v, uint off_L, ChVectorDynamicD L) {
    corePINVOKE.ChShaft_IntFromDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), off_L, ChVectorDynamicD.getCPtr(L));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbReset() {
    corePINVOKE.ChShaft_VariablesFbReset(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbLoadForces(double factor) {
    corePINVOKE.ChShaft_VariablesFbLoadForces__SWIG_0(swigCPtr, factor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbLoadForces() {
    corePINVOKE.ChShaft_VariablesFbLoadForces__SWIG_1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbLoadSpeed() {
    corePINVOKE.ChShaft_VariablesQbLoadSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesFbIncrementMq() {
    corePINVOKE.ChShaft_VariablesFbIncrementMq(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbSetSpeed(double step) {
    corePINVOKE.ChShaft_VariablesQbSetSpeed__SWIG_0(swigCPtr, step);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbSetSpeed() {
    corePINVOKE.ChShaft_VariablesQbSetSpeed__SWIG_1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void VariablesQbIncrementPosition(double step) {
    corePINVOKE.ChShaft_VariablesQbIncrementPosition(swigCPtr, step);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InjectVariables(SWIGTYPE_p_ChSystemDescriptor mdescriptor) {
    corePINVOKE.ChShaft_InjectVariables(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(mdescriptor));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public int LoadableGet_ndof_x() {
    int ret = corePINVOKE.ChShaft_LoadableGet_ndof_x(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LoadableGet_ndof_w() {
    int ret = corePINVOKE.ChShaft_LoadableGet_ndof_w(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void LoadableGetStateBlock_x(int block_offset, ChState mD) {
    corePINVOKE.ChShaft_LoadableGetStateBlock_x(swigCPtr, block_offset, ChState.getCPtr(mD));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadableGetStateBlock_w(int block_offset, ChStateDelta mD) {
    corePINVOKE.ChShaft_LoadableGetStateBlock_w(swigCPtr, block_offset, ChStateDelta.getCPtr(mD));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void LoadableStateIncrement(uint off_x, ChState x_new, ChState x, uint off_v, ChStateDelta Dv) {
    corePINVOKE.ChShaft_LoadableStateIncrement(swigCPtr, off_x, ChState.getCPtr(x_new), ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(Dv));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public int Get_field_ncoords() {
    int ret = corePINVOKE.ChShaft_Get_field_ncoords(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetSubBlocks() {
    int ret = corePINVOKE.ChShaft_GetSubBlocks(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetSubBlockOffset(int nblock) {
    uint ret = corePINVOKE.ChShaft_GetSubBlockOffset(swigCPtr, nblock);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetSubBlockSize(int nblock) {
    uint ret = corePINVOKE.ChShaft_GetSubBlockSize(swigCPtr, nblock);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsSubBlockActive(int nblock) {
    bool ret = corePINVOKE.ChShaft_IsSubBlockActive(swigCPtr, nblock);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void LoadableGetVariables(SWIGTYPE_p_std__vectorT_ChVariables_p_t mvars) {
    corePINVOKE.ChShaft_LoadableGetVariables(swigCPtr, SWIGTYPE_p_std__vectorT_ChVariables_p_t.getCPtr(mvars));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetNoSpeedNoAcceleration() {
    corePINVOKE.ChShaft_SetNoSpeedNoAcceleration(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAppliedTorque(double mtorque) {
    corePINVOKE.ChShaft_SetAppliedTorque(swigCPtr, mtorque);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetAppliedTorque() {
    double ret = corePINVOKE.ChShaft_GetAppliedTorque(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPos(double mp) {
    corePINVOKE.ChShaft_SetPos(swigCPtr, mp);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetPos() {
    double ret = corePINVOKE.ChShaft_GetPos(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPos_dt(double mp) {
    corePINVOKE.ChShaft_SetPos_dt(swigCPtr, mp);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetPos_dt() {
    double ret = corePINVOKE.ChShaft_GetPos_dt(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPos_dtdt(double mp) {
    corePINVOKE.ChShaft_SetPos_dtdt(swigCPtr, mp);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetPos_dtdt() {
    double ret = corePINVOKE.ChShaft_GetPos_dtdt(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetInertia(double newJ) {
    corePINVOKE.ChShaft_SetInertia(swigCPtr, newJ);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetInertia() {
    double ret = corePINVOKE.ChShaft_GetInertia(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMaxSpeed(float m_max_speed) {
    corePINVOKE.ChShaft_SetMaxSpeed(swigCPtr, m_max_speed);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetMaxSpeed() {
    float ret = corePINVOKE.ChShaft_GetMaxSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ClampSpeed() {
    corePINVOKE.ChShaft_ClampSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSleepTime(float m_t) {
    corePINVOKE.ChShaft_SetSleepTime(swigCPtr, m_t);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetSleepTime() {
    float ret = corePINVOKE.ChShaft_GetSleepTime(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSleepMinSpeed(float m_t) {
    corePINVOKE.ChShaft_SetSleepMinSpeed(swigCPtr, m_t);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetSleepMinSpeed() {
    float ret = corePINVOKE.ChShaft_GetSleepMinSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSleepMinWvel(float m_t) {
    corePINVOKE.ChShaft_SetSleepMinWvel(swigCPtr, m_t);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetSleepMinWvel() {
    float ret = corePINVOKE.ChShaft_GetSleepMinWvel(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Update(double mytime, bool update_assets) {
    corePINVOKE.ChShaft_Update__SWIG_0(swigCPtr, mytime, update_assets);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mytime) {
    corePINVOKE.ChShaft_Update__SWIG_1(swigCPtr, mytime);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChShaft_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChShaft_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
