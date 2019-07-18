using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Data.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='FillAnimationValue']"
	[global::Android.Runtime.Register ("com/rd/animation/data/type/FillAnimationValue", DoNotGenerateAcw=true)]
	public partial class FillAnimationValue : global::Com.RD.Animation.Data.Type.ColorAnimationValue, global::Com.RD.Animation.Data.IValue {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/data/type/FillAnimationValue", typeof (FillAnimationValue));
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

		protected FillAnimationValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='FillAnimationValue']/constructor[@name='FillAnimationValue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FillAnimationValue ()
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

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRadius);
			return cb_getRadius;
		}

		static int n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.Type.FillAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.FillAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		static Delegate cb_setRadius_I;
#pragma warning disable 0169
		static Delegate GetSetRadius_IHandler ()
		{
			if (cb_setRadius_I == null)
				cb_setRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRadius_I);
			return cb_setRadius_I;
		}

		static void n_SetRadius_I (IntPtr jnienv, IntPtr native__this, int radius)
		{
			global::Com.RD.Animation.Data.Type.FillAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.FillAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = radius;
		}
#pragma warning restore 0169

		public virtual unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='FillAnimationValue']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='FillAnimationValue']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRadius", "(I)V", "GetSetRadius_IHandler")]
			set {
				const string __id = "setRadius.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRadiusReverse;
#pragma warning disable 0169
		static Delegate GetGetRadiusReverseHandler ()
		{
			if (cb_getRadiusReverse == null)
				cb_getRadiusReverse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRadiusReverse);
			return cb_getRadiusReverse;
		}

		static int n_GetRadiusReverse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.Type.FillAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.FillAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RadiusReverse;
		}
#pragma warning restore 0169

		static Delegate cb_setRadiusReverse_I;
#pragma warning disable 0169
		static Delegate GetSetRadiusReverse_IHandler ()
		{
			if (cb_setRadiusReverse_I == null)
				cb_setRadiusReverse_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRadiusReverse_I);
			return cb_setRadiusReverse_I;
		}

		static void n_SetRadiusReverse_I (IntPtr jnienv, IntPtr native__this, int radiusReverse)
		{
			global::Com.RD.Animation.Data.Type.FillAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.FillAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RadiusReverse = radiusReverse;
		}
#pragma warning restore 0169

		public virtual unsafe int RadiusReverse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='FillAnimationValue']/method[@name='getRadiusReverse' and count(parameter)=0]"
			[Register ("getRadiusReverse", "()I", "GetGetRadiusReverseHandler")]
			get {
				const string __id = "getRadiusReverse.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='FillAnimationValue']/method[@name='setRadiusReverse' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRadiusReverse", "(I)V", "GetSetRadiusReverse_IHandler")]
			set {
				const string __id = "setRadiusReverse.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStroke;
#pragma warning disable 0169
		static Delegate GetGetStrokeHandler ()
		{
			if (cb_getStroke == null)
				cb_getStroke = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStroke);
			return cb_getStroke;
		}

		static int n_GetStroke (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.Type.FillAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.FillAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Stroke;
		}
#pragma warning restore 0169

		static Delegate cb_setStroke_I;
#pragma warning disable 0169
		static Delegate GetSetStroke_IHandler ()
		{
			if (cb_setStroke_I == null)
				cb_setStroke_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStroke_I);
			return cb_setStroke_I;
		}

		static void n_SetStroke_I (IntPtr jnienv, IntPtr native__this, int stroke)
		{
			global::Com.RD.Animation.Data.Type.FillAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.FillAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stroke = stroke;
		}
#pragma warning restore 0169

		public virtual unsafe int Stroke {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='FillAnimationValue']/method[@name='getStroke' and count(parameter)=0]"
			[Register ("getStroke", "()I", "GetGetStrokeHandler")]
			get {
				const string __id = "getStroke.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='FillAnimationValue']/method[@name='setStroke' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStroke", "(I)V", "GetSetStroke_IHandler")]
			set {
				const string __id = "setStroke.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStrokeReverse;
#pragma warning disable 0169
		static Delegate GetGetStrokeReverseHandler ()
		{
			if (cb_getStrokeReverse == null)
				cb_getStrokeReverse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrokeReverse);
			return cb_getStrokeReverse;
		}

		static int n_GetStrokeReverse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.Type.FillAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.FillAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeReverse;
		}
#pragma warning restore 0169

		static Delegate cb_setStrokeReverse_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeReverse_IHandler ()
		{
			if (cb_setStrokeReverse_I == null)
				cb_setStrokeReverse_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStrokeReverse_I);
			return cb_setStrokeReverse_I;
		}

		static void n_SetStrokeReverse_I (IntPtr jnienv, IntPtr native__this, int strokeReverse)
		{
			global::Com.RD.Animation.Data.Type.FillAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.FillAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrokeReverse = strokeReverse;
		}
#pragma warning restore 0169

		public virtual unsafe int StrokeReverse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='FillAnimationValue']/method[@name='getStrokeReverse' and count(parameter)=0]"
			[Register ("getStrokeReverse", "()I", "GetGetStrokeReverseHandler")]
			get {
				const string __id = "getStrokeReverse.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='FillAnimationValue']/method[@name='setStrokeReverse' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrokeReverse", "(I)V", "GetSetStrokeReverse_IHandler")]
			set {
				const string __id = "setStrokeReverse.(I)V";
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
