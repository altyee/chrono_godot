//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChVisualShapeFEA : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChVisualShapeFEA(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChVisualShapeFEA obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChVisualShapeFEA() {
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
          corePINVOKE.delete_ChVisualShapeFEA(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChVisualShapeFEA(SWIGTYPE_p_std__shared_ptrT_chrono__fea__ChMesh_t fea_mesh) : this(corePINVOKE.new_ChVisualShapeFEA(SWIGTYPE_p_std__shared_ptrT_chrono__fea__ChMesh_t.getCPtr(fea_mesh)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_chrono__fea__ChMesh GetMesh() {
    SWIGTYPE_p_chrono__fea__ChMesh ret = new SWIGTYPE_p_chrono__fea__ChMesh(corePINVOKE.ChVisualShapeFEA_GetMesh(swigCPtr), false);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChVisualShapeFEA.DataType GetFEMdataType() {
    ChVisualShapeFEA.DataType ret = (ChVisualShapeFEA.DataType)corePINVOKE.ChVisualShapeFEA_GetFEMdataType(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFEMdataType(ChVisualShapeFEA.DataType mdata) {
    corePINVOKE.ChVisualShapeFEA_SetFEMdataType(swigCPtr, (int)mdata);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChVisualShapeFEA.GlyphType GetFEMglyphType() {
    ChVisualShapeFEA.GlyphType ret = (ChVisualShapeFEA.GlyphType)corePINVOKE.ChVisualShapeFEA_GetFEMglyphType(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFEMglyphType(ChVisualShapeFEA.GlyphType mdata) {
    corePINVOKE.ChVisualShapeFEA_SetFEMglyphType(swigCPtr, (int)mdata);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetColorscaleMinMax(double min, double max) {
    corePINVOKE.ChVisualShapeFEA_SetColorscaleMinMax(swigCPtr, min, max);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSymbolsScale(double mscale) {
    corePINVOKE.ChVisualShapeFEA_SetSymbolsScale(swigCPtr, mscale);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetSymbolsScale() {
    double ret = corePINVOKE.ChVisualShapeFEA_GetSymbolsScale(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSymbolsThickness(double mthick) {
    corePINVOKE.ChVisualShapeFEA_SetSymbolsThickness(swigCPtr, mthick);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetSymbolsThickness() {
    double ret = corePINVOKE.ChVisualShapeFEA_GetSymbolsThickness(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetBeamResolution(int mres) {
    corePINVOKE.ChVisualShapeFEA_SetBeamResolution(swigCPtr, mres);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetBeamResolution() {
    int ret = corePINVOKE.ChVisualShapeFEA_GetBeamResolution(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetBeamResolutionSection(int mres) {
    corePINVOKE.ChVisualShapeFEA_SetBeamResolutionSection(swigCPtr, mres);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetBeamResolutionSection() {
    int ret = corePINVOKE.ChVisualShapeFEA_GetBeamResolutionSection(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetShellResolution(int mres) {
    corePINVOKE.ChVisualShapeFEA_SetShellResolution(swigCPtr, mres);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetShellResolution() {
    int ret = corePINVOKE.ChVisualShapeFEA_GetShellResolution(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetShrinkElements(bool mshrink, double mfact) {
    corePINVOKE.ChVisualShapeFEA_SetShrinkElements(swigCPtr, mshrink, mfact);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetWireframe(bool mwireframe) {
    corePINVOKE.ChVisualShapeFEA_SetWireframe(swigCPtr, mwireframe);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetBackfaceCull(bool mbc) {
    corePINVOKE.ChVisualShapeFEA_SetBackfaceCull(swigCPtr, mbc);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetZbufferHide(bool mhide) {
    corePINVOKE.ChVisualShapeFEA_SetZbufferHide(swigCPtr, mhide);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDefaultMeshColor(ChColor mcolor) {
    corePINVOKE.ChVisualShapeFEA_SetDefaultMeshColor(swigCPtr, ChColor.getCPtr(mcolor));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDefaultSymbolsColor(ChColor mcolor) {
    corePINVOKE.ChVisualShapeFEA_SetDefaultSymbolsColor(swigCPtr, ChColor.getCPtr(mcolor));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetSmoothFaces(bool msmooth) {
    corePINVOKE.ChVisualShapeFEA_SetSmoothFaces(swigCPtr, msmooth);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetDrawInUndeformedReference(bool mdu) {
    corePINVOKE.ChVisualShapeFEA_SetDrawInUndeformedReference(swigCPtr, mdu);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Update(ChPhysicsItem updater, ChFrameD frame) {
    corePINVOKE.ChVisualShapeFEA_Update(swigCPtr, ChPhysicsItem.getCPtr(updater), ChFrameD.getCPtr(frame));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public enum DataType {
    NONE,
    SURFACE,
    CONTACTSURFACES,
    LOADSURFACES,
    NODE_DISP_NORM,
    NODE_DISP_X,
    NODE_DISP_Y,
    NODE_DISP_Z,
    NODE_SPEED_NORM,
    NODE_SPEED_X,
    NODE_SPEED_Y,
    NODE_SPEED_Z,
    NODE_ACCEL_NORM,
    NODE_ACCEL_X,
    NODE_ACCEL_Y,
    NODE_ACCEL_Z,
    ELEM_STRAIN_VONMISES,
    ELEM_STRESS_VONMISES,
    ELEM_STRAIN_HYDROSTATIC,
    ELEM_STRESS_HYDROSTATIC,
    ELEM_BEAM_MX,
    ELEM_BEAM_MY,
    ELEM_BEAM_MZ,
    ELEM_BEAM_TX,
    ELEM_BEAM_TY,
    ELEM_BEAM_TZ,
    NODE_P,
    ANCF_BEAM_AX,
    ANCF_BEAM_BD
  }

  public enum GlyphType {
    NONE,
    NODE_DOT_POS,
    NODE_CSYS,
    NODE_VECT_SPEED,
    NODE_VECT_ACCEL,
    ELEM_TENS_STRAIN,
    ELEM_TENS_STRESS,
    ELEM_VECT_DP
  }

}
