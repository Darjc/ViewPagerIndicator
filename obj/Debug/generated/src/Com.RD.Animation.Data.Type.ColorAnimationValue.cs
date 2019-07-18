using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Data.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ColorAnimationValue']"
	[global::Android.Runtime.Register ("com/rd/animation/data/type/ColorAnimationValue", DoNotGenerateAcw=true)]
	public partial class ColorAnimationValue : global::Java.Lang.Object, global::Com.RD.Animation.Data.IValue {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/data/type/ColorAnimationValue", typeof (ColorAnimationValue));
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

		protected ColorAnimationValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ColorAnimationValue']/constructor[@name='ColorAnimationValue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColorAnimationValue ()
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

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.Type.ColorAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.ColorAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.RD.Animation.Data.Type.ColorAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.ColorAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Color = color;
		}
#pragma warning restore 0169

		public virtual unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ColorAnimationValue']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				const string __id = "getColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ColorAnimationValue']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
			set {
				const string __id = "setColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getColorReverse;
#pragma warning disable 0169
		static Delegate GetGetColorReverseHandler ()
		{
			if (cb_getColorReverse == null)
				cb_getColorReverse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColorReverse);
			return cb_getColorReverse;
		}

		static int n_GetColorReverse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.Type.ColorAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.ColorAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColorReverse;
		}
#pragma warning restore 0169

		static Delegate cb_setColorReverse_I;
#pragma warning disable 0169
		static Delegate GetSetColorReverse_IHandler ()
		{
			if (cb_setColorReverse_I == null)
				cb_setColorReverse_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColorReverse_I);
			return cb_setColorReverse_I;
		}

		static void n_SetColorReverse_I (IntPtr jnienv, IntPtr native__this, int colorReverse)
		{
			global::Com.RD.Animation.Data.Type.ColorAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.ColorAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ColorReverse = colorReverse;
		}
#pragma warning restore 0169

		public virtual unsafe int ColorReverse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ColorAnimationValue']/method[@name='getColorReverse' and count(parameter)=0]"
			[Register ("getColorReverse", "()I", "GetGetColorReverseHandler")]
			get {
				const string __id = "getColorReverse.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ColorAnimationValue']/method[@name='setColorReverse' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColorReverse", "(I)V", "GetSetColorReverse_IHandler")]
			set {
				const string __id = "setColorReverse.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
