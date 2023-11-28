using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Chad.Library.Adapter.Base.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/interface[@name='OnItemSwipeListener']"
	[Register ("com/chad/library/adapter/base/listener/OnItemSwipeListener", "", "Com.Chad.Library.Adapter.Base.Listener.IOnItemSwipeListenerInvoker")]
	public partial interface IOnItemSwipeListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/interface[@name='OnItemSwipeListener']/method[@name='clearView' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
		[Register ("clearView", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetClearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler:Com.Chad.Library.Adapter.Base.Listener.IOnItemSwipeListenerInvoker, BindingBaseRecyclerViewAdapterHelper")]
		void ClearView (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/interface[@name='OnItemSwipeListener']/method[@name='onItemSwipeMoving' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='boolean']]"
		[Register ("onItemSwipeMoving", "(Landroid/graphics/Canvas;Landroid/support/v7/widget/RecyclerView$ViewHolder;FFZ)V", "GetOnItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZHandler:Com.Chad.Library.Adapter.Base.Listener.IOnItemSwipeListenerInvoker, BindingBaseRecyclerViewAdapterHelper")]
		void OnItemSwipeMoving (global::Android.Graphics.Canvas p0, global::Android.Support.V7.Widget.RecyclerView.ViewHolder p1, float p2, float p3, bool p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/interface[@name='OnItemSwipeListener']/method[@name='onItemSwipeStart' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
		[Register ("onItemSwipeStart", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler:Com.Chad.Library.Adapter.Base.Listener.IOnItemSwipeListenerInvoker, BindingBaseRecyclerViewAdapterHelper")]
		void OnItemSwipeStart (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/interface[@name='OnItemSwipeListener']/method[@name='onItemSwiped' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
		[Register ("onItemSwiped", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler:Com.Chad.Library.Adapter.Base.Listener.IOnItemSwipeListenerInvoker, BindingBaseRecyclerViewAdapterHelper")]
		void OnItemSwiped (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1);

	}

	[global::Android.Runtime.Register ("com/chad/library/adapter/base/listener/OnItemSwipeListener", DoNotGenerateAcw=true)]
	internal partial class IOnItemSwipeListenerInvoker : global::Java.Lang.Object, IOnItemSwipeListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/chad/library/adapter/base/listener/OnItemSwipeListener", typeof (IOnItemSwipeListenerInvoker));

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

		public static IOnItemSwipeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnItemSwipeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.chad.library.adapter.base.listener.OnItemSwipeListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnItemSwipeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_clearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
		static Delegate GetClearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler ()
		{
			if (cb_clearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == null)
				cb_clearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_ClearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_I));
			return cb_clearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		}

		static void n_ClearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.IOnItemSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearView (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_clearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		public unsafe void ClearView (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			if (id_clearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
				id_clearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "clearView", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearView_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
		}

		static Delegate cb_onItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZ;
#pragma warning disable 0169
		static Delegate GetOnItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZHandler ()
		{
			if (cb_onItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZ == null)
				cb_onItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLFFZ_V (n_OnItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZ));
			return cb_onItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZ;
		}

		static void n_OnItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3, bool p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.IOnItemSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnItemSwipeMoving (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZ;
		public unsafe void OnItemSwipeMoving (global::Android.Graphics.Canvas p0, global::Android.Support.V7.Widget.RecyclerView.ViewHolder p1, float p2, float p3, bool p4)
		{
			if (id_onItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZ == IntPtr.Zero)
				id_onItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZ = JNIEnv.GetMethodID (class_ref, "onItemSwipeMoving", "(Landroid/graphics/Canvas;Landroid/support/v7/widget/RecyclerView$ViewHolder;FFZ)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemSwipeMoving_Landroid_graphics_Canvas_Landroid_support_v7_widget_RecyclerView_ViewHolder_FFZ, __args);
		}

		static Delegate cb_onItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
		static Delegate GetOnItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler ()
		{
			if (cb_onItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == null)
				cb_onItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I));
			return cb_onItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		}

		static void n_OnItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.IOnItemSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnItemSwipeStart (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		public unsafe void OnItemSwipeStart (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			if (id_onItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
				id_onItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "onItemSwipeStart", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemSwipeStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
		}

		static Delegate cb_onItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
		static Delegate GetOnItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler ()
		{
			if (cb_onItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == null)
				cb_onItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_I));
			return cb_onItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		}

		static void n_OnItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.IOnItemSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnItemSwiped (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		public unsafe void OnItemSwiped (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			if (id_onItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
				id_onItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "onItemSwiped", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemSwiped_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
		}

	}

	// event args for com.chad.library.adapter.base.listener.OnItemSwipeListener.clearView
	public partial class ClearViewEventArgs : global::System.EventArgs {
		public ClearViewEventArgs (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0;

		public global::Android.Support.V7.Widget.RecyclerView.ViewHolder P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

	}

	// event args for com.chad.library.adapter.base.listener.OnItemSwipeListener.onItemSwipeMoving
	public partial class ItemSwipeMovingEventArgs : global::System.EventArgs {
		public ItemSwipeMovingEventArgs (global::Android.Graphics.Canvas p0, global::Android.Support.V7.Widget.RecyclerView.ViewHolder p1, float p2, float p3, bool p4)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		global::Android.Graphics.Canvas p0;

		public global::Android.Graphics.Canvas P0 {
			get { return p0; }
		}

		global::Android.Support.V7.Widget.RecyclerView.ViewHolder p1;

		public global::Android.Support.V7.Widget.RecyclerView.ViewHolder P1 {
			get { return p1; }
		}

		float p2;

		public float P2 {
			get { return p2; }
		}

		float p3;

		public float P3 {
			get { return p3; }
		}

		bool p4;

		public bool P4 {
			get { return p4; }
		}

	}

	// event args for com.chad.library.adapter.base.listener.OnItemSwipeListener.onItemSwipeStart
	public partial class ItemSwipeStartEventArgs : global::System.EventArgs {
		public ItemSwipeStartEventArgs (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0;

		public global::Android.Support.V7.Widget.RecyclerView.ViewHolder P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

	}

	// event args for com.chad.library.adapter.base.listener.OnItemSwipeListener.onItemSwiped
	public partial class ItemSwipedEventArgs : global::System.EventArgs {
		public ItemSwipedEventArgs (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0;

		public global::Android.Support.V7.Widget.RecyclerView.ViewHolder P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/chad/library/adapter/base/listener/OnItemSwipeListenerImplementor")]
	internal sealed partial class IOnItemSwipeListenerImplementor : global::Java.Lang.Object, IOnItemSwipeListener {

		object sender;

		public IOnItemSwipeListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/chad/library/adapter/base/listener/OnItemSwipeListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<ClearViewEventArgs> ClearViewHandler;
		#pragma warning restore 0649

		public void ClearView (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			var __h = ClearViewHandler;
			if (__h != null)
				__h (sender, new ClearViewEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<ItemSwipeMovingEventArgs> OnItemSwipeMovingHandler;
		#pragma warning restore 0649

		public void OnItemSwipeMoving (global::Android.Graphics.Canvas p0, global::Android.Support.V7.Widget.RecyclerView.ViewHolder p1, float p2, float p3, bool p4)
		{
			var __h = OnItemSwipeMovingHandler;
			if (__h != null)
				__h (sender, new ItemSwipeMovingEventArgs (p0, p1, p2, p3, p4));
		}

		#pragma warning disable 0649
		public EventHandler<ItemSwipeStartEventArgs> OnItemSwipeStartHandler;
		#pragma warning restore 0649

		public void OnItemSwipeStart (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			var __h = OnItemSwipeStartHandler;
			if (__h != null)
				__h (sender, new ItemSwipeStartEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<ItemSwipedEventArgs> OnItemSwipedHandler;
		#pragma warning restore 0649

		public void OnItemSwiped (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			var __h = OnItemSwipedHandler;
			if (__h != null)
				__h (sender, new ItemSwipedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnItemSwipeListenerImplementor value)
		{
			return value.ClearViewHandler == null && value.OnItemSwipeMovingHandler == null && value.OnItemSwipeStartHandler == null && value.OnItemSwipedHandler == null;
		}

	}
}
