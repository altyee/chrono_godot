//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChISO2631_Vibration_SeatCushionLogger : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ChISO2631_Vibration_SeatCushionLogger(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChISO2631_Vibration_SeatCushionLogger obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChISO2631_Vibration_SeatCushionLogger() {
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
          corePINVOKE.delete_ChISO2631_Vibration_SeatCushionLogger(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ChISO2631_Vibration_SeatCushionLogger() : this(corePINVOKE.new_ChISO2631_Vibration_SeatCushionLogger__SWIG_0(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChISO2631_Vibration_SeatCushionLogger(double step) : this(corePINVOKE.new_ChISO2631_Vibration_SeatCushionLogger__SWIG_1(step), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Config(double step) {
    corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_Config(swigCPtr, step);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddData(double speed, double acc_x, double acc_y, double acc_z) {
    corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_AddData__SWIG_0(swigCPtr, speed, acc_x, acc_y, acc_z);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddData(double speed, ChVectorD acc_v) {
    corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_AddData__SWIG_1(swigCPtr, speed, ChVectorD.getCPtr(acc_v));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reset() {
    corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_Reset(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetExposureTime() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetExposureTime(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetInputRMS_X() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetInputRMS_X(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetInputRMS_Y() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetInputRMS_Y(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetInputRMS_Z() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetInputRMS_Z(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetAW_X() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetAW_X(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetAW_Y() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetAW_Y(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetAW_Z() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetAW_Z(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetAW_V() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetAW_V(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetCrestFactor() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetCrestFactor(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetVDV() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetVDV(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetAVGSpeed() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetAVGSpeed(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetSeverityVDV() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetSeverityVDV(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetAbsorbedPowerVertical() {
    double ret = corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GetAbsorbedPowerVertical(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GeneratePlotFile(string fName, string testInfo) {
    corePINVOKE.ChISO2631_Vibration_SeatCushionLogger_GeneratePlotFile(swigCPtr, fName, testInfo);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

}