//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChSolver : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChSolver(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChSolver obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChSolver() {
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
          corePINVOKE.delete_ChSolver(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual ChSolver.Type GetType() {
    ChSolver.Type ret = (ChSolver.Type)corePINVOKE.ChSolver_GetType(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool SolveRequiresMatrix() {
    bool ret = corePINVOKE.ChSolver_SolveRequiresMatrix(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Solve(SWIGTYPE_p_ChSystemDescriptor sysd) {
    double ret = corePINVOKE.ChSolver_Solve(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(sysd));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Setup(SWIGTYPE_p_ChSystemDescriptor sysd) {
    bool ret = corePINVOKE.ChSolver_Setup(swigCPtr, SWIGTYPE_p_ChSystemDescriptor.getCPtr(sysd));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetVerbose(bool mv) {
    corePINVOKE.ChSolver_SetVerbose(swigCPtr, mv);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void EnableWrite(bool val, string frame, string out_dir) {
    corePINVOKE.ChSolver_EnableWrite__SWIG_0(swigCPtr, val, frame, out_dir);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void EnableWrite(bool val, string frame) {
    corePINVOKE.ChSolver_EnableWrite__SWIG_1(swigCPtr, val, frame);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChSolver_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChSolver_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public enum Type {
    PSOR = 0,
    PSSOR,
    PJACOBI,
    PMINRES,
    BARZILAIBORWEIN,
    APGD,
    ADDM,
    SPARSE_LU,
    SPARSE_QR,
    PARDISO_MKL,
    PARDISO_PROJECT,
    MUMPS,
    GMRES,
    MINRES,
    BICGSTAB,
    CUSTOM
  }

}
