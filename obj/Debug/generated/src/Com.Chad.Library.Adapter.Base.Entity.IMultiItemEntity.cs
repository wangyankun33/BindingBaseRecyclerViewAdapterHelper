using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Chad.Library.Adapter.Base.Entity {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.chad.library.adapter.base.entity']/interface[@name='MultiItemEntity']"
	[Register ("com/chad/library/adapter/base/entity/MultiItemEntity", "", "Com.Chad.Library.Adapter.Base.Entity.IMultiItemEntityInvoker")]
	public partial interface IMultiItemEntity : IJavaObject, IJavaPeerable {
		int ItemType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.chad.library.adapter.base.entity']/interface[@name='MultiItemEntity']/method[@name='getItemType' and count(parameter)=0]"
			[Register ("getItemType", "()I", "GetGetItemTypeHandler:Com.Chad.Library.Adapter.Base.Entity.IMultiItemEntityInvoker, BindingBaseRecyclerViewAdapterHelper")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/chad/library/adapter/base/entity/MultiItemEntity", DoNotGenerateAcw=true)]
	internal partial class IMultiItemEntityInvoker : global::Java.Lang.Object, IMultiItemEntity {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/chad/library/adapter/base/entity/MultiItemEntity", typeof (IMultiItemEntityInvoker));

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

		public static IMultiItemEntity GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMultiItemEntity> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.chad.library.adapter.base.entity.MultiItemEntity'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMultiItemEntityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getItemType;
#pragma warning disable 0169
		static Delegate GetGetItemTypeHandler ()
		{
			if (cb_getItemType == null)
				cb_getItemType = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_GetItemType));
			return cb_getItemType;
		}

		static int n_GetItemType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Chad.Library.Adapter.Base.Entity.IMultiItemEntity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemType;
		}
#pragma warning restore 0169

		IntPtr id_getItemType;
		public unsafe int ItemType {
			get {
				if (id_getItemType == IntPtr.Zero)
					id_getItemType = JNIEnv.GetMethodID (class_ref, "getItemType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemType);
			}
		}

	}
}
