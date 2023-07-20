//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChShaftsElasticGear : ChLoadCustomMultiple {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChShaftsElasticGear(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChShaftsElasticGear_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChShaftsElasticGear obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChShaftsElasticGear(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChShaftsElasticGear(ChShaft mbodyA, ChShaft mbodyB, double mstiffness, double mdamping, double mRa, double mratio) : this(corePINVOKE.new_ChShaftsElasticGear__SWIG_0(ChShaft.getCPtr(mbodyA), ChShaft.getCPtr(mbodyB), mstiffness, mdamping, mRa, mratio), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChShaftsElasticGear(ChShaft mbodyA, ChShaft mbodyB, double mstiffness, double mdamping, double mRa) : this(corePINVOKE.new_ChShaftsElasticGear__SWIG_1(ChShaft.getCPtr(mbodyA), ChShaft.getCPtr(mbodyB), mstiffness, mdamping, mRa), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTeethStiffness(double mstiffness) {
    corePINVOKE.ChShaftsElasticGear_SetTeethStiffness(swigCPtr, mstiffness);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetTeethStiffness() {
    double ret = corePINVOKE.ChShaftsElasticGear_GetTeethStiffness(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetTeethDamping(double mdamping) {
    corePINVOKE.ChShaftsElasticGear_SetTeethDamping(swigCPtr, mdamping);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetTeethDamping() {
    double ret = corePINVOKE.ChShaftsElasticGear_GetTeethDamping(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRestPhase(double mphase) {
    corePINVOKE.ChShaftsElasticGear_SetRestPhase(swigCPtr, mphase);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetRestPhase() {
    double ret = corePINVOKE.ChShaftsElasticGear_GetRestPhase(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetTransmissionRatioAndRadiusA(double mt, double mRa) {
    corePINVOKE.ChShaftsElasticGear_SetTransmissionRatioAndRadiusA(swigCPtr, mt, mRa);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTransmissionRatioFromRadii(double mRa, double mRb, bool minternal) {
    corePINVOKE.ChShaftsElasticGear_SetTransmissionRatioFromRadii__SWIG_0(swigCPtr, mRa, mRb, minternal);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetTransmissionRatioFromRadii(double mRa, double mRb) {
    corePINVOKE.ChShaftsElasticGear_SetTransmissionRatioFromRadii__SWIG_1(swigCPtr, mRa, mRb);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetTransmissionRatio() {
    double ret = corePINVOKE.ChShaftsElasticGear_GetTransmissionRatio(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetGearRadiusA() {
    double ret = corePINVOKE.ChShaftsElasticGear_GetGearRadiusA(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetGearRadiusB() {
    double ret = corePINVOKE.ChShaftsElasticGear_GetGearRadiusB(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetContactForce() {
    double ret = corePINVOKE.ChShaftsElasticGear_GetContactForce(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
