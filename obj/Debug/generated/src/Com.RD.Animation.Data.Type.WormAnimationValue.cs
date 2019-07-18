using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Data.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='WormAnimationValue']"
	[global::Android.Runtime.Register ("com/rd/animation/data/type/WormAnimationValue", DoNotGenerateAcw=true)]
	public partial class WormAnimationValue : global::Java.Lang.Object, global::Com.RD.Animation.Data.IValue {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/data/type/WormAnimationValue", typeof (WormAnimationValue));
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

		protected WormAnimationValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='WormAnimationValue']/constructor[@name='WormAnimationValue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WormAnimationValue ()
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

		static Delegate cb_getRectEnd;
#pragma warning disable 0169
		static Delegate GetGetRectEndHandler ()
		{
			if (cb_getRectEnd == null)
				cb_getRectEnd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRectEnd);
			return cb_getRectEnd;
		}

		static int n_GetRectEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.Type.WormAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.WormAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RectEnd;
		}
#pragma warning restore 0169

		static Delegate cb_setRectEnd_I;
#pragma warning disable 0169
		static Delegate GetSetRectEnd_IHandler ()
		{
			if (cb_setRectEnd_I == null)
				cb_setRectEnd_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRectEnd_I);
			return cb_setRectEnd_I;
		}

		static void n_SetRectEnd_I (IntPtr jnienv, IntPtr native__this, int rectEnd)
		{
			global::Com.RD.Animation.Data.Type.WormAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.WormAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RectEnd = rectEnd;
		}
#pragma warning restore 0169

		public virtual unsafe int RectEnd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='WormAnimationValue']/method[@name='getRectEnd' and count(parameter)=0]"
			[Register ("getRectEnd", "()I", "GetGetRectEndHandler")]
			get {
				const string __id = "getRectEnd.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='WormAnimationValue']/method[@name='setRectEnd' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRectEnd", "(I)V", "GetSetRectEnd_IHandler")]
			set {
				const string __id = "setRectEnd.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRectStart;
#pragma warning disable 0169
		static Delegate GetGetRectStartHandler ()
		{
			if (cb_getRectStart == null)
				cb_getRectStart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRectStart);
			return cb_getRectStart;
		}

		static int n_GetRectStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.Type.WormAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.WormAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RectStart;
		}
#pragma warning restore 0169

		static Delegate cb_setRectStart_I;
#pragma warning disable 0169
		static Delegate GetSetRectStart_IHandler ()
		{
			if (cb_setRectStart_I == null)
				cb_setRectStart_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRectStart_I);
			return cb_setRectStart_I;
		}

		static void n_SetRectStart_I (IntPtr jnienv, IntPtr native__this, int rectStartEdge)
		{
			global::Com.RD.Animation.Data.Type.WormAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.WormAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RectStart = rectStartEdge;
		}
#pragma warning restore 0169

		public virtual unsafe int RectStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='WormAnimationValue']/method[@name='getRectStart' and count(parameter)=0]"
			[Register ("getRectStart", "()I", "GetGetRectStartHandler")]
			get {
				const string __id = "getRectStart.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='WormAnimationValue']/method[@name='setRectStart' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRectStart", "(I)V", "GetSetRectStart_IHandler")]
			set {
				const string __id = "setRectStart.(I)V";
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
