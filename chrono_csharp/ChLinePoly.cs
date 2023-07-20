//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLinePoly : ChLine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChLinePoly(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChLinePoly_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLinePoly obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChLinePoly(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChLinePoly(int mnumpoints) : this(corePINVOKE.new_ChLinePoly__SWIG_0(mnumpoints), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinePoly() : this(corePINVOKE.new_ChLinePoly__SWIG_1(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLinePoly(ChLinePoly source) : this(corePINVOKE.new_ChLinePoly__SWIG_2(ChLinePoly.getCPtr(source)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChGeometry Clone() {
    global::System.IntPtr cPtr = corePINVOKE.ChLinePoly_Clone(swigCPtr);
    ChLinePoly ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChLinePoly(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ChGeometry.Type GetClassType() {
    ChGeometry.Type ret = (ChGeometry.Type)corePINVOKE.ChLinePoly_GetClassType(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int Get_complexity() {
    int ret = corePINVOKE.ChLinePoly_Get_complexity(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Set_complexity(int mc) {
    corePINVOKE.ChLinePoly_Set_complexity(swigCPtr, mc);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Evaluate(ChVectorD pos, double parU) {
    corePINVOKE.ChLinePoly_Evaluate(swigCPtr, ChVectorD.getCPtr(pos), parU);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override double Length(int sampling) {
    double ret = corePINVOKE.ChLinePoly_Length(swigCPtr, sampling);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool DrawPostscript(SWIGTYPE_p_ChFile_ps mfle, int markpoints, int bezier_interpolate) {
    bool ret = corePINVOKE.ChLinePoly_DrawPostscript(swigCPtr, SWIGTYPE_p_ChFile_ps.getCPtr(mfle), markpoints, bezier_interpolate);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint Get_numpoints() {
    uint ret = corePINVOKE.ChLinePoly_Get_numpoints(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Get_degree() {
    int ret = corePINVOKE.ChLinePoly_Get_degree(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorD Get_point(uint mnum) {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChLinePoly_Get_point(swigCPtr, mnum), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Set_point(int mnum, ChVectorD mpoint) {
    bool ret = corePINVOKE.ChLinePoly_Set_point(swigCPtr, mnum, ChVectorD.getCPtr(mpoint));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChLinePoly_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChLinePoly_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
