using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Chad.Library.Adapter.Base.Entity {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.chad.library.adapter.base.entity']/interface[@name='IExpandable']"
	[Register ("com/chad/library/adapter/base/entity/IExpandable", "", "Com.Chad.Library.Adapter.Base.Entity.IExpandableInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IExpandable : IJavaObject, IJavaPeerable {
		bool Expanded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.entity']/interface[@name='IExpandable']/method[@name='isExpanded' and count(parameter)=0]"
			[Register ("isExpanded", "()Z", "GetIsExpandedHandler:Com.Chad.Library.Adapter.Base.Entity.IExpandableInvoker, BindingBaseRecyclerViewAdapterHelper")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.entity']/interface[@name='IExpandable']/method[@name='setExpanded' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExpanded", "(Z)V", "GetSetExpanded_ZHandler:Com.Chad.Library.Adapter.Base.Entity.IExpandableInvoker, BindingBaseRecyclerViewAdapterHelper")]
			set; 
		}

		int Level {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.entity']/interface[@name='IExpandable']/method[@name='getLevel' and count(parameter)=0]"
			[Register ("getLevel", "()I", "GetGetLevelHandler:Com.Chad.Library.Adapter.Base.Entity.IExpandableInvoker, BindingBaseRecyclerViewAdapterHelper")]
			get; 
		}

		global::System.Collections.IList SubItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.entity']/interface[@name='IExpandable']/method[@name='getSubItems' and count(parameter)=0]"
			[Register ("getSubItems", "()Ljava/util/List;", "GetGetSubItemsHandler:Com.Chad.Library.Adapter.Base.Entity.IExpandableInvoker, BindingBaseRecyclerViewAdapterHelper")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/chad/library/adapter/base/entity/IExpandable", DoNotGenerateAcw=true)]
	internal partial class IExpandableInvoker : global::Java.Lang.Object, IExpandable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/chad/library/adapter/base/entity/IExpandable", typeof (IExpandableInvoker));

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

		public static IExpandable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExpandable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.chad.library.adapter.base.entity.IExpandable'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExpandableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isExpanded;
#pragma warning disable 0169
		static Delegate GetIsExpandedHandler ()
		{
			if (cb_isExpanded == null)
				cb_isExpanded = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsExpanded));
			return cb_isExpanded;
		}

		static bool n_IsExpanded (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Entity.IExpandable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Expanded;
		}
#pragma warning restore 0169

		static Delegate cb_setExpanded_Z;
#pragma warning disable 0169
		static Delegate GetSetExpanded_ZHandler ()
		{
			if (cb_setExpanded_Z == null)
				cb_setExpanded_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_SetExpanded_Z));
			return cb_setExpanded_Z;
		}

		static void n_SetExpanded_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Entity.IExpandable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Expanded = p0;
		}
#pragma warning restore 0169

		IntPtr id_isExpanded;
		IntPtr id_setExpanded_Z;
		public unsafe bool Expanded {
			get {
				if (id_isExpanded == IntPtr.Zero)
					id_isExpanded = JNIEnv.GetMethodID (class_ref, "isExpanded", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExpanded);
			}
			set {
				if (id_setExpanded_Z == IntPtr.Zero)
					id_setExpanded_Z = JNIEnv.GetMethodID (class_ref, "setExpanded", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExpanded_Z, __args);
			}
		}

		static Delegate cb_getLevel;
#pragma warning disable 0169
		static Delegate GetGetLevelHandler ()
		{
			if (cb_getLevel == null)
				cb_getLevel = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetLevel));
			return cb_getLevel;
		}

		static int n_GetLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Entity.IExpandable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Level;
		}
#pragma warning restore 0169

		IntPtr id_getLevel;
		public unsafe int Level {
			get {
				if (id_getLevel == IntPtr.Zero)
					id_getLevel = JNIEnv.GetMethodID (class_ref, "getLevel", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLevel);
			}
		}

		static Delegate cb_getSubItems;
#pragma warning disable 0169
		static Delegate GetGetSubItemsHandler ()
		{
			if (cb_getSubItems == null)
				cb_getSubItems = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSubItems));
			return cb_getSubItems;
		}

		static IntPtr n_GetSubItems (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Entity.IExpandable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.SubItems);
		}
#pragma warning restore 0169

		IntPtr id_getSubItems;
		public unsafe global::System.Collections.IList SubItems {
			get {
				if (id_getSubItems == IntPtr.Zero)
					id_getSubItems = JNIEnv.GetMethodID (class_ref, "getSubItems", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubItems), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
