using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']"
	[global::Android.Runtime.Register ("com/rd/animation/type/AnimationType", DoNotGenerateAcw=true)]
	public sealed partial class AnimationType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/field[@name='COLOR']"
		[Register ("COLOR")]
		public static global::Com.RD.Animation.Type.AnimationType Color {
			get {
				const string __id = "COLOR.Lcom/rd/animation/type/AnimationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/field[@name='DROP']"
		[Register ("DROP")]
		public static global::Com.RD.Animation.Type.AnimationType Drop {
			get {
				const string __id = "DROP.Lcom/rd/animation/type/AnimationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/field[@name='FILL']"
		[Register ("FILL")]
		public static global::Com.RD.Animation.Type.AnimationType Fill {
			get {
				const string __id = "FILL.Lcom/rd/animation/type/AnimationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.RD.Animation.Type.AnimationType None {
			get {
				const string __id = "NONE.Lcom/rd/animation/type/AnimationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/field[@name='SCALE']"
		[Register ("SCALE")]
		public static global::Com.RD.Animation.Type.AnimationType Scale {
			get {
				const string __id = "SCALE.Lcom/rd/animation/type/AnimationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/field[@name='SCALE_DOWN']"
		[Register ("SCALE_DOWN")]
		public static global::Com.RD.Animation.Type.AnimationType ScaleDown {
			get {
				const string __id = "SCALE_DOWN.Lcom/rd/animation/type/AnimationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/field[@name='SLIDE']"
		[Register ("SLIDE")]
		public static global::Com.RD.Animation.Type.AnimationType Slide {
			get {
				const string __id = "SLIDE.Lcom/rd/animation/type/AnimationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/field[@name='SWAP']"
		[Register ("SWAP")]
		public static global::Com.RD.Animation.Type.AnimationType Swap {
			get {
				const string __id = "SWAP.Lcom/rd/animation/type/AnimationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/field[@name='THIN_WORM']"
		[Register ("THIN_WORM")]
		public static global::Com.RD.Animation.Type.AnimationType ThinWorm {
			get {
				const string __id = "THIN_WORM.Lcom/rd/animation/type/AnimationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/field[@name='WORM']"
		[Register ("WORM")]
		public static global::Com.RD.Animation.Type.AnimationType Worm {
			get {
				const string __id = "WORM.Lcom/rd/animation/type/AnimationType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/type/AnimationType", typeof (AnimationType));
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

		internal AnimationType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/rd/animation/type/AnimationType;", "")]
		public static unsafe global::Com.RD.Animation.Type.AnimationType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/rd/animation/type/AnimationType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='AnimationType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/rd/animation/type/AnimationType;", "")]
		public static unsafe global::Com.RD.Animation.Type.AnimationType[] Values ()
		{
			const string __id = "values.()[Lcom/rd/animation/type/AnimationType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.RD.Animation.Type.AnimationType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.RD.Animation.Type.AnimationType));
			} finally {
			}
		}

	}
}
