using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Data.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='SwapAnimationValue']"
	[global::Android.Runtime.Register ("com/rd/animation/data/type/SwapAnimationValue", DoNotGenerateAcw=true)]
	public partial class SwapAnimationValue : global::Java.Lang.Object, global::Com.RD.Animation.Data.IValue {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/data/type/SwapAnimationValue", typeof (SwapAnimationValue));
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

		protected SwapAnimationValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='SwapAnimationValue']/constructor[@name='SwapAnimationValue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SwapAnimationValue ()
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

		static Delegate cb_getCoordinate;
#pragma warning disable 0169
		static Delegate GetGetCoordinateHandler ()
		{
			if (cb_getCoordinate == null)
				cb_getCoordinate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCoordinate);
			return cb_getCoordinate;
		}

		static int n_GetCoordinate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.Type.SwapAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.SwapAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Coordinate;
		}
#pragma warning restore 0169

		static Delegate cb_setCoordinate_I;
#pragma warning disable 0169
		static Delegate GetSetCoordinate_IHandler ()
		{
			if (cb_setCoordinate_I == null)
				cb_setCoordinate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCoordinate_I);
			return cb_setCoordinate_I;
		}

		static void n_SetCoordinate_I (IntPtr jnienv, IntPtr native__this, int coordinate)
		{
			global::Com.RD.Animation.Data.Type.SwapAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.SwapAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Coordinate = coordinate;
		}
#pragma warning restore 0169

		public virtual unsafe int Coordinate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='SwapAnimationValue']/method[@name='getCoordinate' and count(parameter)=0]"
			[Register ("getCoordinate", "()I", "GetGetCoordinateHandler")]
			get {
				const string __id = "getCoordinate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='SwapAnimationValue']/method[@name='setCoordinate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCoordinate", "(I)V", "GetSetCoordinate_IHandler")]
			set {
				const string __id = "setCoordinate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCoordinateReverse;
#pragma warning disable 0169
		static Delegate GetGetCoordinateReverseHandler ()
		{
			if (cb_getCoordinateReverse == null)
				cb_getCoordinateReverse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCoordinateReverse);
			return cb_getCoordinateReverse;
		}

		static int n_GetCoordinateReverse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.Type.SwapAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.SwapAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CoordinateReverse;
		}
#pragma warning restore 0169

		static Delegate cb_setCoordinateReverse_I;
#pragma warning disable 0169
		static Delegate GetSetCoordinateReverse_IHandler ()
		{
			if (cb_setCoordinateReverse_I == null)
				cb_setCoordinateReverse_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCoordinateReverse_I);
			return cb_setCoordinateReverse_I;
		}

		static void n_SetCoordinateReverse_I (IntPtr jnienv, IntPtr native__this, int coordinateReverse)
		{
			global::Com.RD.Animation.Data.Type.SwapAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.SwapAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CoordinateReverse = coordinateReverse;
		}
#pragma warning restore 0169

		public virtual unsafe int CoordinateReverse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='SwapAnimationValue']/method[@name='getCoordinateReverse' and count(parameter)=0]"
			[Register ("getCoordinateReverse", "()I", "GetGetCoordinateReverseHandler")]
			get {
				const string __id = "getCoordinateReverse.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='SwapAnimationValue']/method[@name='setCoordinateReverse' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCoordinateReverse", "(I)V", "GetSetCoordinateReverse_IHandler")]
			set {
				const string __id = "setCoordinateReverse.(I)V";
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
