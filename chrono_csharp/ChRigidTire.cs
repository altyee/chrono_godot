//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChRigidTire : ChTire {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal ChRigidTire(global::System.IntPtr cPtr, bool cMemoryOwn) : base(vehiclePINVOKE.ChRigidTire_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChRigidTire obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          vehiclePINVOKE.delete_ChRigidTire(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override string GetTemplateName() {
    string ret = vehiclePINVOKE.ChRigidTire_GetTemplateName(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMeshFilename(string mesh_file, double sweep_sphere_radius) {
    vehiclePINVOKE.ChRigidTire_SetMeshFilename__SWIG_0(swigCPtr, mesh_file, sweep_sphere_radius);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMeshFilename(string mesh_file) {
    vehiclePINVOKE.ChRigidTire_SetMeshFilename__SWIG_1(swigCPtr, mesh_file);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool UseContactMesh() {
    bool ret = vehiclePINVOKE.ChRigidTire_UseContactMesh(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TerrainForce ReportTireForce(ChTerrain terrain) {
    TerrainForce ret = new TerrainForce(vehiclePINVOKE.ChRigidTire_ReportTireForce__SWIG_0(swigCPtr, ChTerrain.getCPtr(terrain)), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TerrainForce ReportTireForce(ChTerrain terrain, ChCoordsysD tire_frame) {
    TerrainForce ret = new TerrainForce(vehiclePINVOKE.ChRigidTire_ReportTireForce__SWIG_1(swigCPtr, ChTerrain.getCPtr(terrain), ChCoordsysD.getCPtr(tire_frame)), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChMaterialSurface GetContactMaterial() {
    global::System.IntPtr cPtr = vehiclePINVOKE.ChRigidTire_GetContactMaterial(swigCPtr);
    ChMaterialSurface ret = (cPtr == global::System.IntPtr.Zero) ? null : new ChMaterialSurface(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void AddVisualizationAssets(VisualizationType vis) {
    vehiclePINVOKE.ChRigidTire_AddVisualizationAssets(swigCPtr, (int)vis);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void RemoveVisualizationAssets() {
    vehiclePINVOKE.ChRigidTire_RemoveVisualizationAssets(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__shared_ptrT_geometry__ChTriangleMeshConnected_t GetContactMesh() {
    SWIGTYPE_p_std__shared_ptrT_geometry__ChTriangleMeshConnected_t ret = new SWIGTYPE_p_std__shared_ptrT_geometry__ChTriangleMeshConnected_t(vehiclePINVOKE.ChRigidTire_GetContactMesh(swigCPtr), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetMeshVertexStates(vector_ChVectorD pos, vector_ChVectorD vel) {
    vehiclePINVOKE.ChRigidTire_GetMeshVertexStates(swigCPtr, vector_ChVectorD.getCPtr(pos), vector_ChVectorD.getCPtr(vel));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
