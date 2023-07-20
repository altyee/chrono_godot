//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChFunction : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChFunction(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChFunction obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChFunction() {
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
          corePINVOKE.delete_ChFunction(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChFunction() : this(corePINVOKE.new_ChFunction__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public ChFunction(ChFunction other) : this(corePINVOKE.new_ChFunction__SWIG_1(ChFunction.getCPtr(other)), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  public virtual ChFunction.FunctionType Get_Type() {
    ChFunction.FunctionType ret = (ChFunction.FunctionType)(SwigDerivedClassHasMethod("Get_Type", swigMethodTypes0) ? corePINVOKE.ChFunction_Get_TypeSwigExplicitChFunction(swigCPtr) : corePINVOKE.ChFunction_Get_Type(swigCPtr));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Get_y(double x) {
    double ret = corePINVOKE.ChFunction_Get_y(swigCPtr, x);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Get_y_dx(double x) {
    double ret = (SwigDerivedClassHasMethod("Get_y_dx", swigMethodTypes2) ? corePINVOKE.ChFunction_Get_y_dxSwigExplicitChFunction(swigCPtr, x) : corePINVOKE.ChFunction_Get_y_dx(swigCPtr, x));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Get_y_dxdx(double x) {
    double ret = (SwigDerivedClassHasMethod("Get_y_dxdx", swigMethodTypes3) ? corePINVOKE.ChFunction_Get_y_dxdxSwigExplicitChFunction(swigCPtr, x) : corePINVOKE.ChFunction_Get_y_dxdx(swigCPtr, x));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Get_weight(double x) {
    double ret = (SwigDerivedClassHasMethod("Get_weight", swigMethodTypes4) ? corePINVOKE.ChFunction_Get_weightSwigExplicitChFunction(swigCPtr, x) : corePINVOKE.ChFunction_Get_weight(swigCPtr, x));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Estimate_x_range(SWIGTYPE_p_double xmin, SWIGTYPE_p_double xmax) {
    if (SwigDerivedClassHasMethod("Estimate_x_range", swigMethodTypes5)) corePINVOKE.ChFunction_Estimate_x_rangeSwigExplicitChFunction(swigCPtr, SWIGTYPE_p_double.getCPtr(xmin), SWIGTYPE_p_double.getCPtr(xmax)); else corePINVOKE.ChFunction_Estimate_x_range(swigCPtr, SWIGTYPE_p_double.getCPtr(xmin), SWIGTYPE_p_double.getCPtr(xmax));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Estimate_y_range(double xmin, double xmax, SWIGTYPE_p_double ymin, SWIGTYPE_p_double ymax, int derivate) {
    if (SwigDerivedClassHasMethod("Estimate_y_range", swigMethodTypes6)) corePINVOKE.ChFunction_Estimate_y_rangeSwigExplicitChFunction(swigCPtr, xmin, xmax, SWIGTYPE_p_double.getCPtr(ymin), SWIGTYPE_p_double.getCPtr(ymax), derivate); else corePINVOKE.ChFunction_Estimate_y_range(swigCPtr, xmin, xmax, SWIGTYPE_p_double.getCPtr(ymin), SWIGTYPE_p_double.getCPtr(ymax), derivate);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double Get_y_dN(double x, int derivate) {
    double ret = (SwigDerivedClassHasMethod("Get_y_dN", swigMethodTypes7) ? corePINVOKE.ChFunction_Get_y_dNSwigExplicitChFunction(swigCPtr, x, derivate) : corePINVOKE.ChFunction_Get_y_dN(swigCPtr, x, derivate));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Update(double x) {
    if (SwigDerivedClassHasMethod("Update", swigMethodTypes8)) corePINVOKE.ChFunction_UpdateSwigExplicitChFunction(swigCPtr, x); else corePINVOKE.ChFunction_Update(swigCPtr, x);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual double Compute_max(double xmin, double xmax, double sampling_step, int derivate) {
    double ret = (SwigDerivedClassHasMethod("Compute_max", swigMethodTypes9) ? corePINVOKE.ChFunction_Compute_maxSwigExplicitChFunction(swigCPtr, xmin, xmax, sampling_step, derivate) : corePINVOKE.ChFunction_Compute_max(swigCPtr, xmin, xmax, sampling_step, derivate));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Compute_min(double xmin, double xmax, double sampling_step, int derivate) {
    double ret = (SwigDerivedClassHasMethod("Compute_min", swigMethodTypes10) ? corePINVOKE.ChFunction_Compute_minSwigExplicitChFunction(swigCPtr, xmin, xmax, sampling_step, derivate) : corePINVOKE.ChFunction_Compute_min(swigCPtr, xmin, xmax, sampling_step, derivate));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Compute_mean(double xmin, double xmax, double sampling_step, int derivate) {
    double ret = (SwigDerivedClassHasMethod("Compute_mean", swigMethodTypes11) ? corePINVOKE.ChFunction_Compute_meanSwigExplicitChFunction(swigCPtr, xmin, xmax, sampling_step, derivate) : corePINVOKE.ChFunction_Compute_mean(swigCPtr, xmin, xmax, sampling_step, derivate));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Compute_sqrmean(double xmin, double xmax, double sampling_step, int derivate) {
    double ret = (SwigDerivedClassHasMethod("Compute_sqrmean", swigMethodTypes12) ? corePINVOKE.ChFunction_Compute_sqrmeanSwigExplicitChFunction(swigCPtr, xmin, xmax, sampling_step, derivate) : corePINVOKE.ChFunction_Compute_sqrmean(swigCPtr, xmin, xmax, sampling_step, derivate));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Compute_int(double xmin, double xmax, double sampling_step, int derivate) {
    double ret = (SwigDerivedClassHasMethod("Compute_int", swigMethodTypes13) ? corePINVOKE.ChFunction_Compute_intSwigExplicitChFunction(swigCPtr, xmin, xmax, sampling_step, derivate) : corePINVOKE.ChFunction_Compute_int(swigCPtr, xmin, xmax, sampling_step, derivate));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Get_Ca_pos() {
    double ret = (SwigDerivedClassHasMethod("Get_Ca_pos", swigMethodTypes14) ? corePINVOKE.ChFunction_Get_Ca_posSwigExplicitChFunction(swigCPtr) : corePINVOKE.ChFunction_Get_Ca_pos(swigCPtr));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Get_Ca_neg() {
    double ret = (SwigDerivedClassHasMethod("Get_Ca_neg", swigMethodTypes15) ? corePINVOKE.ChFunction_Get_Ca_negSwigExplicitChFunction(swigCPtr) : corePINVOKE.ChFunction_Get_Ca_neg(swigCPtr));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double Get_Cv() {
    double ret = (SwigDerivedClassHasMethod("Get_Cv", swigMethodTypes16) ? corePINVOKE.ChFunction_Get_CvSwigExplicitChFunction(swigCPtr) : corePINVOKE.ChFunction_Get_Cv(swigCPtr));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int HandleNumber() {
    int ret = (SwigDerivedClassHasMethod("HandleNumber", swigMethodTypes17) ? corePINVOKE.ChFunction_HandleNumberSwigExplicitChFunction(swigCPtr) : corePINVOKE.ChFunction_HandleNumber(swigCPtr));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool HandleAccess(int handle_id, double mx, double my, bool set_mode) {
    bool ret = (SwigDerivedClassHasMethod("HandleAccess", swigMethodTypes18) ? corePINVOKE.ChFunction_HandleAccessSwigExplicitChFunction(swigCPtr, handle_id, mx, my, set_mode) : corePINVOKE.ChFunction_HandleAccess(swigCPtr, handle_id, mx, my, set_mode));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void ArchiveOut(SWIGTYPE_p_chrono__ChArchiveOut marchive) {
    if (SwigDerivedClassHasMethod("ArchiveOut", swigMethodTypes19)) corePINVOKE.ChFunction_ArchiveOutSwigExplicitChFunction(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive)); else corePINVOKE.ChFunction_ArchiveOut(swigCPtr, SWIGTYPE_p_chrono__ChArchiveOut.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void ArchiveIn(SWIGTYPE_p_chrono__ChArchiveIn marchive) {
    if (SwigDerivedClassHasMethod("ArchiveIn", swigMethodTypes20)) corePINVOKE.ChFunction_ArchiveInSwigExplicitChFunction(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive)); else corePINVOKE.ChFunction_ArchiveIn(swigCPtr, SWIGTYPE_p_chrono__ChArchiveIn.getCPtr(marchive));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int FilePostscriptPlot(SWIGTYPE_p_ChFile_ps m_file, int plotY, int plotDY, int plotDDY) {
    int ret = (SwigDerivedClassHasMethod("FilePostscriptPlot", swigMethodTypes21) ? corePINVOKE.ChFunction_FilePostscriptPlotSwigExplicitChFunction(swigCPtr, SWIGTYPE_p_ChFile_ps.getCPtr(m_file), plotY, plotDY, plotDDY) : corePINVOKE.ChFunction_FilePostscriptPlot(swigCPtr, SWIGTYPE_p_ChFile_ps.getCPtr(m_file), plotY, plotDY, plotDDY));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int FileAsciiPairsSave(ChStreamOutAscii m_file, double xmin, double xmax, int msamples) {
    int ret = (SwigDerivedClassHasMethod("FileAsciiPairsSave", swigMethodTypes22) ? corePINVOKE.ChFunction_FileAsciiPairsSaveSwigExplicitChFunction__SWIG_0(swigCPtr, ChStreamOutAscii.getCPtr(m_file), xmin, xmax, msamples) : corePINVOKE.ChFunction_FileAsciiPairsSave__SWIG_0(swigCPtr, ChStreamOutAscii.getCPtr(m_file), xmin, xmax, msamples));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int FileAsciiPairsSave(ChStreamOutAscii m_file, double xmin, double xmax) {
    int ret = (SwigDerivedClassHasMethod("FileAsciiPairsSave", swigMethodTypes23) ? corePINVOKE.ChFunction_FileAsciiPairsSaveSwigExplicitChFunction__SWIG_1(swigCPtr, ChStreamOutAscii.getCPtr(m_file), xmin, xmax) : corePINVOKE.ChFunction_FileAsciiPairsSave__SWIG_1(swigCPtr, ChStreamOutAscii.getCPtr(m_file), xmin, xmax));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int FileAsciiPairsSave(ChStreamOutAscii m_file, double xmin) {
    int ret = (SwigDerivedClassHasMethod("FileAsciiPairsSave", swigMethodTypes24) ? corePINVOKE.ChFunction_FileAsciiPairsSaveSwigExplicitChFunction__SWIG_2(swigCPtr, ChStreamOutAscii.getCPtr(m_file), xmin) : corePINVOKE.ChFunction_FileAsciiPairsSave__SWIG_2(swigCPtr, ChStreamOutAscii.getCPtr(m_file), xmin));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int FileAsciiPairsSave(ChStreamOutAscii m_file) {
    int ret = (SwigDerivedClassHasMethod("FileAsciiPairsSave", swigMethodTypes25) ? corePINVOKE.ChFunction_FileAsciiPairsSaveSwigExplicitChFunction__SWIG_3(swigCPtr, ChStreamOutAscii.getCPtr(m_file)) : corePINVOKE.ChFunction_FileAsciiPairsSave__SWIG_3(swigCPtr, ChStreamOutAscii.getCPtr(m_file)));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("Get_Type", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateChFunction_0(SwigDirectorMethodGet_Type);
    if (SwigDerivedClassHasMethod("Get_y", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateChFunction_1(SwigDirectorMethodGet_y);
    if (SwigDerivedClassHasMethod("Get_y_dx", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateChFunction_2(SwigDirectorMethodGet_y_dx);
    if (SwigDerivedClassHasMethod("Get_y_dxdx", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateChFunction_3(SwigDirectorMethodGet_y_dxdx);
    if (SwigDerivedClassHasMethod("Get_weight", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateChFunction_4(SwigDirectorMethodGet_weight);
    if (SwigDerivedClassHasMethod("Estimate_x_range", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateChFunction_5(SwigDirectorMethodEstimate_x_range);
    if (SwigDerivedClassHasMethod("Estimate_y_range", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateChFunction_6(SwigDirectorMethodEstimate_y_range);
    if (SwigDerivedClassHasMethod("Get_y_dN", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateChFunction_7(SwigDirectorMethodGet_y_dN);
    if (SwigDerivedClassHasMethod("Update", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateChFunction_8(SwigDirectorMethodUpdate);
    if (SwigDerivedClassHasMethod("Compute_max", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateChFunction_9(SwigDirectorMethodCompute_max);
    if (SwigDerivedClassHasMethod("Compute_min", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateChFunction_10(SwigDirectorMethodCompute_min);
    if (SwigDerivedClassHasMethod("Compute_mean", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateChFunction_11(SwigDirectorMethodCompute_mean);
    if (SwigDerivedClassHasMethod("Compute_sqrmean", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateChFunction_12(SwigDirectorMethodCompute_sqrmean);
    if (SwigDerivedClassHasMethod("Compute_int", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateChFunction_13(SwigDirectorMethodCompute_int);
    if (SwigDerivedClassHasMethod("Get_Ca_pos", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateChFunction_14(SwigDirectorMethodGet_Ca_pos);
    if (SwigDerivedClassHasMethod("Get_Ca_neg", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateChFunction_15(SwigDirectorMethodGet_Ca_neg);
    if (SwigDerivedClassHasMethod("Get_Cv", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateChFunction_16(SwigDirectorMethodGet_Cv);
    if (SwigDerivedClassHasMethod("HandleNumber", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateChFunction_17(SwigDirectorMethodHandleNumber);
    if (SwigDerivedClassHasMethod("HandleAccess", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateChFunction_18(SwigDirectorMethodHandleAccess);
    if (SwigDerivedClassHasMethod("ArchiveOut", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateChFunction_19(SwigDirectorMethodArchiveOut);
    if (SwigDerivedClassHasMethod("ArchiveIn", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateChFunction_20(SwigDirectorMethodArchiveIn);
    if (SwigDerivedClassHasMethod("FilePostscriptPlot", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateChFunction_21(SwigDirectorMethodFilePostscriptPlot);
    if (SwigDerivedClassHasMethod("FileAsciiPairsSave", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateChFunction_22(SwigDirectorMethodFileAsciiPairsSave__SWIG_0);
    if (SwigDerivedClassHasMethod("FileAsciiPairsSave", swigMethodTypes23))
      swigDelegate23 = new SwigDelegateChFunction_23(SwigDirectorMethodFileAsciiPairsSave__SWIG_1);
    if (SwigDerivedClassHasMethod("FileAsciiPairsSave", swigMethodTypes24))
      swigDelegate24 = new SwigDelegateChFunction_24(SwigDirectorMethodFileAsciiPairsSave__SWIG_2);
    if (SwigDerivedClassHasMethod("FileAsciiPairsSave", swigMethodTypes25))
      swigDelegate25 = new SwigDelegateChFunction_25(SwigDirectorMethodFileAsciiPairsSave__SWIG_3);
    corePINVOKE.ChFunction_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22, swigDelegate23, swigDelegate24, swigDelegate25);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ChFunction));
    return hasDerivedMethod;
  }

  private int SwigDirectorMethodGet_Type() {
    return (int)Get_Type();
  }

  private double SwigDirectorMethodGet_y(double x) {
    return Get_y(x);
  }

  private double SwigDirectorMethodGet_y_dx(double x) {
    return Get_y_dx(x);
  }

  private double SwigDirectorMethodGet_y_dxdx(double x) {
    return Get_y_dxdx(x);
  }

  private double SwigDirectorMethodGet_weight(double x) {
    return Get_weight(x);
  }

  private void SwigDirectorMethodEstimate_x_range(global::System.IntPtr xmin, global::System.IntPtr xmax) {
    Estimate_x_range(new SWIGTYPE_p_double(xmin, false), new SWIGTYPE_p_double(xmax, false));
  }

  private void SwigDirectorMethodEstimate_y_range(double xmin, double xmax, global::System.IntPtr ymin, global::System.IntPtr ymax, int derivate) {
    Estimate_y_range(xmin, xmax, new SWIGTYPE_p_double(ymin, false), new SWIGTYPE_p_double(ymax, false), derivate);
  }

  private double SwigDirectorMethodGet_y_dN(double x, int derivate) {
    return Get_y_dN(x, derivate);
  }

  private void SwigDirectorMethodUpdate(double x) {
    Update(x);
  }

  private double SwigDirectorMethodCompute_max(double xmin, double xmax, double sampling_step, int derivate) {
    return Compute_max(xmin, xmax, sampling_step, derivate);
  }

  private double SwigDirectorMethodCompute_min(double xmin, double xmax, double sampling_step, int derivate) {
    return Compute_min(xmin, xmax, sampling_step, derivate);
  }

  private double SwigDirectorMethodCompute_mean(double xmin, double xmax, double sampling_step, int derivate) {
    return Compute_mean(xmin, xmax, sampling_step, derivate);
  }

  private double SwigDirectorMethodCompute_sqrmean(double xmin, double xmax, double sampling_step, int derivate) {
    return Compute_sqrmean(xmin, xmax, sampling_step, derivate);
  }

  private double SwigDirectorMethodCompute_int(double xmin, double xmax, double sampling_step, int derivate) {
    return Compute_int(xmin, xmax, sampling_step, derivate);
  }

  private double SwigDirectorMethodGet_Ca_pos() {
    return Get_Ca_pos();
  }

  private double SwigDirectorMethodGet_Ca_neg() {
    return Get_Ca_neg();
  }

  private double SwigDirectorMethodGet_Cv() {
    return Get_Cv();
  }

  private int SwigDirectorMethodHandleNumber() {
    return HandleNumber();
  }

  private bool SwigDirectorMethodHandleAccess(int handle_id, double mx, double my, bool set_mode) {
    return HandleAccess(handle_id, mx, my, set_mode);
  }

  private void SwigDirectorMethodArchiveOut(global::System.IntPtr marchive) {
    ArchiveOut(new SWIGTYPE_p_chrono__ChArchiveOut(marchive, false));
  }

  private void SwigDirectorMethodArchiveIn(global::System.IntPtr marchive) {
    ArchiveIn(new SWIGTYPE_p_chrono__ChArchiveIn(marchive, false));
  }

  private int SwigDirectorMethodFilePostscriptPlot(global::System.IntPtr m_file, int plotY, int plotDY, int plotDDY) {
    return FilePostscriptPlot((m_file == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ChFile_ps(m_file, false), plotY, plotDY, plotDDY);
  }

  private int SwigDirectorMethodFileAsciiPairsSave__SWIG_0(global::System.IntPtr m_file, double xmin, double xmax, int msamples) {
    return FileAsciiPairsSave(new ChStreamOutAscii(m_file, false), xmin, xmax, msamples);
  }

  private int SwigDirectorMethodFileAsciiPairsSave__SWIG_1(global::System.IntPtr m_file, double xmin, double xmax) {
    return FileAsciiPairsSave(new ChStreamOutAscii(m_file, false), xmin, xmax);
  }

  private int SwigDirectorMethodFileAsciiPairsSave__SWIG_2(global::System.IntPtr m_file, double xmin) {
    return FileAsciiPairsSave(new ChStreamOutAscii(m_file, false), xmin);
  }

  private int SwigDirectorMethodFileAsciiPairsSave__SWIG_3(global::System.IntPtr m_file) {
    return FileAsciiPairsSave(new ChStreamOutAscii(m_file, false));
  }

  public delegate int SwigDelegateChFunction_0();
  public delegate double SwigDelegateChFunction_1(double x);
  public delegate double SwigDelegateChFunction_2(double x);
  public delegate double SwigDelegateChFunction_3(double x);
  public delegate double SwigDelegateChFunction_4(double x);
  public delegate void SwigDelegateChFunction_5(global::System.IntPtr xmin, global::System.IntPtr xmax);
  public delegate void SwigDelegateChFunction_6(double xmin, double xmax, global::System.IntPtr ymin, global::System.IntPtr ymax, int derivate);
  public delegate double SwigDelegateChFunction_7(double x, int derivate);
  public delegate void SwigDelegateChFunction_8(double x);
  public delegate double SwigDelegateChFunction_9(double xmin, double xmax, double sampling_step, int derivate);
  public delegate double SwigDelegateChFunction_10(double xmin, double xmax, double sampling_step, int derivate);
  public delegate double SwigDelegateChFunction_11(double xmin, double xmax, double sampling_step, int derivate);
  public delegate double SwigDelegateChFunction_12(double xmin, double xmax, double sampling_step, int derivate);
  public delegate double SwigDelegateChFunction_13(double xmin, double xmax, double sampling_step, int derivate);
  public delegate double SwigDelegateChFunction_14();
  public delegate double SwigDelegateChFunction_15();
  public delegate double SwigDelegateChFunction_16();
  public delegate int SwigDelegateChFunction_17();
  public delegate bool SwigDelegateChFunction_18(int handle_id, double mx, double my, bool set_mode);
  public delegate void SwigDelegateChFunction_19(global::System.IntPtr marchive);
  public delegate void SwigDelegateChFunction_20(global::System.IntPtr marchive);
  public delegate int SwigDelegateChFunction_21(global::System.IntPtr m_file, int plotY, int plotDY, int plotDDY);
  public delegate int SwigDelegateChFunction_22(global::System.IntPtr m_file, double xmin, double xmax, int msamples);
  public delegate int SwigDelegateChFunction_23(global::System.IntPtr m_file, double xmin, double xmax);
  public delegate int SwigDelegateChFunction_24(global::System.IntPtr m_file, double xmin);
  public delegate int SwigDelegateChFunction_25(global::System.IntPtr m_file);

  private SwigDelegateChFunction_0 swigDelegate0;
  private SwigDelegateChFunction_1 swigDelegate1;
  private SwigDelegateChFunction_2 swigDelegate2;
  private SwigDelegateChFunction_3 swigDelegate3;
  private SwigDelegateChFunction_4 swigDelegate4;
  private SwigDelegateChFunction_5 swigDelegate5;
  private SwigDelegateChFunction_6 swigDelegate6;
  private SwigDelegateChFunction_7 swigDelegate7;
  private SwigDelegateChFunction_8 swigDelegate8;
  private SwigDelegateChFunction_9 swigDelegate9;
  private SwigDelegateChFunction_10 swigDelegate10;
  private SwigDelegateChFunction_11 swigDelegate11;
  private SwigDelegateChFunction_12 swigDelegate12;
  private SwigDelegateChFunction_13 swigDelegate13;
  private SwigDelegateChFunction_14 swigDelegate14;
  private SwigDelegateChFunction_15 swigDelegate15;
  private SwigDelegateChFunction_16 swigDelegate16;
  private SwigDelegateChFunction_17 swigDelegate17;
  private SwigDelegateChFunction_18 swigDelegate18;
  private SwigDelegateChFunction_19 swigDelegate19;
  private SwigDelegateChFunction_20 swigDelegate20;
  private SwigDelegateChFunction_21 swigDelegate21;
  private SwigDelegateChFunction_22 swigDelegate22;
  private SwigDelegateChFunction_23 swigDelegate23;
  private SwigDelegateChFunction_24 swigDelegate24;
  private SwigDelegateChFunction_25 swigDelegate25;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(double) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(double) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(double) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(double) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(SWIGTYPE_p_double), typeof(SWIGTYPE_p_double) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(double), typeof(double), typeof(SWIGTYPE_p_double), typeof(SWIGTYPE_p_double), typeof(int) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(double), typeof(int) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(double) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(double), typeof(double), typeof(double), typeof(int) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(double), typeof(double), typeof(double), typeof(int) };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] { typeof(double), typeof(double), typeof(double), typeof(int) };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] { typeof(double), typeof(double), typeof(double), typeof(int) };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] { typeof(double), typeof(double), typeof(double), typeof(int) };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes17 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes18 = new global::System.Type[] { typeof(int), typeof(double), typeof(double), typeof(bool) };
  private static global::System.Type[] swigMethodTypes19 = new global::System.Type[] { typeof(SWIGTYPE_p_chrono__ChArchiveOut) };
  private static global::System.Type[] swigMethodTypes20 = new global::System.Type[] { typeof(SWIGTYPE_p_chrono__ChArchiveIn) };
  private static global::System.Type[] swigMethodTypes21 = new global::System.Type[] { typeof(SWIGTYPE_p_ChFile_ps), typeof(int), typeof(int), typeof(int) };
  private static global::System.Type[] swigMethodTypes22 = new global::System.Type[] { typeof(ChStreamOutAscii), typeof(double), typeof(double), typeof(int) };
  private static global::System.Type[] swigMethodTypes23 = new global::System.Type[] { typeof(ChStreamOutAscii), typeof(double), typeof(double) };
  private static global::System.Type[] swigMethodTypes24 = new global::System.Type[] { typeof(ChStreamOutAscii), typeof(double) };
  private static global::System.Type[] swigMethodTypes25 = new global::System.Type[] { typeof(ChStreamOutAscii) };
  public enum FunctionType {
    FUNCT_CUSTOM,
    FUNCT_CONST,
    FUNCT_CONSTACC,
    FUNCT_DERIVE,
    FUNCT_FILLET3,
    FUNCT_INTEGRATE,
    FUNCT_MATLAB,
    FUNCT_MIRROR,
    FUNCT_MOCAP,
    FUNCT_NOISE,
    FUNCT_OPERATION,
    FUNCT_OSCILLOSCOPE,
    FUNCT_POLY,
    FUNCT_POLY345,
    FUNCT_RAMP,
    FUNCT_RECORDER,
    FUNCT_REPEAT,
    FUNCT_SEQUENCE,
    FUNCT_SIGMA,
    FUNCT_SINE,
    FUNCT_LAMBDA
  }

}
