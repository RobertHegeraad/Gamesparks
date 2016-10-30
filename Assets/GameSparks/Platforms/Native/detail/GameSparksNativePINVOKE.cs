#if ((UNITY_PS4 || UNITY_XBOXONE) && !UNITY_EDITOR) || GS_FORCE_NATIVE_PLATFORM

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace GameSparksNative.detail {

class GameSparksNativePINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="SWIGRegisterExceptionCallbacks_GameSparksNative")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="SWIGRegisterExceptionCallbacks_GameSparksNative")]
  #endif
    public static extern void SWIGRegisterExceptionCallbacks_GameSparksNative(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_GameSparksNative")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_GameSparksNative")]
  #endif
    public static extern void SWIGRegisterExceptionCallbacksArgument_GameSparksNative(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

      [AOT.MonoPInvokeCallback (typeof (ExceptionDelegate))]
    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionDelegate))]
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionDelegate))]
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionDelegate))]
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionDelegate))]
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionDelegate))]
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionDelegate))]
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionDelegate))]
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionDelegate))]
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionDelegate))]
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionDelegate))]
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

      [AOT.MonoPInvokeCallback (typeof (ExceptionArgumentDelegate))]
    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionArgumentDelegate))]
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
      [AOT.MonoPInvokeCallback (typeof (ExceptionArgumentDelegate))]
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_GameSparksNative(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_GameSparksNative(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(GameSparksNativePINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(GameSparksNativePINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="SWIGRegisterStringCallback_GameSparksNative")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="SWIGRegisterStringCallback_GameSparksNative")]
  #endif
    public static extern void SWIGRegisterStringCallback_GameSparksNative(SWIGStringDelegate stringDelegate);

      [AOT.MonoPInvokeCallback (typeof (SWIGStringDelegate))]
    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_GameSparksNative(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static GameSparksNativePINVOKE() {
  }


  #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="CSharp_NativeWebSocket_Result_getType")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="CSharp_NativeWebSocket_Result_getType")]
  #endif
  public static extern int CSharp_NativeWebSocket_Result_getType(global::System.Runtime.InteropServices.HandleRef jarg1);

  #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="CSharp_NativeWebSocket_Result_getMessage")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="CSharp_NativeWebSocket_Result_getMessage")]
  #endif
  public static extern string CSharp_NativeWebSocket_Result_getMessage(global::System.Runtime.InteropServices.HandleRef jarg1);

  #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="CSharp_delete_NativeWebSocket_Result")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="CSharp_delete_NativeWebSocket_Result")]
  #endif
  public static extern void CSharp_delete_NativeWebSocket_Result(global::System.Runtime.InteropServices.HandleRef jarg1);

  #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="CSharp_new_NativeWebSocket")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="CSharp_new_NativeWebSocket")]
  #endif
  public static extern global::System.IntPtr CSharp_new_NativeWebSocket();

  #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="CSharp_delete_NativeWebSocket")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="CSharp_delete_NativeWebSocket")]
  #endif
  public static extern void CSharp_delete_NativeWebSocket(global::System.Runtime.InteropServices.HandleRef jarg1);

  #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="CSharp_NativeWebSocket_GSExternalOpen")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="CSharp_NativeWebSocket_GSExternalOpen")]
  #endif
  public static extern void CSharp_NativeWebSocket_GSExternalOpen(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3, string jarg4);

  #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="CSharp_NativeWebSocket_GSExternalClose")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="CSharp_NativeWebSocket_GSExternalClose")]
  #endif
  public static extern void CSharp_NativeWebSocket_GSExternalClose(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="CSharp_NativeWebSocket_GSExternalSend")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="CSharp_NativeWebSocket_GSExternalSend")]
  #endif
  public static extern void CSharp_NativeWebSocket_GSExternalSend(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);

  #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="CSharp_NativeWebSocket_Update")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="CSharp_NativeWebSocket_Update")]
  #endif
  public static extern bool CSharp_NativeWebSocket_Update(global::System.Runtime.InteropServices.HandleRef jarg1, float jarg2);

  #if (UNITY_IPHONE || UNITY_XBOX360) && !UNITY_EDITOR
    [global::System.Runtime.InteropServices.DllImport("__Internal", EntryPoint="CSharp_NativeWebSocket_GetNextResult")]
  #else
    [global::System.Runtime.InteropServices.DllImport("GameSparksNative", EntryPoint="CSharp_NativeWebSocket_GetNextResult")]
  #endif
  public static extern global::System.IntPtr CSharp_NativeWebSocket_GetNextResult(global::System.Runtime.InteropServices.HandleRef jarg1);
}

}


#endif