//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class vector_Entry : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<DataDriverEntry>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal vector_Entry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(vector_Entry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(vector_Entry obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~vector_Entry() {
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
          vehiclePINVOKE.delete_vector_Entry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public vector_Entry(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (DataDriverEntry element in c) {
      this.Add(element);
    }
  }

  public vector_Entry(global::System.Collections.Generic.IEnumerable<DataDriverEntry> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (DataDriverEntry element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public DataDriverEntry this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < 0 || (uint)value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(DataDriverEntry[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(DataDriverEntry[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, DataDriverEntry[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public DataDriverEntry[] ToArray() {
    DataDriverEntry[] array = new DataDriverEntry[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<DataDriverEntry> global::System.Collections.Generic.IEnumerable<DataDriverEntry>.GetEnumerator() {
    return new vector_EntryEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new vector_EntryEnumerator(this);
  }

  public vector_EntryEnumerator GetEnumerator() {
    return new vector_EntryEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class vector_EntryEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<DataDriverEntry>
  {
    private vector_Entry collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public vector_EntryEnumerator(vector_Entry collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public DataDriverEntry Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (DataDriverEntry)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    vehiclePINVOKE.vector_Entry_Clear(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(DataDriverEntry x) {
    vehiclePINVOKE.vector_Entry_Add(swigCPtr, DataDriverEntry.getCPtr(x));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = vehiclePINVOKE.vector_Entry_size(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = vehiclePINVOKE.vector_Entry_capacity(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    vehiclePINVOKE.vector_Entry_reserve(swigCPtr, n);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_Entry() : this(vehiclePINVOKE.new_vector_Entry__SWIG_0(), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_Entry(vector_Entry other) : this(vehiclePINVOKE.new_vector_Entry__SWIG_1(vector_Entry.getCPtr(other)), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_Entry(int capacity) : this(vehiclePINVOKE.new_vector_Entry__SWIG_2(capacity), true) {
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  private DataDriverEntry getitemcopy(int index) {
    DataDriverEntry ret = new DataDriverEntry(vehiclePINVOKE.vector_Entry_getitemcopy(swigCPtr, index), true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private DataDriverEntry getitem(int index) {
    DataDriverEntry ret = new DataDriverEntry(vehiclePINVOKE.vector_Entry_getitem(swigCPtr, index), false);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, DataDriverEntry val) {
    vehiclePINVOKE.vector_Entry_setitem(swigCPtr, index, DataDriverEntry.getCPtr(val));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(vector_Entry values) {
    vehiclePINVOKE.vector_Entry_AddRange(swigCPtr, vector_Entry.getCPtr(values));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_Entry GetRange(int index, int count) {
    global::System.IntPtr cPtr = vehiclePINVOKE.vector_Entry_GetRange(swigCPtr, index, count);
    vector_Entry ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_Entry(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, DataDriverEntry x) {
    vehiclePINVOKE.vector_Entry_Insert(swigCPtr, index, DataDriverEntry.getCPtr(x));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, vector_Entry values) {
    vehiclePINVOKE.vector_Entry_InsertRange(swigCPtr, index, vector_Entry.getCPtr(values));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    vehiclePINVOKE.vector_Entry_RemoveAt(swigCPtr, index);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    vehiclePINVOKE.vector_Entry_RemoveRange(swigCPtr, index, count);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public static vector_Entry Repeat(DataDriverEntry value, int count) {
    global::System.IntPtr cPtr = vehiclePINVOKE.vector_Entry_Repeat(DataDriverEntry.getCPtr(value), count);
    vector_Entry ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_Entry(cPtr, true);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    vehiclePINVOKE.vector_Entry_Reverse__SWIG_0(swigCPtr);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    vehiclePINVOKE.vector_Entry_Reverse__SWIG_1(swigCPtr, index, count);
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, vector_Entry values) {
    vehiclePINVOKE.vector_Entry_SetRange(swigCPtr, index, vector_Entry.getCPtr(values));
    if (vehiclePINVOKE.SWIGPendingException.Pending) throw vehiclePINVOKE.SWIGPendingException.Retrieve();
  }

}
