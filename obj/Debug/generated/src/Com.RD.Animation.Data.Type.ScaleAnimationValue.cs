using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Data.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ScaleAnimationValue']"
	[global::Android.Runtime.Register ("com/rd/animation/data/type/ScaleAnimationValue", DoNotGenerateAcw=true)]
	public partial class ScaleAnimationValue : global::Com.RD.Animation.Data.Type.ColorAnimationValue, global::Com.RD.Animation.Data.IValue {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/data/type/ScaleAnimationValue", typeof (ScaleAnimationValue));
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

		protected ScaleAnimationValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ScaleAnimationValue']/constructor[@name='ScaleAnimationValue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScaleAnimationValue ()
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
			global::Com.RD.Animation.Data.Type.ScaleAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.ScaleAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.RD.Animation.Data.Type.ScaleAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.ScaleAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = radius;
		}
#pragma warning restore 0169

		public virtual unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ScaleAnimationValue']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ScaleAnimationValue']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.RD.Animation.Data.Type.ScaleAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.ScaleAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.RD.Animation.Data.Type.ScaleAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.ScaleAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RadiusReverse = radiusReverse;
		}
#pragma warning restore 0169

		public virtual unsafe int RadiusReverse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ScaleAnimationValue']/method[@name='getRadiusReverse' and count(parameter)=0]"
			[Register ("getRadiusReverse", "()I", "GetGetRadiusReverseHandler")]
			get {
				const string __id = "getRadiusReverse.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='ScaleAnimationValue']/method[@name='setRadiusReverse' and count(parameter)=1 and parameter[1][@type='int']]"
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

	}
}
