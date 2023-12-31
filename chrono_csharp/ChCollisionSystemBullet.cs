//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChCollisionSystemBullet : ChCollisionSystem {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChCollisionSystemBullet(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChCollisionSystemBullet_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChCollisionSystemBullet obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChCollisionSystemBullet(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChCollisionSystemBullet() : this(corePINVOKE.new_ChCollisionSystemBullet(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChCollisionSystemType GetType() {
    ChCollisionSystemType ret = (ChCollisionSystemType)corePINVOKE.ChCollisionSystemBullet_GetType(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Clear() {
    corePINVOKE.ChCollisionSystemBullet_Clear(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Add(ChCollisionModel model) {
    corePINVOKE.ChCollisionSystemBullet_Add(swigCPtr, ChCollisionModel.getCPtr(model));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Remove(ChCollisionModel model) {
    corePINVOKE.ChCollisionSystemBullet_Remove(swigCPtr, ChCollisionModel.getCPtr(model));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetNumThreads(int nthreads) {
    corePINVOKE.ChCollisionSystemBullet_SetNumThreads(swigCPtr, nthreads);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Run() {
    corePINVOKE.ChCollisionSystemBullet_Run(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void GetBoundingBox(ChVectorD aabb_min, ChVectorD aabb_max) {
    corePINVOKE.ChCollisionSystemBullet_GetBoundingBox(swigCPtr, ChVectorD.getCPtr(aabb_min), ChVectorD.getCPtr(aabb_max));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ResetTimers() {
    corePINVOKE.ChCollisionSystemBullet_ResetTimers(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double GetTimerCollisionBroad() {
    double ret = corePINVOKE.ChCollisionSystemBullet_GetTimerCollisionBroad(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double GetTimerCollisionNarrow() {
    double ret = corePINVOKE.ChCollisionSystemBullet_GetTimerCollisionNarrow(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ReportContacts(ChContactContainer mcontactcontainer) {
    corePINVOKE.ChCollisionSystemBullet_ReportContacts(swigCPtr, ChContactContainer.getCPtr(mcontactcontainer));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReportProximities(ChProximityContainer mproximitycontainer) {
    corePINVOKE.ChCollisionSystemBullet_ReportProximities(swigCPtr, ChProximityContainer.getCPtr(mproximitycontainer));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool RayHit(ChVectorD from, ChVectorD to, ChRayhitResult result) {
    bool ret = corePINVOKE.ChCollisionSystemBullet_RayHit__SWIG_0(swigCPtr, ChVectorD.getCPtr(from), ChVectorD.getCPtr(to), ChRayhitResult.getCPtr(result));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool RayHit(ChVectorD from, ChVectorD to, ChCollisionModel model, ChRayhitResult result) {
    bool ret = corePINVOKE.ChCollisionSystemBullet_RayHit__SWIG_1(swigCPtr, ChVectorD.getCPtr(from), ChVectorD.getCPtr(to), ChCollisionModel.getCPtr(model), ChRayhitResult.getCPtr(result));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void RegisterVisualizationCallback(VisualizationCallback callback) {
    corePINVOKE.ChCollisionSystemBullet_RegisterVisualizationCallback(swigCPtr, VisualizationCallback.getCPtr(callback));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Visualize(int flags) {
    corePINVOKE.ChCollisionSystemBullet_Visualize(swigCPtr, flags);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_cbtCollisionWorld GetBulletCollisionWorld() {
    global::System.IntPtr cPtr = corePINVOKE.ChCollisionSystemBullet_GetBulletCollisionWorld(swigCPtr);
    SWIGTYPE_p_cbtCollisionWorld ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_cbtCollisionWorld(cPtr, false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static void SetContactBreakingThreshold(double threshold) {
    corePINVOKE.ChCollisionSystemBullet_SetContactBreakingThreshold(threshold);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
