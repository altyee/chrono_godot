//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChRandomShapeCreatorConvexHulls : ChRandomShapeCreator {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChRandomShapeCreatorConvexHulls(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChRandomShapeCreatorConvexHulls_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChRandomShapeCreatorConvexHulls obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChRandomShapeCreatorConvexHulls(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChRandomShapeCreatorConvexHulls() : this(corePINVOKE.new_ChRandomShapeCreatorConvexHulls(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChBody RandomGenerate(ChCoordsysD mcoords) {
    global::System.IntPtr cPtr = corePINVOKE.ChRandomShapeCreatorConvexHulls_RandomGenerate(swigCPtr, ChCoordsysD.getCPtr(mcoords));
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetNpoints(int mnpoints) {
    corePINVOKE.ChRandomShapeCreatorConvexHulls_SetNpoints(swigCPtr, mnpoints);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetChordDistribution(ChDistribution mdistr) {
    corePINVOKE.ChRandomShapeCreatorConvexHulls_SetChordDistribution(swigCPtr, ChDistribution.getCPtr(mdistr));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSizeRatioYZDistribution(ChDistribution mdistr) {
    corePINVOKE.ChRandomShapeCreatorConvexHulls_SetSizeRatioYZDistribution(swigCPtr, ChDistribution.getCPtr(mdistr));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSizeRatioZDistribution(ChDistribution mdistr) {
    corePINVOKE.ChRandomShapeCreatorConvexHulls_SetSizeRatioZDistribution(swigCPtr, ChDistribution.getCPtr(mdistr));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDensityDistribution(ChDistribution mdistr) {
    corePINVOKE.ChRandomShapeCreatorConvexHulls_SetDensityDistribution(swigCPtr, ChDistribution.getCPtr(mdistr));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
