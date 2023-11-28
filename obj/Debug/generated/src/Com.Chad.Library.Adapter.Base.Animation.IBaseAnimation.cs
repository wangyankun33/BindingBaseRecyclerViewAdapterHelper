using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Chad.Library.Adapter.Base.Animation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.chad.library.adapter.base.animation']/interface[@name='BaseAnimation']"
	[Register ("com/chad/library/adapter/base/animation/BaseAnimation", "", "Com.Chad.Library.Adapter.Base.Animation.IBaseAnimationInvoker")]
	public partial interface IBaseAnimation : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.animation']/interface[@name='BaseAnimation']/method[@name='getAnimators' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getAnimators", "(Landroid/view/View;)[Landroid/animation/Animator;", "GetGetAnimators_Landroid_view_View_Handler:Com.Chad.Library.Adapter.Base.Animation.IBaseAnimationInvoker, BindingBaseRecyclerViewAdapterHelper")]
		global::Android.Animation.Animator[] GetAnimators (global::Android.Views.View p0);

	}

	[global::Android.Runtime.Register ("com/chad/library/adapter/base/animation/BaseAnimation", DoNotGenerateAcw=true)]
	internal partial class IBaseAnimationInvoker : global::Java.Lang.Object, IBaseAnimation {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/chad/library/adapter/base/animation/BaseAnimation", typeof (IBaseAnimationInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IBaseAnimation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBaseAnimation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.chad.library.adapter.base.animation.BaseAnimation'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBaseAnimationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAnimators_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetAnimators_Landroid_view_View_Handler ()
		{
			if (cb_getAnimators_Landroid_view_View_ == null)
				cb_getAnimators_Landroid_view_View_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GetAnimators_Landroid_view_View_));
			return cb_getAnimators_Landroid_view_View_;
		}

		static IntPtr n_GetAnimators_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Animation.IBaseAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetAnimators (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAnimators_Landroid_view_View_;
		public unsafe global::Android.Animation.Animator[] GetAnimators (global::Android.Views.View p0)
		{
			if (id_getAnimators_Landroid_view_View_ == IntPtr.Zero)
				id_getAnimators_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getAnimators", "(Landroid/view/View;)[Landroid/animation/Animator;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = (global::Android.Animation.Animator[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnimators_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Android.Animation.Animator));
			return __ret;
		}

	}
}
