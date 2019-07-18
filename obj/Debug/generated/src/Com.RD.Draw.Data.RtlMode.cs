using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw.data']/class[@name='RtlMode']"
	[global::Android.Runtime.Register ("com/rd/draw/data/RtlMode", DoNotGenerateAcw=true)]
	public sealed partial class RtlMode : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.data']/class[@name='RtlMode']/field[@name='Auto']"
		[Register ("Auto")]
		public static global::Com.RD.Draw.Data.RtlMode Auto {
			get {
				const string __id = "Auto.Lcom/rd/draw/data/RtlMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.RtlMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.data']/class[@name='RtlMode']/field[@name='Off']"
		[Register ("Off")]
		public static global::Com.RD.Draw.Data.RtlMode Off {
			get {
				const string __id = "Off.Lcom/rd/draw/data/RtlMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.RtlMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.data']/class[@name='RtlMode']/field[@name='On']"
		[Register ("On")]
		public static global::Com.RD.Draw.Data.RtlMode On {
			get {
				const string __id = "On.Lcom/rd/draw/data/RtlMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.RtlMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/data/RtlMode", typeof (RtlMode));
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

		internal RtlMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='RtlMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/rd/draw/data/RtlMode;", "")]
		public static unsafe global::Com.RD.Draw.Data.RtlMode ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/rd/draw/data/RtlMode;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.RtlMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='RtlMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/rd/draw/data/RtlMode;", "")]
		public static unsafe global::Com.RD.Draw.Data.RtlMode[] Values ()
		{
			const string __id = "values.()[Lcom/rd/draw/data/RtlMode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.RD.Draw.Data.RtlMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.RD.Draw.Data.RtlMode));
			} finally {
			}
		}

	}
}
