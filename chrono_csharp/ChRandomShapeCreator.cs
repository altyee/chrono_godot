//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChRandomShapeCreator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChRandomShapeCreator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChRandomShapeCreator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChRandomShapeCreator() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          corePINVOKE.delete_ChRandomShapeCreator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual ChBody RandomGenerate(ChCoordsysD mcoords) {
    global::System.IntPtr cPtr = corePINVOKE.ChRandomShapeCreator_RandomGenerate(swigCPtr, ChCoordsysD.getCPtr(mcoords));
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChBody RandomGenerateAndCallbacks(ChCoordsysD mcoords) {
    global::System.IntPtr cPtr = corePINVOKE.ChRandomShapeCreator_RandomGenerateAndCallbacks(swigCPtr, ChCoordsysD.getCPtr(mcoords));
    ChBody ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChBody(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RegisterAddBodyCallback(ChRandomShapeCreator_AddBodyCallback callback) {
    corePINVOKE.ChRandomShapeCreator_RegisterAddBodyCallback(swigCPtr, ChRandomShapeCreator_AddBodyCallback.getCPtr(callback));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAddCollisionShape(bool addcoll) {
    corePINVOKE.ChRandomShapeCreator_SetAddCollisionShape(swigCPtr, addcoll);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAddVisualizationAsset(bool addvisual) {
    corePINVOKE.ChRandomShapeCreator_SetAddVisualizationAsset(swigCPtr, addvisual);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}