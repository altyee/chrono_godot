//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChFunction_Operation : ChFunction {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChFunction_Operation(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChFunction_Operation_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChFunction_Operation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChFunction_Operation(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChFunction_Operation() : this(corePINVOKE.new_ChFunction_Operation__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction_Operation(ChFunction_Operation other) : this(corePINVOKE.new_ChFunction_Operation__SWIG_1(ChFunction_Operation.getCPtr(other)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override ChFunction.FunctionType Get_Type() {
    ChFunction.FunctionType ret = (ChFunction.FunctionType)corePINVOKE.ChFunction_Operation_Get_Type(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override double Get_y(double x) {
    double ret = corePINVOKE.ChFunction_Operation_Get_y(swigCPtr, x);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_optype(ChFunction_Operation.eChOperation m_op) {
    corePINVOKE.ChFunction_Operation_Set_optype(swigCPtr, (int)m_op);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction_Operation.eChOperation Get_optype() {
    ChFunction_Operation.eChOperation ret = (ChFunction_Operation.eChOperation)corePINVOKE.ChFunction_Operation_Get_optype(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_fa(ChFunction m_fa) {
    corePINVOKE.ChFunction_Operation_Set_fa(swigCPtr, ChFunction.getCPtr(m_fa));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction Get_fa() {
    global::System.IntPtr cPtr = corePINVOKE.ChFunction_Operation_Get_fa(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set_fb(ChFunction m_fb) {
    corePINVOKE.ChFunction_Operation_Set_fb(swigCPtr, ChFunction.getCPtr(m_fb));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChFunction Get_fb() {
    global::System.IntPtr cPtr = corePINVOKE.ChFunction_Operation_Get_fb(swigCPtr);
    ChFunction ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChFunction(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Estimate_x_range(SWIGTYPE_p_double xmin, SWIGTYPE_p_double xmax) {
    corePINVOKE.ChFunction_Operation_Estimate_x_range(swigCPtr, SWIGTYPE_p_double.getCPtr(xmin), SWIGTYPE_p_double.getCPtr(xmax));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChFunction_Operation_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChFunction_Operation_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public enum eChOperation {
    ChOP_ADD = 0,
    ChOP_SUB,
    ChOP_MUL,
    ChOP_DIV,
    ChOP_POW,
    ChOP_MAX,
    ChOP_MIN,
    ChOP_MODULO,
    ChOP_FABS,
    ChOP_FUNCT
  }

}
