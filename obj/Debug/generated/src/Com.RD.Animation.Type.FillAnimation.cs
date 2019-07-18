using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.type']/class[@name='FillAnimation']"
	[global::Android.Runtime.Register ("com/rd/animation/type/FillAnimation", DoNotGenerateAcw=true)]
	public partial class FillAnimation : global::Com.RD.Animation.Type.ColorAnimation {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='FillAnimation']/field[@name='DEFAULT_STROKE_DP']"
		[Register ("DEFAULT_STROKE_DP")]
		public const int DefaultStrokeDp = (int) 1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/type/FillAnimation", typeof (FillAnimation));
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

		protected FillAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.type']/class[@name='FillAnimation']/constructor[@name='FillAnimation' and count(parameter)=1 and parameter[1][@type='com.rd.animation.controller.ValueController.UpdateListener']]"
		[Register (".ctor", "(Lcom/rd/animation/controller/ValueController$UpdateListener;)V", "")]
		public unsafe FillAnimation (global::Com.RD.Animation.Controller.ValueController.IUpdateListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/rd/animation/controller/ValueController$UpdateListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_with_IIII;
#pragma warning disable 0169
		static Delegate GetWith_IIIIHandler ()
		{
			if (cb_with_IIII == null)
				cb_with_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_With_IIII);
			return cb_with_IIII;
		}

		static IntPtr n_With_IIII (IntPtr jnienv, IntPtr native__this, int colorStart, int colorEnd, int radius, int stroke)
		{
			global::Com.RD.Animation.Type.FillAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.FillAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.With (colorStart, colorEnd, radius, stroke));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='FillAnimation']/method[@name='with' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("with", "(IIII)Lcom/rd/animation/type/FillAnimation;", "GetWith_IIIIHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.FillAnimation With (int colorStart, int colorEnd, int radius, int stroke)
		{
			const string __id = "with.(IIII)Lcom/rd/animation/type/FillAnimation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (colorStart);
				__args [1] = new JniArgumentValue (colorEnd);
				__args [2] = new JniArgumentValue (radius);
				__args [3] = new JniArgumentValue (stroke);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.FillAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
