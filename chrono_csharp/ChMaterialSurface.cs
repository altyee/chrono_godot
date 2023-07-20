//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChMaterialSurface : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChMaterialSurface(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChMaterialSurface obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChMaterialSurface() {
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
          corePINVOKE.delete_ChMaterialSurface(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual ChMaterialSurface Clone() {
    global::System.IntPtr cPtr = corePINVOKE.ChMaterialSurface_Clone(swigCPtr);
    ChMaterialSurface ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMaterialSurface(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChContactMethod GetContactMethod() {
    ChContactMethod ret = (ChContactMethod)corePINVOKE.ChMaterialSurface_GetContactMethod(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSfriction(float val) {
    corePINVOKE.ChMaterialSurface_SetSfriction(swigCPtr, val);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetSfriction() {
    float ret = corePINVOKE.ChMaterialSurface_GetSfriction(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetKfriction(float val) {
    corePINVOKE.ChMaterialSurface_SetKfriction(swigCPtr, val);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetKfriction() {
    float ret = corePINVOKE.ChMaterialSurface_GetKfriction(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFriction(float val) {
    corePINVOKE.ChMaterialSurface_SetFriction(swigCPtr, val);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRollingFriction(float val) {
    corePINVOKE.ChMaterialSurface_SetRollingFriction(swigCPtr, val);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetRollingFriction() {
    float ret = corePINVOKE.ChMaterialSurface_GetRollingFriction(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSpinningFriction(float val) {
    corePINVOKE.ChMaterialSurface_SetSpinningFriction(swigCPtr, val);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetSpinningFriction() {
    float ret = corePINVOKE.ChMaterialSurface_GetSpinningFriction(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetRestitution(float val) {
    corePINVOKE.ChMaterialSurface_SetRestitution(swigCPtr, val);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public float GetRestitution() {
    float ret = corePINVOKE.ChMaterialSurface_GetRestitution(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChMaterialSurface_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChMaterialSurface_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public static ChMaterialSurface DefaultMaterial(ChContactMethod contact_method) {
    global::System.IntPtr cPtr = corePINVOKE.ChMaterialSurface_DefaultMaterial((int)contact_method);
    ChMaterialSurface ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMaterialSurface(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float static_friction {
    set {
      corePINVOKE.ChMaterialSurface_static_friction_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChMaterialSurface_static_friction_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float sliding_friction {
    set {
      corePINVOKE.ChMaterialSurface_sliding_friction_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChMaterialSurface_sliding_friction_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float rolling_friction {
    set {
      corePINVOKE.ChMaterialSurface_rolling_friction_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChMaterialSurface_rolling_friction_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float spinning_friction {
    set {
      corePINVOKE.ChMaterialSurface_spinning_friction_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChMaterialSurface_spinning_friction_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float restitution {
    set {
      corePINVOKE.ChMaterialSurface_restitution_set(swigCPtr, value);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = corePINVOKE.ChMaterialSurface_restitution_get(swigCPtr);
      if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
