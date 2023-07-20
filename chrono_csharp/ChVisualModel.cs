//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChVisualModel : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChVisualModel(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChVisualModel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChVisualModel() {
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
          corePINVOKE.delete_ChVisualModel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChVisualModel() : this(corePINVOKE.new_ChVisualModel(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddShape(ChVisualShape shape, ChFrameD frame) {
    corePINVOKE.ChVisualModel_AddShape__SWIG_0(swigCPtr, ChVisualShape.getCPtr(shape), ChFrameD.getCPtr(frame));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddShape(ChVisualShape shape) {
    corePINVOKE.ChVisualModel_AddShape__SWIG_1(swigCPtr, ChVisualShape.getCPtr(shape));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddShapeFEA(ChVisualShapeFEA shapeFEA) {
    corePINVOKE.ChVisualModel_AddShapeFEA(swigCPtr, ChVisualShapeFEA.getCPtr(shapeFEA));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetNumShapes() {
    int ret = corePINVOKE.ChVisualModel_GetNumShapes(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_std__pairT_std__shared_ptrT_chrono__ChVisualShape_t_chrono__ChFrameT_double_t_t_t GetShapes() {
    SWIGTYPE_p_std__vectorT_std__pairT_std__shared_ptrT_chrono__ChVisualShape_t_chrono__ChFrameT_double_t_t_t ret = new SWIGTYPE_p_std__vectorT_std__pairT_std__shared_ptrT_chrono__ChVisualShape_t_chrono__ChFrameT_double_t_t_t(corePINVOKE.ChVisualModel_GetShapes(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVisualShape GetShape(uint i) {
    global::System.IntPtr cPtr = corePINVOKE.ChVisualModel_GetShape(swigCPtr, i);
    ChVisualShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChVisualShape(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNumShapesFEA() {
    int ret = corePINVOKE.ChVisualModel_GetNumShapesFEA(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_std__shared_ptrT_chrono__ChVisualShapeFEA_t_t GetShapesFEA() {
    SWIGTYPE_p_std__vectorT_std__shared_ptrT_chrono__ChVisualShapeFEA_t_t ret = new SWIGTYPE_p_std__vectorT_std__shared_ptrT_chrono__ChVisualShapeFEA_t_t(corePINVOKE.ChVisualModel_GetShapesFEA(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVisualShapeFEA GetShapeFEA(uint i) {
    global::System.IntPtr cPtr = corePINVOKE.ChVisualModel_GetShapeFEA(swigCPtr, i);
    ChVisualShapeFEA ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChVisualShapeFEA(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChFrameD GetShapeFrame(uint i) {
    ChFrameD ret = new ChFrameD(corePINVOKE.ChVisualModel_GetShapeFrame(swigCPtr, i), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Clear() {
    corePINVOKE.ChVisualModel_Clear(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Erase(ChVisualShape shape) {
    corePINVOKE.ChVisualModel_Erase(swigCPtr, ChVisualShape.getCPtr(shape));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChVisualModel_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChVisualModel_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
