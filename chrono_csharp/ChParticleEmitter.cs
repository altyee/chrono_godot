//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChParticleEmitter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChParticleEmitter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChParticleEmitter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChParticleEmitter() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          corePINVOKE.delete_ChParticleEmitter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChParticleEmitter() : this(corePINVOKE.new_ChParticleEmitter(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void EmitParticles(ChSystem msystem, double mdt, ChFrameMovingD pre_transform) {
    corePINVOKE.ChParticleEmitter_EmitParticles__SWIG_0(swigCPtr, ChSystem.getCPtr(msystem), mdt, ChFrameMovingD.getCPtr(pre_transform));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void EmitParticles(ChSystem msystem, double mdt) {
    corePINVOKE.ChParticleEmitter_EmitParticles__SWIG_1(swigCPtr, ChSystem.getCPtr(msystem), mdt);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RegisterAddBodyCallback(ChRandomShapeCreator_AddBodyCallback callback) {
    corePINVOKE.ChParticleEmitter_RegisterAddBodyCallback(swigCPtr, ChRandomShapeCreator_AddBodyCallback.getCPtr(callback));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetParticleCreator(ChRandomShapeCreator mc) {
    corePINVOKE.ChParticleEmitter_SetParticleCreator(swigCPtr, ChRandomShapeCreator.getCPtr(mc));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetParticlePositioner(ChRandomParticlePosition mc) {
    corePINVOKE.ChParticleEmitter_SetParticlePositioner(swigCPtr, ChRandomParticlePosition.getCPtr(mc));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetParticleAligner(ChRandomParticleAlignment mc) {
    corePINVOKE.ChParticleEmitter_SetParticleAligner(swigCPtr, ChRandomParticleAlignment.getCPtr(mc));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetParticleVelocity(ChRandomParticleVelocity mc) {
    corePINVOKE.ChParticleEmitter_SetParticleVelocity(swigCPtr, ChRandomParticleVelocity.getCPtr(mc));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetParticleAngularVelocity(ChRandomParticleVelocity mc) {
    corePINVOKE.ChParticleEmitter_SetParticleAngularVelocity(swigCPtr, ChRandomParticleVelocity.getCPtr(mc));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFlowControlMode(ChParticleEmitter.eChFlowMode mymode) {
    corePINVOKE.ChParticleEmitter_SetFlowControlMode(swigCPtr, (int)mymode);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChParticleEmitter.eChFlowMode GetFlowControlMode() {
    ChParticleEmitter.eChFlowMode ret = (ChParticleEmitter.eChFlowMode)corePINVOKE.ChParticleEmitter_GetFlowControlMode(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double ParticlesPerSecond() {
    SWIGTYPE_p_double ret = new SWIGTYPE_p_double(corePINVOKE.ChParticleEmitter_ParticlesPerSecond(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double MassPerSecond() {
    SWIGTYPE_p_double ret = new SWIGTYPE_p_double(corePINVOKE.ChParticleEmitter_MassPerSecond(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetUseParticleReservoir(bool ml) {
    corePINVOKE.ChParticleEmitter_SetUseParticleReservoir(swigCPtr, ml);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetUseMassReservoir(bool ml) {
    corePINVOKE.ChParticleEmitter_SetUseMassReservoir(swigCPtr, ml);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_int ParticleReservoirAmount() {
    SWIGTYPE_p_int ret = new SWIGTYPE_p_int(corePINVOKE.ChParticleEmitter_ParticleReservoirAmount(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double MassReservoirAmount() {
    SWIGTYPE_p_double ret = new SWIGTYPE_p_double(corePINVOKE.ChParticleEmitter_MassReservoirAmount(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetTotCreatedParticles() {
    int ret = corePINVOKE.ChParticleEmitter_GetTotCreatedParticles(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetTotCreatedMass() {
    double ret = corePINVOKE.ChParticleEmitter_GetTotCreatedMass(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetInheritSpeed(bool mi) {
    corePINVOKE.ChParticleEmitter_SetInheritSpeed(swigCPtr, mi);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetJitterDeclustering(bool mj) {
    corePINVOKE.ChParticleEmitter_SetJitterDeclustering(swigCPtr, mj);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetParticlesPerSecond(double pps) {
    corePINVOKE.ChParticleEmitter_SetParticlesPerSecond(swigCPtr, pps);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMassPerSecond(double mps) {
    corePINVOKE.ChParticleEmitter_SetMassPerSecond(swigCPtr, mps);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetParticleReservoirAmount(int pra) {
    corePINVOKE.ChParticleEmitter_SetParticleReservoirAmount(swigCPtr, pra);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMassReservoirAmount(int mra) {
    corePINVOKE.ChParticleEmitter_SetMassReservoirAmount(swigCPtr, mra);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetParticlesPerSecond() {
    double ret = corePINVOKE.ChParticleEmitter_GetParticlesPerSecond(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetMassPerSecond() {
    double ret = corePINVOKE.ChParticleEmitter_GetMassPerSecond(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetParticleReservoirAmount() {
    int ret = corePINVOKE.ChParticleEmitter_GetParticleReservoirAmount(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetMassReservoirAmount() {
    int ret = corePINVOKE.ChParticleEmitter_GetMassReservoirAmount(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum eChFlowMode {
    FLOW_PARTICLESPERSECOND,
    FLOW_MASSPERSECOND
  }

}
