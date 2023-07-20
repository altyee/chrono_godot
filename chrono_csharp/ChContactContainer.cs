//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChContactContainer : ChPhysicsItem {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChContactContainer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChContactContainer_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChContactContainer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChContactContainer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public virtual int GetNcontacts() {
    int ret = corePINVOKE.ChContactContainer_GetNcontacts(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void RemoveAllContacts() {
    corePINVOKE.ChContactContainer_RemoveAllContacts(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void BeginAddContact() {
    corePINVOKE.ChContactContainer_BeginAddContact(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void AddContact(ChCollisionInfo cinfo, ChMaterialSurface mat1, ChMaterialSurface mat2) {
    corePINVOKE.ChContactContainer_AddContact__SWIG_0(swigCPtr, ChCollisionInfo.getCPtr(cinfo), ChMaterialSurface.getCPtr(mat1), ChMaterialSurface.getCPtr(mat2));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void AddContact(ChCollisionInfo cinfo) {
    corePINVOKE.ChContactContainer_AddContact__SWIG_1(swigCPtr, ChCollisionInfo.getCPtr(cinfo));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void EndAddContact() {
    corePINVOKE.ChContactContainer_EndAddContact(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void RegisterAddContactCallback(AddContactCallback callback) {
    corePINVOKE.ChContactContainer_RegisterAddContactCallback(swigCPtr, AddContactCallback.getCPtr(callback));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual AddContactCallback GetAddContactCallback() {
    global::System.IntPtr cPtr = corePINVOKE.ChContactContainer_GetAddContactCallback(swigCPtr);
    AddContactCallback ret = (cPtr == global::System.IntPtr.Zero) ? null : new AddContactCallback(cPtr, true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ReportAllContacts(ReportContactCallback callback) {
    corePINVOKE.ChContactContainer_ReportAllContacts(swigCPtr, ReportContactCallback.getCPtr(callback));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ComputeContactForces() {
    corePINVOKE.ChContactContainer_ComputeContactForces(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual ChVectorD GetContactableForce(ChContactable contactable) {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChContactContainer_GetContactableForce(swigCPtr, ChContactable.getCPtr(contactable)), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ChVectorD GetContactableTorque(ChContactable contactable) {
    ChVectorD ret = new ChVectorD(corePINVOKE.ChContactContainer_GetContactableTorque(swigCPtr, ChContactable.getCPtr(contactable)), true);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChContactContainer_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    corePINVOKE.ChContactContainer_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}
