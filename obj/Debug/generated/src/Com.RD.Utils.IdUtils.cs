using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.utils']/class[@name='IdUtils']"
	[global::Android.Runtime.Register ("com/rd/utils/IdUtils", DoNotGenerateAcw=true)]
	public partial class IdUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/utils/IdUtils", typeof (IdUtils));
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

		protected IdUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.utils']/class[@name='IdUtils']/constructor[@name='IdUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IdUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.utils']/class[@name='IdUtils']/method[@name='generateViewId' and count(parameter)=0]"
		[Register ("generateViewId", "()I", "")]
		public static unsafe int GenerateViewId ()
		{
			const string __id = "generateViewId.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

	}
}
