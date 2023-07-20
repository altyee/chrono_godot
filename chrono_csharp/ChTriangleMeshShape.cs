//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChTriangleMeshShape : ChVisualShape {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChTriangleMeshShape(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChTriangleMeshShape_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChTriangleMeshShape obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChTriangleMeshShape(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChTriangleMeshShape() : this(corePINVOKE.new_ChTriangleMeshShape(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChTriangleMeshConnected GetMesh() {
    global::System.IntPtr cPtr = corePINVOKE.ChTriangleMeshShape_GetMesh(swigCPtr);
    ChTriangleMeshConnected ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChTriangleMeshConnected(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMesh(ChTriangleMeshConnected mesh, bool load_materials) {
    corePINVOKE.ChTriangleMeshShape_SetMesh__SWIG_0(swigCPtr, ChTriangleMeshConnected.getCPtr(mesh), load_materials);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMesh(ChTriangleMeshConnected mesh) {
    corePINVOKE.ChTriangleMeshShape_SetMesh__SWIG_1(swigCPtr, ChTriangleMeshConnected.getCPtr(mesh));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsWireframe() {
    bool ret = corePINVOKE.ChTriangleMeshShape_IsWireframe(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetWireframe(bool mw) {
    corePINVOKE.ChTriangleMeshShape_SetWireframe(swigCPtr, mw);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsBackfaceCull() {
    bool ret = corePINVOKE.ChTriangleMeshShape_IsBackfaceCull(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetBackfaceCull(bool mbc) {
    corePINVOKE.ChTriangleMeshShape_SetBackfaceCull(swigCPtr, mbc);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetName() {
    string ret = corePINVOKE.ChTriangleMeshShape_GetName(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetName(string mname) {
    corePINVOKE.ChTriangleMeshShape_SetName(swigCPtr, mname);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorD GetScale() {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChTriangleMeshShape_GetScale(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetScale(ChVectorD mscale) {
    corePINVOKE.ChTriangleMeshShape_SetScale(swigCPtr, ChVectorD.getCPtr(mscale));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFixedConnectivity() {
    corePINVOKE.ChTriangleMeshShape_SetFixedConnectivity(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool FixedConnectivity() {
    bool ret = corePINVOKE.ChTriangleMeshShape_FixedConnectivity(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetModifiedVertices(SWIGTYPE_p_std__vectorT_int_t vertices) {
    corePINVOKE.ChTriangleMeshShape_SetModifiedVertices(swigCPtr, SWIGTYPE_p_std__vectorT_int_t.getCPtr(vertices));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__vectorT_int_t GetModifiedVertices() {
    SWIGTYPE_p_std__vectorT_int_t ret = new SWIGTYPE_p_std__vectorT_int_t(corePINVOKE.ChTriangleMeshShape_GetModifiedVertices(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChTriangleMeshShape_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChTriangleMeshShape_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
