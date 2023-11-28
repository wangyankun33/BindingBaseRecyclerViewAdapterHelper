using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Chad.Library.Adapter.Base.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/interface[@name='OnItemDragListener']"
	[Register ("com/chad/library/adapter/base/listener/OnItemDragListener", "", "Com.Chad.Library.Adapter.Base.Listener.IOnItemDragListenerInvoker")]
	public partial interface IOnItemDragListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/interface[@name='OnItemDragListener']/method[@name='onItemDragEnd' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
		[Register ("onItemDragEnd", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler:Com.Chad.Library.Adapter.Base.Listener.IOnItemDragListenerInvoker, BindingBaseRecyclerViewAdapterHelper")]
		void OnItemDragEnd (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/interface[@name='OnItemDragListener']/method[@name='onItemDragMoving' and count(parameter)=4 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int'] and parameter[3][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[4][@type='int']]"
		[Register ("onItemDragMoving", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;ILandroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_IHandler:Com.Chad.Library.Adapter.Base.Listener.IOnItemDragListenerInvoker, BindingBaseRecyclerViewAdapterHelper")]
		void OnItemDragMoving (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1, global::Android.Support.V7.Widget.RecyclerView.ViewHolder p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.listener']/interface[@name='OnItemDragListener']/method[@name='onItemDragStart' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
		[Register ("onItemDragStart", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler:Com.Chad.Library.Adapter.Base.Listener.IOnItemDragListenerInvoker, BindingBaseRecyclerViewAdapterHelper")]
		void OnItemDragStart (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1);

	}

	[global::Android.Runtime.Register ("com/chad/library/adapter/base/listener/OnItemDragListener", DoNotGenerateAcw=true)]
	internal partial class IOnItemDragListenerInvoker : global::Java.Lang.Object, IOnItemDragListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/chad/library/adapter/base/listener/OnItemDragListener", typeof (IOnItemDragListenerInvoker));

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

		public static IOnItemDragListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnItemDragListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.chad.library.adapter.base.listener.OnItemDragListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnItemDragListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
		static Delegate GetOnItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler ()
		{
			if (cb_onItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == null)
				cb_onItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_I));
			return cb_onItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		}

		static void n_OnItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.IOnItemDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnItemDragEnd (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		public unsafe void OnItemDragEnd (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			if (id_onItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
				id_onItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "onItemDragEnd", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemDragEnd_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
		}

		static Delegate cb_onItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
		static Delegate GetOnItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_IHandler ()
		{
			if (cb_onItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_I == null)
				cb_onItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLILI_V (n_OnItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_I));
			return cb_onItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_I;
		}

		static void n_OnItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.IOnItemDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnItemDragMoving (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_I;
		public unsafe void OnItemDragMoving (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1, global::Android.Support.V7.Widget.RecyclerView.ViewHolder p2, int p3)
		{
			if (id_onItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
				id_onItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "onItemDragMoving", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;ILandroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemDragMoving_Landroid_support_v7_widget_RecyclerView_ViewHolder_ILandroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
		}

		static Delegate cb_onItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
		static Delegate GetOnItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler ()
		{
			if (cb_onItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == null)
				cb_onItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_OnItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I));
			return cb_onItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		}

		static void n_OnItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Listener.IOnItemDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnItemDragStart (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		public unsafe void OnItemDragStart (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			if (id_onItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
				id_onItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "onItemDragStart", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemDragStart_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
		}

	}

	// event args for com.chad.library.adapter.base.listener.OnItemDragListener.onItemDragEnd
	public partial class ItemDragEndEventArgs : global::System.EventArgs {
		public ItemDragEndEventArgs (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
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

	// event args for com.chad.library.adapter.base.listener.OnItemDragListener.onItemDragMoving
	public partial class ItemDragMovingEventArgs : global::System.EventArgs {
		public ItemDragMovingEventArgs (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1, global::Android.Support.V7.Widget.RecyclerView.ViewHolder p2, int p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0;

		public global::Android.Support.V7.Widget.RecyclerView.ViewHolder P0 {
			get { return p0; }
		}

		int p1;

		public int P1 {
			get { return p1; }
		}

		global::Android.Support.V7.Widget.RecyclerView.ViewHolder p2;

		public global::Android.Support.V7.Widget.RecyclerView.ViewHolder P2 {
			get { return p2; }
		}

		int p3;

		public int P3 {
			get { return p3; }
		}

	}

	// event args for com.chad.library.adapter.base.listener.OnItemDragListener.onItemDragStart
	public partial class ItemDragStartEventArgs : global::System.EventArgs {
		public ItemDragStartEventArgs (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
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

	[global::Android.Runtime.Register ("mono/com/chad/library/adapter/base/listener/OnItemDragListenerImplementor")]
	internal sealed partial class IOnItemDragListenerImplementor : global::Java.Lang.Object, IOnItemDragListener {

		object sender;

		public IOnItemDragListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/chad/library/adapter/base/listener/OnItemDragListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<ItemDragEndEventArgs> OnItemDragEndHandler;
		#pragma warning restore 0649

		public void OnItemDragEnd (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			var __h = OnItemDragEndHandler;
			if (__h != null)
				__h (sender, new ItemDragEndEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<ItemDragMovingEventArgs> OnItemDragMovingHandler;
		#pragma warning restore 0649

		public void OnItemDragMoving (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1, global::Android.Support.V7.Widget.RecyclerView.ViewHolder p2, int p3)
		{
			var __h = OnItemDragMovingHandler;
			if (__h != null)
				__h (sender, new ItemDragMovingEventArgs (p0, p1, p2, p3));
		}

		#pragma warning disable 0649
		public EventHandler<ItemDragStartEventArgs> OnItemDragStartHandler;
		#pragma warning restore 0649

		public void OnItemDragStart (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			var __h = OnItemDragStartHandler;
			if (__h != null)
				__h (sender, new ItemDragStartEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnItemDragListenerImplementor value)
		{
			return value.OnItemDragEndHandler == null && value.OnItemDragMovingHandler == null && value.OnItemDragStartHandler == null;
		}

	}
}
