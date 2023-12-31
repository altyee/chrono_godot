//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinkDistance : ChLink {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinkDistance(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChLinkDistance_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinkDistance obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChLinkDistance(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinkDistance() : this(corePINVOKE.new_ChLinkDistance__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinkDistance(ChLinkDistance other) : this(corePINVOKE.new_ChLinkDistance__SWIG_1(ChLinkDistance.getCPtr(other)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public int Initialize(ChBodyFrame mbody1, ChBodyFrame mbody2, bool pos_are_relative, ChVectorD mpos1, ChVectorD mpos2, bool auto_distance, double mdistance) {
    int ret = corePINVOKE.ChLinkDistance_Initialize__SWIG_0(swigCPtr, ChBodyFrame.getCPtr(mbody1), ChBodyFrame.getCPtr(mbody2), pos_are_relative, ChVectorD.getCPtr(mpos1), ChVectorD.getCPtr(mpos2), auto_distance, mdistance);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Initialize(ChBodyFrame mbody1, ChBodyFrame mbody2, bool pos_are_relative, ChVectorD mpos1, ChVectorD mpos2, bool auto_distance) {
    int ret = corePINVOKE.ChLinkDistance_Initialize__SWIG_1(swigCPtr, ChBodyFrame.getCPtr(mbody1), ChBodyFrame.getCPtr(mbody2), pos_are_relative, ChVectorD.getCPtr(mpos1), ChVectorD.getCPtr(mpos2), auto_distance);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Initialize(ChBodyFrame mbody1, ChBodyFrame mbody2, bool pos_are_relative, ChVectorD mpos1, ChVectorD mpos2) {
    int ret = corePINVOKE.ChLinkDistance_Initialize__SWIG_2(swigCPtr, ChBodyFrame.getCPtr(mbody1), ChBodyFrame.getCPtr(mbody2), pos_are_relative, ChVectorD.getCPtr(mpos1), ChVectorD.getCPtr(mpos2));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int GetDOC_c() {
    int ret = corePINVOKE.ChLinkDistance_GetDOC_c(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChCoordsysD GetLinkRelativeCoords() {
    ChCoordsysD ret = new ChCoordsysD(corePINVOKE.ChLinkDistance_GetLinkRelativeCoords(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD GetEndPoint1Rel() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChLinkDistance_GetEndPoint1Rel(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetEndPoint1Rel(ChVectorD mset) {
    corePINVOKE.ChLinkDistance_SetEndPoint1Rel(swigCPtr, ChVectorD.getCPtr(mset));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetEndPoint1Abs() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChLinkDistance_GetEndPoint1Abs(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetEndPoint1Abs(ChVectorD mset) {
    corePINVOKE.ChLinkDistance_SetEndPoint1Abs(swigCPtr, ChVectorD.getCPtr(mset));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetEndPoint2Rel() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChLinkDistance_GetEndPoint2Rel(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetEndPoint2Rel(ChVectorD mset) {
    corePINVOKE.ChLinkDistance_SetEndPoint2Rel(swigCPtr, ChVectorD.getCPtr(mset));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetEndPoint2Abs() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChLinkDistance_GetEndPoint2Abs(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetEndPoint2Abs(ChVectorD mset) {
    corePINVOKE.ChLinkDistance_SetEndPoint2Abs(swigCPtr, ChVectorD.getCPtr(mset));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetImposedDistance(double mset) {
    corePINVOKE.ChLinkDistance_SetImposedDistance(swigCPtr, mset);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetImposedDistance() {
    double ret = corePINVOKE.ChLinkDistance_GetImposedDistance(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetCurrentDistance() {
    double ret = corePINVOKE.ChLinkDistance_GetCurrentDistance(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChVectorDynamicD GetConstraintViolation() {
    ChVectorDynamicD ret = new ChVectorDynamicD(corePINVOKE.ChLinkDistance_GetConstraintViolation(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Update(double mtime, bool update_assets) {
    corePINVOKE.ChLinkDistance_Update__SWIG_0(swigCPtr, mtime, update_assets);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Update(double mtime) {
    corePINVOKE.ChLinkDistance_Update__SWIG_1(swigCPtr, mtime);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateGatherReactions(uint off_L, ChVectorDynamicD L) {
    corePINVOKE.ChLinkDistance_IntStateGatherReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntStateScatterReactions(uint off_L, ChVectorDynamicD L) {
    corePINVOKE.ChLinkDistance_IntStateScatterReactions(swigCPtr, off_L, ChVectorDynamicD.getCPtr(L));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadResidual_CqL(uint off_L, ChVectorDynamicD R, ChVectorDynamicD L, double c) {
    corePINVOKE.ChLinkDistance_IntLoadResidual_CqL(swigCPtr, off_L, ChVectorDynamicD.getCPtr(R), ChVectorDynamicD.getCPtr(L), c);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntLoadConstraint_C(uint off, ChVectorDynamicD Qc, double c, bool do_clamp, double recovery_clamp) {
    corePINVOKE.ChLinkDistance_IntLoadConstraint_C(swigCPtr, off, ChVectorDynamicD.getCPtr(Qc), c, do_clamp, recovery_clamp);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntToDescriptor(uint off_v, ChStateDelta v, ChVectorDynamicD R, uint off_L, ChVectorDynamicD L, ChVectorDynamicD Qc) {
    corePINVOKE.ChLinkDistance_IntToDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), ChVectorDynamicD.getCPtr(R), off_L, ChVectorDynamicD.getCPtr(L), ChVectorDynamicD.getCPtr(Qc));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void IntFromDescriptor(uint off_v, ChStateDelta v, uint off_L, ChVectorDynamicD L) {
    corePINVOKE.ChLinkDistance_IntFromDescriptor(swigCPtr, off_v, ChStateDelta.getCPtr(v), off_L, ChVectorDynamicD.getCPtr(L));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void InjectConstraints(SWIGTYPE_p_ChSystemDescriptor mdescriptor) {
    corePINVOKE.ChLinkDistance_InjectConstraints(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(mdescriptor));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiReset() {
    corePINVOKE.ChLinkDistance_ConstraintsBiReset(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp, bool do_clamp) {
    corePINVOKE.ChLinkDistance_ConstraintsBiLoad_C__SWIG_0(swigCPtr, factor, recovery_clamp, do_clamp);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor, double recovery_clamp) {
    corePINVOKE.ChLinkDistance_ConstraintsBiLoad_C__SWIG_1(swigCPtr, factor, recovery_clamp);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C(double factor) {
    corePINVOKE.ChLinkDistance_ConstraintsBiLoad_C__SWIG_2(swigCPtr, factor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsBiLoad_C() {
    corePINVOKE.ChLinkDistance_ConstraintsBiLoad_C__SWIG_3(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsLoadJacobians() {
    corePINVOKE.ChLinkDistance_ConstraintsLoadJacobians(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react(double factor) {
    corePINVOKE.ChLinkDistance_ConstraintsFetch_react__SWIG_0(swigCPtr, factor);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ConstraintsFetch_react() {
    corePINVOKE.ChLinkDistance_ConstraintsFetch_react__SWIG_1(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChLinkDistance_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChLinkDistance_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Initialize(ChBody body1, ChBody body2, bool pos_are_relative, ChVectorD pos1, ChVectorD pos2) {
    corePINVOKE.ChLinkDistance_Initialize__SWIG_3(swigCPtr, ChBody.getCPtr(body1), ChBody.getCPtr(body2), pos_are_relative, ChVectorD.getCPtr(pos1), ChVectorD.getCPtr(pos2));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
