using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Ags.Jni.Gamecircle {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.ags.jni.gamecircle']/class[@name='ShowGameCircleJniRespHandler']"
	[global::Android.Runtime.Register ("com/amazon/ags/jni/gamecircle/ShowGameCircleJniRespHandler", DoNotGenerateAcw=true)]
	public partial class ShowGameCircleJniRespHandler : global::Com.Amazon.Ags.Jni.JniResponseHandler, global::Com.Amazon.Ags.Api.IAGResponseCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/ags/jni/gamecircle/ShowGameCircleJniRespHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShowGameCircleJniRespHandler); }
		}

		protected ShowGameCircleJniRespHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.ags.jni.gamecircle']/class[@name='ShowGameCircleJniRespHandler']/constructor[@name='ShowGameCircleJniRespHandler' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register (".ctor", "(IJ)V", "")]
		public ShowGameCircleJniRespHandler (int p0, long p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ShowGameCircleJniRespHandler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IJ)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IJ)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_IJ == IntPtr.Zero)
				id_ctor_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(IJ)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IJ, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IJ, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onComplete_Lcom_amazon_ags_api_RequestResponse_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_amazon_ags_api_RequestResponse_Handler ()
		{
			if (cb_onComplete_Lcom_amazon_ags_api_RequestResponse_ == null)
				cb_onComplete_Lcom_amazon_ags_api_RequestResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_Lcom_amazon_ags_api_RequestResponse_);
			return cb_onComplete_Lcom_amazon_ags_api_RequestResponse_;
		}

		static void n_OnComplete_Lcom_amazon_ags_api_RequestResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Ags.Jni.Gamecircle.ShowGameCircleJniRespHandler __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Jni.Gamecircle.ShowGameCircleJniRespHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Ags.Api.IRequestResponse p0 = (global::Com.Amazon.Ags.Api.IRequestResponse)global::Java.Lang.Object.GetObject<global::Com.Amazon.Ags.Api.IRequestResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onComplete_Lcom_amazon_ags_api_RequestResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.ags.jni.gamecircle']/class[@name='ShowGameCircleJniRespHandler']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='com.amazon.ags.api.RequestResponse']]"
		[Register ("onComplete", "(Lcom/amazon/ags/api/RequestResponse;)V", "GetOnComplete_Lcom_amazon_ags_api_RequestResponse_Handler")]
		public virtual void OnComplete (global::Com.Amazon.Ags.Api.IRequestResponse p0)
		{
			if (id_onComplete_Lcom_amazon_ags_api_RequestResponse_ == IntPtr.Zero)
				id_onComplete_Lcom_amazon_ags_api_RequestResponse_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/amazon/ags/api/RequestResponse;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onComplete_Lcom_amazon_ags_api_RequestResponse_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onComplete_Lcom_amazon_ags_api_RequestResponse_, new JValue (p0));
		}

		// This method is explicitly implemented as a member of an instantiated Com.Amazon.Ags.Api.IAGResponseCallback
		void global::Com.Amazon.Ags.Api.IAGResponseCallback.OnComplete (global::Java.Lang.Object p0)
		{
			OnComplete (global::Java.Interop.JavaObjectExtensions.JavaCast<Com.Amazon.Ags.Api.IRequestResponse>(p0));
		}

	}
}
