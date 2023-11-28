using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.chad.library", Managed="Com.Chad.Library")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.chad.library.adapter.base", Managed="Com.Chad.Library.Adapter.Base")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.chad.library.adapter.base.animation", Managed="Com.Chad.Library.Adapter.Base.Animation")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.chad.library.adapter.base.callback", Managed="Com.Chad.Library.Adapter.Base.Callback")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.chad.library.adapter.base.entity", Managed="Com.Chad.Library.Adapter.Base.Entity")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.chad.library.adapter.base.listener", Managed="Com.Chad.Library.Adapter.Base.Listener")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.chad.library.adapter.base.loadmore", Managed="Com.Chad.Library.Adapter.Base.Loadmore")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.chad.library.adapter.base.util", Managed="Com.Chad.Library.Adapter.Base.Util")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPF_V (IntPtr jnienv, IntPtr klass, float p0);
delegate int _JniMarshal_PPI_I (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate bool _JniMarshal_PPI_Z (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPIF_L (IntPtr jnienv, IntPtr klass, int p0, float p1);
delegate IntPtr _JniMarshal_PPIFI_L (IntPtr jnienv, IntPtr klass, int p0, float p1, int p2);
delegate IntPtr _JniMarshal_PPII_L (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate void _JniMarshal_PPII_V (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate IntPtr _JniMarshal_PPIII_L (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2);
delegate IntPtr _JniMarshal_PPIIL_L (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPIL_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate int _JniMarshal_PPIZ_I (IntPtr jnienv, IntPtr klass, int p0, bool p1);
delegate IntPtr _JniMarshal_PPIZ_L (IntPtr jnienv, IntPtr klass, int p0, bool p1);
delegate int _JniMarshal_PPIZZ_I (IntPtr jnienv, IntPtr klass, int p0, bool p1, bool p2);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate int _JniMarshal_PPLI_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate IntPtr _JniMarshal_PPLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate bool _JniMarshal_PPLI_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate int _JniMarshal_PPLII_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate IntPtr _JniMarshal_PPLII_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate void _JniMarshal_PPLILI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, int p3);
delegate void _JniMarshal_PPLIZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, bool p2);
delegate int _JniMarshal_PPLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLFFZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, float p2, float p3, bool p4);
delegate void _JniMarshal_PPLLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate bool _JniMarshal_PPLLI_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate bool _JniMarshal_PPLLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZZ_V (IntPtr jnienv, IntPtr klass, bool p0, bool p1);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

