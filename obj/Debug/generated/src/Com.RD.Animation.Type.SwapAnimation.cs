using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.type']/class[@name='SwapAnimation']"
	[global::Android.Runtime.Register ("com/rd/animation/type/SwapAnimation", DoNotGenerateAcw=true)]
	public partial class SwapAnimation : global::Com.RD.Animation.Type.BaseAnimation {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/type/SwapAnimation", typeof (SwapAnimation));
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

		protected SwapAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.type']/class[@name='SwapAnimation']/constructor[@name='SwapAnimation' and count(parameter)=1 and parameter[1][@type='com.rd.animation.controller.ValueController.UpdateListener']]"
		[Register (".ctor", "(Lcom/rd/animation/controller/ValueController$UpdateListener;)V", "")]
		public unsafe SwapAnimation (global::Com.RD.Animation.Controller.ValueController.IUpdateListener listener)
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

		static Delegate cb_createAnimator;
#pragma warning disable 0169
		static Delegate GetCreateAnimatorHandler ()
		{
			if (cb_createAnimator == null)
				cb_createAnimator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateAnimator);
			return cb_createAnimator;
		}

		static IntPtr n_CreateAnimator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Type.SwapAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.SwapAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateAnimator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='SwapAnimation']/method[@name='createAnimator' and count(parameter)=0]"
		[Register ("createAnimator", "()Lcom/rd/animation/type/BaseAnimation;", "GetCreateAnimatorHandler")]
		public override unsafe global::Com.RD.Animation.Type.BaseAnimation CreateAnimator ()
		{
			const string __id = "createAnimator.()Lcom/rd/animation/type/BaseAnimation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.BaseAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_progress_F;
#pragma warning disable 0169
		static Delegate GetProgress_FHandler ()
		{
			if (cb_progress_F == null)
				cb_progress_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Progress_F);
			return cb_progress_F;
		}

		static IntPtr n_Progress_F (IntPtr jnienv, IntPtr native__this, float progress)
		{
			global::Com.RD.Animation.Type.SwapAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.SwapAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Progress (progress));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='SwapAnimation']/method[@name='progress' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("progress", "(F)Lcom/rd/animation/type/BaseAnimation;", "GetProgress_FHandler")]
		public override unsafe global::Com.RD.Animation.Type.BaseAnimation Progress (float progress)
		{
			const string __id = "progress.(F)Lcom/rd/animation/type/BaseAnimation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (progress);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.BaseAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_with_II;
#pragma warning disable 0169
		static Delegate GetWith_IIHandler ()
		{
			if (cb_with_II == null)
				cb_with_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_With_II);
			return cb_with_II;
		}

		static IntPtr n_With_II (IntPtr jnienv, IntPtr native__this, int coordinateStart, int coordinateEnd)
		{
			global::Com.RD.Animation.Type.SwapAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.SwapAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.With (coordinateStart, coordinateEnd));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='SwapAnimation']/method[@name='with' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("with", "(II)Lcom/rd/animation/type/SwapAnimation;", "GetWith_IIHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.SwapAnimation With (int coordinateStart, int coordinateEnd)
		{
			const string __id = "with.(II)Lcom/rd/animation/type/SwapAnimation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (coordinateStart);
				__args [1] = new JniArgumentValue (coordinateEnd);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.SwapAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
