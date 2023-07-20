//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChVectorF : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChVectorF(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChVectorF obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChVectorF() {
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
          corePINVOKE.delete_ChVectorF(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChVectorF() : this(corePINVOKE.new_ChVectorF__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorF(float x, float y, float z) : this(corePINVOKE.new_ChVectorF__SWIG_1(x, y, z), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorF(float a) : this(corePINVOKE.new_ChVectorF__SWIG_2(a), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorF(ChVectorF other) : this(corePINVOKE.new_ChVectorF__SWIG_3(ChVectorF.getCPtr(other)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_float data() {
    global::System.IntPtr cPtr = corePINVOKE.ChVectorF_data(swigCPtr);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set(float x, float y, float z) {
    corePINVOKE.ChVectorF_Set__SWIG_0(swigCPtr, x, y, z);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set(ChVectorF v) {
    corePINVOKE.ChVectorF_Set__SWIG_1(swigCPtr, ChVectorF.getCPtr(v));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set(float s) {
    corePINVOKE.ChVectorF_Set__SWIG_2(swigCPtr, s);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetNull() {
    corePINVOKE.ChVectorF_SetNull(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsNull() {
    bool ret = corePINVOKE.ChVectorF_IsNull(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equals(ChVectorF other) {
    bool ret = corePINVOKE.ChVectorF_Equals__SWIG_0(swigCPtr, ChVectorF.getCPtr(other));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equals(ChVectorF other, float tol) {
    bool ret = corePINVOKE.ChVectorF_Equals__SWIG_1(swigCPtr, ChVectorF.getCPtr(other), tol);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Length() {
    float ret = corePINVOKE.ChVectorF_Length(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Length2() {
    float ret = corePINVOKE.ChVectorF_Length2(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float LengthInf() {
    float ret = corePINVOKE.ChVectorF_LengthInf(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(ChVectorF A, ChVectorF B) {
    corePINVOKE.ChVectorF_Add(swigCPtr, ChVectorF.getCPtr(A), ChVectorF.getCPtr(B));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Sub(ChVectorF A, ChVectorF B) {
    corePINVOKE.ChVectorF_Sub(swigCPtr, ChVectorF.getCPtr(A), ChVectorF.getCPtr(B));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Mul(ChVectorF A, float s) {
    corePINVOKE.ChVectorF_Mul(swigCPtr, ChVectorF.getCPtr(A), s);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Scale(float s) {
    corePINVOKE.ChVectorF_Scale(swigCPtr, s);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Cross(ChVectorF A, ChVectorF B) {
    corePINVOKE.ChVectorF_Cross__SWIG_0(swigCPtr, ChVectorF.getCPtr(A), ChVectorF.getCPtr(B));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVectorF Cross(ChVectorF other) {
    ChVectorF ret = new ChVectorF(corePINVOKE.ChVectorF_Cross__SWIG_1(swigCPtr, ChVectorF.getCPtr(other)), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Dot(ChVectorF B) {
    float ret = corePINVOKE.ChVectorF_Dot(swigCPtr, ChVectorF.getCPtr(B));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Normalize() {
    bool ret = corePINVOKE.ChVectorF_Normalize(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorF GetNormalized() {
    ChVectorF ret = new ChVectorF(corePINVOKE.ChVectorF_GetNormalized(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLength(float s) {
    corePINVOKE.ChVectorF_SetLength(swigCPtr, s);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void DirToDxDyDz(ChVectorF Vx, ChVectorF Vy, ChVectorF Vz, ChVectorF Vsingular) {
    corePINVOKE.ChVectorF_DirToDxDyDz__SWIG_0(swigCPtr, ChVectorF.getCPtr(Vx), ChVectorF.getCPtr(Vy), ChVectorF.getCPtr(Vz), ChVectorF.getCPtr(Vsingular));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void DirToDxDyDz(ChVectorF Vx, ChVectorF Vy, ChVectorF Vz) {
    corePINVOKE.ChVectorF_DirToDxDyDz__SWIG_1(swigCPtr, ChVectorF.getCPtr(Vx), ChVectorF.getCPtr(Vy), ChVectorF.getCPtr(Vz));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetMaxComponent() {
    int ret = corePINVOKE.ChVectorF_GetMaxComponent(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVectorF GetOrthogonalVector() {
    ChVectorF ret = new ChVectorF(corePINVOKE.ChVectorF_GetOrthogonalVector(swigCPtr), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChVectorF_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChVectorF_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float x {
    set {
      corePINVOKE.ChVectorF_x_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChVectorF_x_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float y {
    set {
      corePINVOKE.ChVectorF_y_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChVectorF_y_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float z {
    set {
      corePINVOKE.ChVectorF_z_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChVectorF_z_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
