using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.type']/class[@name='DropAnimation']"
	[global::Android.Runtime.Register ("com/rd/animation/type/DropAnimation", DoNotGenerateAcw=true)]
	public partial class DropAnimation : global::Com.RD.Animation.Type.BaseAnimation {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/type/DropAnimation", typeof (DropAnimation));
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

		protected DropAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.type']/class[@name='DropAnimation']/constructor[@name='DropAnimation' and count(parameter)=1 and parameter[1][@type='com.rd.animation.controller.ValueController.UpdateListener']]"
		[Register (".ctor", "(Lcom/rd/animation/controller/ValueController$UpdateListener;)V", "")]
		public unsafe DropAnimation (global::Com.RD.Animation.Controller.ValueController.IUpdateListener listener)
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
			global::Com.RD.Animation.Type.DropAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.DropAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateAnimator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='DropAnimation']/method[@name='createAnimator' and count(parameter)=0]"
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
			global::Com.RD.Animation.Type.DropAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.DropAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Progress (progress));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='DropAnimation']/method[@name='progress' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static Delegate cb_with_IIIII;
#pragma warning disable 0169
		static Delegate GetWith_IIIIIHandler ()
		{
			if (cb_with_IIIII == null)
				cb_with_IIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, IntPtr>) n_With_IIIII);
			return cb_with_IIIII;
		}

		static IntPtr n_With_IIIII (IntPtr jnienv, IntPtr native__this, int widthStart, int widthEnd, int heightStart, int heightEnd, int radius)
		{
			global::Com.RD.Animation.Type.DropAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.DropAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.With (widthStart, widthEnd, heightStart, heightEnd, radius));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='DropAnimation']/method[@name='with' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("with", "(IIIII)Lcom/rd/animation/type/DropAnimation;", "GetWith_IIIIIHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.DropAnimation With (int widthStart, int widthEnd, int heightStart, int heightEnd, int radius)
		{
			const string __id = "with.(IIIII)Lcom/rd/animation/type/DropAnimation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (widthStart);
				__args [1] = new JniArgumentValue (widthEnd);
				__args [2] = new JniArgumentValue (heightStart);
				__args [3] = new JniArgumentValue (heightEnd);
				__args [4] = new JniArgumentValue (radius);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.DropAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
