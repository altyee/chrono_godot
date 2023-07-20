//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ChLoadable : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ChLoadable(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ChLoadable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ChLoadable() {
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
          corePINVOKE.delete_ChLoadable(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual int LoadableGet_ndof_x() {
    int ret = corePINVOKE.ChLoadable_LoadableGet_ndof_x(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int LoadableGet_ndof_w() {
    int ret = corePINVOKE.ChLoadable_LoadableGet_ndof_w(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void LoadableGetStateBlock_x(int block_offset, ChState mD) {
    corePINVOKE.ChLoadable_LoadableGetStateBlock_x(swigCPtr, block_offset, ChState.getCPtr(mD));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void LoadableGetStateBlock_w(int block_offset, ChStateDelta mD) {
    corePINVOKE.ChLoadable_LoadableGetStateBlock_w(swigCPtr, block_offset, ChStateDelta.getCPtr(mD));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void LoadableStateIncrement(uint off_x, ChState x_new, ChState x, uint off_v, ChStateDelta Dv) {
    corePINVOKE.ChLoadable_LoadableStateIncrement(swigCPtr, off_x, ChState.getCPtr(x_new), ChState.getCPtr(x), off_v, ChStateDelta.getCPtr(Dv));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int Get_field_ncoords() {
    int ret = corePINVOKE.ChLoadable_Get_field_ncoords(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int GetSubBlocks() {
    int ret = corePINVOKE.ChLoadable_GetSubBlocks(swigCPtr);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint GetSubBlockOffset(int nblock) {
    uint ret = corePINVOKE.ChLoadable_GetSubBlockOffset(swigCPtr, nblock);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint GetSubBlockSize(int nblock) {
    uint ret = corePINVOKE.ChLoadable_GetSubBlockSize(swigCPtr, nblock);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool IsSubBlockActive(int nblock) {
    bool ret = corePINVOKE.ChLoadable_IsSubBlockActive(swigCPtr, nblock);
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void LoadableGetVariables(SWIGTYPE_p_std__vectorT_ChVariables_p_t mvars) {
    corePINVOKE.ChLoadable_LoadableGetVariables(swigCPtr, SWIGTYPE_p_std__vectorT_ChVariables_p_t.getCPtr(mvars));
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
  }

  public ChLoadable() : this(corePINVOKE.new_ChLoadable(), true) {
    if (corePINVOKE.SWIGPendingException.Pending) throw corePINVOKE.SWIGPendingException.Retrieve();
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("LoadableGet_ndof_x", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateChLoadable_0(SwigDirectorMethodLoadableGet_ndof_x);
    if (SwigDerivedClassHasMethod("LoadableGet_ndof_w", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateChLoadable_1(SwigDirectorMethodLoadableGet_ndof_w);
    if (SwigDerivedClassHasMethod("LoadableGetStateBlock_x", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateChLoadable_2(SwigDirectorMethodLoadableGetStateBlock_x);
    if (SwigDerivedClassHasMethod("LoadableGetStateBlock_w", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateChLoadable_3(SwigDirectorMethodLoadableGetStateBlock_w);
    if (SwigDerivedClassHasMethod("LoadableStateIncrement", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateChLoadable_4(SwigDirectorMethodLoadableStateIncrement);
    if (SwigDerivedClassHasMethod("Get_field_ncoords", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateChLoadable_5(SwigDirectorMethodGet_field_ncoords);
    if (SwigDerivedClassHasMethod("GetSubBlocks", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateChLoadable_6(SwigDirectorMethodGetSubBlocks);
    if (SwigDerivedClassHasMethod("GetSubBlockOffset", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateChLoadable_7(SwigDirectorMethodGetSubBlockOffset);
    if (SwigDerivedClassHasMethod("GetSubBlockSize", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateChLoadable_8(SwigDirectorMethodGetSubBlockSize);
    if (SwigDerivedClassHasMethod("IsSubBlockActive", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateChLoadable_9(SwigDirectorMethodIsSubBlockActive);
    if (SwigDerivedClassHasMethod("LoadableGetVariables", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateChLoadable_10(SwigDirectorMethodLoadableGetVariables);
    corePINVOKE.ChLoadable_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ChLoadable));
    return hasDerivedMethod;
  }

  private int SwigDirectorMethodLoadableGet_ndof_x() {
    return LoadableGet_ndof_x();
  }

  private int SwigDirectorMethodLoadableGet_ndof_w() {
    return LoadableGet_ndof_w();
  }

  private void SwigDirectorMethodLoadableGetStateBlock_x(int block_offset, global::System.IntPtr mD) {
    LoadableGetStateBlock_x(block_offset, new ChState(mD, false));
  }

  private void SwigDirectorMethodLoadableGetStateBlock_w(int block_offset, global::System.IntPtr mD) {
    LoadableGetStateBlock_w(block_offset, new ChStateDelta(mD, false));
  }

  private void SwigDirectorMethodLoadableStateIncrement(uint off_x, global::System.IntPtr x_new, global::System.IntPtr x, uint off_v, global::System.IntPtr Dv) {
    LoadableStateIncrement(off_x, new ChState(x_new, false), new ChState(x, false), off_v, new ChStateDelta(Dv, false));
  }

  private int SwigDirectorMethodGet_field_ncoords() {
    return Get_field_ncoords();
  }

  private int SwigDirectorMethodGetSubBlocks() {
    return GetSubBlocks();
  }

  private uint SwigDirectorMethodGetSubBlockOffset(int nblock) {
    return GetSubBlockOffset(nblock);
  }

  private uint SwigDirectorMethodGetSubBlockSize(int nblock) {
    return GetSubBlockSize(nblock);
  }

  private bool SwigDirectorMethodIsSubBlockActive(int nblock) {
    return IsSubBlockActive(nblock);
  }

  private void SwigDirectorMethodLoadableGetVariables(global::System.IntPtr mvars) {
    LoadableGetVariables(new SWIGTYPE_p_std__vectorT_ChVariables_p_t(mvars, false));
  }

  public delegate int SwigDelegateChLoadable_0();
  public delegate int SwigDelegateChLoadable_1();
  public delegate void SwigDelegateChLoadable_2(int block_offset, global::System.IntPtr mD);
  public delegate void SwigDelegateChLoadable_3(int block_offset, global::System.IntPtr mD);
  public delegate void SwigDelegateChLoadable_4(uint off_x, global::System.IntPtr x_new, global::System.IntPtr x, uint off_v, global::System.IntPtr Dv);
  public delegate int SwigDelegateChLoadable_5();
  public delegate int SwigDelegateChLoadable_6();
  public delegate uint SwigDelegateChLoadable_7(int nblock);
  public delegate uint SwigDelegateChLoadable_8(int nblock);
  public delegate bool SwigDelegateChLoadable_9(int nblock);
  public delegate void SwigDelegateChLoadable_10(global::System.IntPtr mvars);

  private SwigDelegateChLoadable_0 swigDelegate0;
  private SwigDelegateChLoadable_1 swigDelegate1;
  private SwigDelegateChLoadable_2 swigDelegate2;
  private SwigDelegateChLoadable_3 swigDelegate3;
  private SwigDelegateChLoadable_4 swigDelegate4;
  private SwigDelegateChLoadable_5 swigDelegate5;
  private SwigDelegateChLoadable_6 swigDelegate6;
  private SwigDelegateChLoadable_7 swigDelegate7;
  private SwigDelegateChLoadable_8 swigDelegate8;
  private SwigDelegateChLoadable_9 swigDelegate9;
  private SwigDelegateChLoadable_10 swigDelegate10;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(int), typeof(ChState) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(int), typeof(ChStateDelta) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(uint), typeof(ChState), typeof(ChState), typeof(uint), typeof(ChStateDelta) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(SWIGTYPE_p_std__vectorT_ChVariables_p_t) };
}
