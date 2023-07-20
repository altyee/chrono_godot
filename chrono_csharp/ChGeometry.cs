//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChGeometry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChGeometry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChGeometry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChGeometry() {
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
          corePINVOKE.delete_ChGeometry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual ChGeometry Clone() {
    global::System.IntPtr cPtr = corePINVOKE.ChGeometry_Clone(swigCPtr);
    ChGeometry ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChGeometry(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChGeometry.Type GetClassType() {
    ChGeometry.Type ret = (ChGeometry.Type)corePINVOKE.ChGeometry_GetClassType(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual AABB GetBoundingBox(ChMatrix33D rot) {
    AABB ret = new AABB(corePINVOKE.ChGeometry_GetBoundingBox(swigCPtr, ChMatrix33D.getCPtr(rot)), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void InflateBoundingBox(AABB bbox, ChMatrix33D rot) {
    corePINVOKE.ChGeometry_InflateBoundingBox(swigCPtr, AABB.getCPtr(bbox), ChMatrix33D.getCPtr(rot));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double GetBoundingSphereRadius() {
    double ret = corePINVOKE.ChGeometry_GetBoundingSphereRadius(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD Baricenter() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChGeometry_Baricenter(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetManifoldDimension() {
    int ret = corePINVOKE.ChGeometry_GetManifoldDimension(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Update() {
    corePINVOKE.ChGeometry_Update(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChGeometry_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChGeometry_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public enum Type {
    NONE,
    SPHERE,
    ELLIPSOID,
    BOX,
    CYLINDER,
    TRIANGLE,
    CAPSULE,
    CONE,
    LINE,
    LINE_ARC,
    LINE_BEZIER,
    LINE_CAM,
    LINE_PATH,
    LINE_POLY,
    LINE_SEGMENT,
    ROUNDED_BOX,
    ROUNDED_CYLINDER,
    TRIANGLEMESH,
    TRIANGLEMESH_CONNECTED,
    TRIANGLEMESH_SOUP
  }

}
