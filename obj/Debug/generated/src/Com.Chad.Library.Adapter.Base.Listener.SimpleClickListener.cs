//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Chad.Library.Adapter.Base.Listener {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']"
	[global::Android.Runtime.Register ("com/chad/library/adapter/base/listener/SimpleClickListener", DoNotGenerateAcw=true)]
	public abstract partial class SimpleClickListener : global::Java.Lang.Object, global::Android.Support.V7.Widget.RecyclerView.IOnItemTouchListener {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/field[@name='baseQuickAdapter']"
		[Register ("baseQuickAdapter")]
		protected global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter BaseQuickAdapter {
			get {
				const string __id = "baseQuickAdapter.Lcom/chad/library/adapter/base/BaseQuickAdapter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "baseQuickAdapter.Lcom/chad/library/adapter/base/BaseQuickAdapter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				const string __id = "TAG.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "TAG.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/chad/library/adapter/base/listener/SimpleClickListener", typeof (SimpleClickListener));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SimpleClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/constructor[@name='SimpleClickListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleClickListener () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_inRangeOfView_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetInRangeOfView_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_inRangeOfView_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_inRangeOfView_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_InRangeOfView_Landroid_view_View_Landroid_view_MotionEvent_));
			return cb_inRangeOfView_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_InRangeOfView_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_ev)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.SimpleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var ev = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_ev, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InRangeOfView (view, ev);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='inRangeOfView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("inRangeOfView", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetInRangeOfView_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool InRangeOfView (global::Android.Views.View view, global::Android.Views.MotionEvent ev)
		{
			const string __id = "inRangeOfView.(Landroid/view/View;Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((ev == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ev).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (ev);
			}
		}

		static Delegate cb_onInterceptTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnInterceptTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onInterceptTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_ == null)
				cb_onInterceptTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_Z (n_OnInterceptTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_));
			return cb_onInterceptTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_;
		}

		static bool n_OnInterceptTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rv, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.SimpleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rv = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_rv, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnInterceptTouchEvent (rv, e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='onInterceptTouchEvent' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onInterceptTouchEvent", "(Landroid/support/v7/widget/RecyclerView;Landroid/view/MotionEvent;)Z", "GetOnInterceptTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnInterceptTouchEvent (global::Android.Support.V7.Widget.RecyclerView rv, global::Android.Views.MotionEvent e)
		{
			const string __id = "onInterceptTouchEvent.(Landroid/support/v7/widget/RecyclerView;Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rv == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rv).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (rv);
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_onItemChildClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnItemChildClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler ()
		{
			if (cb_onItemChildClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I == null)
				cb_onItemChildClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_V (n_OnItemChildClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I));
			return cb_onItemChildClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I;
		}

		static void n_OnItemChildClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.SimpleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnItemChildClick (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='onItemChildClick' and count(parameter)=3 and parameter[1][@type='com.chad.library.adapter.base.BaseQuickAdapter'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
		[Register ("onItemChildClick", "(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V", "GetOnItemChildClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler")]
		public abstract void OnItemChildClick (global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter p0, global::Android.Views.View p1, int p2);

		static Delegate cb_onItemChildLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnItemChildLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler ()
		{
			if (cb_onItemChildLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I == null)
				cb_onItemChildLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_V (n_OnItemChildLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I));
			return cb_onItemChildLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I;
		}

		static void n_OnItemChildLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.SimpleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnItemChildLongClick (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='onItemChildLongClick' and count(parameter)=3 and parameter[1][@type='com.chad.library.adapter.base.BaseQuickAdapter'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
		[Register ("onItemChildLongClick", "(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V", "GetOnItemChildLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler")]
		public abstract void OnItemChildLongClick (global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter p0, global::Android.Views.View p1, int p2);

		static Delegate cb_onItemClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnItemClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler ()
		{
			if (cb_onItemClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I == null)
				cb_onItemClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_V (n_OnItemClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I));
			return cb_onItemClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I;
		}

		static void n_OnItemClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.SimpleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnItemClick (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='onItemClick' and count(parameter)=3 and parameter[1][@type='com.chad.library.adapter.base.BaseQuickAdapter'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
		[Register ("onItemClick", "(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V", "GetOnItemClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler")]
		public abstract void OnItemClick (global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter p0, global::Android.Views.View p1, int p2);

		static Delegate cb_onItemLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnItemLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler ()
		{
			if (cb_onItemLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I == null)
				cb_onItemLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_V (n_OnItemLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I));
			return cb_onItemLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I;
		}

		static void n_OnItemLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.SimpleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnItemLongClick (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='onItemLongClick' and count(parameter)=3 and parameter[1][@type='com.chad.library.adapter.base.BaseQuickAdapter'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
		[Register ("onItemLongClick", "(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V", "GetOnItemLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler")]
		public abstract void OnItemLongClick (global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter p0, global::Android.Views.View p1, int p2);

		static Delegate cb_onRequestDisallowInterceptTouchEvent_Z;
#pragma warning disable 0169
		static Delegate GetOnRequestDisallowInterceptTouchEvent_ZHandler ()
		{
			if (cb_onRequestDisallowInterceptTouchEvent_Z == null)
				cb_onRequestDisallowInterceptTouchEvent_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_OnRequestDisallowInterceptTouchEvent_Z));
			return cb_onRequestDisallowInterceptTouchEvent_Z;
		}

		static void n_OnRequestDisallowInterceptTouchEvent_Z (IntPtr jnienv, IntPtr native__this, bool disallowIntercept)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.SimpleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestDisallowInterceptTouchEvent (disallowIntercept);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='onRequestDisallowInterceptTouchEvent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onRequestDisallowInterceptTouchEvent", "(Z)V", "GetOnRequestDisallowInterceptTouchEvent_ZHandler")]
		public virtual unsafe void OnRequestDisallowInterceptTouchEvent (bool disallowIntercept)
		{
			const string __id = "onRequestDisallowInterceptTouchEvent.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (disallowIntercept);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_));
			return cb_onTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_;
		}

		static void n_OnTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rv, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.SimpleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rv = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_rv, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnTouchEvent (rv, e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='onTouchEvent' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/support/v7/widget/RecyclerView;Landroid/view/MotionEvent;)V", "GetOnTouchEvent_Landroid_support_v7_widget_RecyclerView_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void OnTouchEvent (global::Android.Support.V7.Widget.RecyclerView rv, global::Android.Views.MotionEvent e)
		{
			const string __id = "onTouchEvent.(Landroid/support/v7/widget/RecyclerView;Landroid/view/MotionEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rv == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rv).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (rv);
				global::System.GC.KeepAlive (e);
			}
		}

	}

	[global::Android.Runtime.Register ("com/chad/library/adapter/base/listener/SimpleClickListener", DoNotGenerateAcw=true)]
	internal partial class SimpleClickListenerInvoker : SimpleClickListener {
		public SimpleClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/chad/library/adapter/base/listener/SimpleClickListener", typeof (SimpleClickListenerInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='onItemChildClick' and count(parameter)=3 and parameter[1][@type='com.chad.library.adapter.base.BaseQuickAdapter'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
		[Register ("onItemChildClick", "(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V", "GetOnItemChildClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler")]
		public override unsafe void OnItemChildClick (global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter p0, global::Android.Views.View p1, int p2)
		{
			const string __id = "onItemChildClick.(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='onItemChildLongClick' and count(parameter)=3 and parameter[1][@type='com.chad.library.adapter.base.BaseQuickAdapter'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
		[Register ("onItemChildLongClick", "(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V", "GetOnItemChildLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler")]
		public override unsafe void OnItemChildLongClick (global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter p0, global::Android.Views.View p1, int p2)
		{
			const string __id = "onItemChildLongClick.(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='onItemClick' and count(parameter)=3 and parameter[1][@type='com.chad.library.adapter.base.BaseQuickAdapter'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
		[Register ("onItemClick", "(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V", "GetOnItemClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler")]
		public override unsafe void OnItemClick (global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter p0, global::Android.Views.View p1, int p2)
		{
			const string __id = "onItemClick.(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/class[@name='SimpleClickListener']/method[@name='onItemLongClick' and count(parameter)=3 and parameter[1][@type='com.chad.library.adapter.base.BaseQuickAdapter'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int']]"
		[Register ("onItemLongClick", "(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V", "GetOnItemLongClick_Lcom_chad_library_adapter_base_BaseQuickAdapter_Landroid_view_View_IHandler")]
		public override unsafe void OnItemLongClick (global::Com.Chad.Library.Adapter.Base.BaseQuickAdapter p0, global::Android.Views.View p1, int p2)
		{
			const string __id = "onItemLongClick.(Lcom/chad/library/adapter/base/BaseQuickAdapter;Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
