//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChBodyEasyCylinder : ChBody {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChBodyEasyCylinder(global::System.IntPtr cPtr, bool cMemoryOwn) : base(corePINVOKE.ChBodyEasyCylinder_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChBodyEasyCylinder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          corePINVOKE.delete_ChBodyEasyCylinder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ChBodyEasyCylinder(ChAxis direction, double radius, double height, double density, bool visualize, bool collide, ChMaterialSurface material, ChCollisionModel collision_model) : this(corePINVOKE.new_ChBodyEasyCylinder__SWIG_0((int)direction, radius, height, density, visualize, collide, ChMaterialSurface.getCPtr(material), ChCollisionModel.getCPtr(collision_model)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyCylinder(ChAxis direction, double radius, double height, double density, bool visualize, bool collide, ChMaterialSurface material) : this(corePINVOKE.new_ChBodyEasyCylinder__SWIG_1((int)direction, radius, height, density, visualize, collide, ChMaterialSurface.getCPtr(material)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyCylinder(ChAxis direction, double radius, double height, double density, bool visualize, bool collide) : this(corePINVOKE.new_ChBodyEasyCylinder__SWIG_2((int)direction, radius, height, density, visualize, collide), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyCylinder(ChAxis direction, double radius, double height, double density, bool visualize) : this(corePINVOKE.new_ChBodyEasyCylinder__SWIG_3((int)direction, radius, height, density, visualize), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyCylinder(ChAxis direction, double radius, double height, double density) : this(corePINVOKE.new_ChBodyEasyCylinder__SWIG_4((int)direction, radius, height, density), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChBodyEasyCylinder(ChAxis direction, double radius, double height, double density, ChMaterialSurface material, ChCollisionSystemType collision_type) : this(corePINVOKE.new_ChBodyEasyCylinder__SWIG_5((int)direction, radius, height, density, ChMaterialSurface.getCPtr(material), (int)collision_type), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveOutConstructor(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    corePINVOKE.ChBodyEasyCylinder_ArchiveOutConstructor(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public static SWIGTYPE_p_void ArchiveInConstructor(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    global::System.IntPtr cPtr = corePINVOKE.ChBodyEasyCylinder_ArchiveInConstructor(SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
