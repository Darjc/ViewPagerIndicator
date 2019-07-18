using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Orientation']"
	[global::Android.Runtime.Register ("com/rd/draw/data/Orientation", DoNotGenerateAcw=true)]
	public sealed partial class Orientation : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Orientation']/field[@name='HORIZONTAL']"
		[Register ("HORIZONTAL")]
		public static global::Com.RD.Draw.Data.Orientation Horizontal {
			get {
				const string __id = "HORIZONTAL.Lcom/rd/draw/data/Orientation;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Orientation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Orientation']/field[@name='VERTICAL']"
		[Register ("VERTICAL")]
		public static global::Com.RD.Draw.Data.Orientation Vertical {
			get {
				const string __id = "VERTICAL.Lcom/rd/draw/data/Orientation;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Orientation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/data/Orientation", typeof (Orientation));
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

		internal Orientation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Orientation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/rd/draw/data/Orientation;", "")]
		public static unsafe global::Com.RD.Draw.Data.Orientation ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/rd/draw/data/Orientation;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Orientation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Orientation']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/rd/draw/data/Orientation;", "")]
		public static unsafe global::Com.RD.Draw.Data.Orientation[] Values ()
		{
			const string __id = "values.()[Lcom/rd/draw/data/Orientation;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.RD.Draw.Data.Orientation[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.RD.Draw.Data.Orientation));
			} finally {
			}
		}

	}
}
