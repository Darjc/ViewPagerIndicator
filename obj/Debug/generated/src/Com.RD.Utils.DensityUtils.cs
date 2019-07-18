using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.utils']/class[@name='DensityUtils']"
	[global::Android.Runtime.Register ("com/rd/utils/DensityUtils", DoNotGenerateAcw=true)]
	public partial class DensityUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/utils/DensityUtils", typeof (DensityUtils));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected DensityUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.utils']/class[@name='DensityUtils']/constructor[@name='DensityUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DensityUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.utils']/class[@name='DensityUtils']/method[@name='dpToPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("dpToPx", "(I)I", "")]
		public static unsafe int DpToPx (int dp)
		{
			const string __id = "dpToPx.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dp);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.utils']/class[@name='DensityUtils']/method[@name='pxToDp' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("pxToDp", "(F)I", "")]
		public static unsafe int PxToDp (float px)
		{
			const string __id = "pxToDp.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
