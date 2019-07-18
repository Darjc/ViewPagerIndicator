using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='AnimationController']"
	[global::Android.Runtime.Register ("com/rd/animation/controller/AnimationController", DoNotGenerateAcw=true)]
	public partial class AnimationController : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/controller/AnimationController", typeof (AnimationController));
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

		protected AnimationController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='AnimationController']/constructor[@name='AnimationController' and count(parameter)=2 and parameter[1][@type='com.rd.draw.data.Indicator'] and parameter[2][@type='com.rd.animation.controller.ValueController.UpdateListener']]"
		[Register (".ctor", "(Lcom/rd/draw/data/Indicator;Lcom/rd/animation/controller/ValueController$UpdateListener;)V", "")]
		public unsafe AnimationController (global::Com.RD.Draw.Data.Indicator indicator, global::Com.RD.Animation.Controller.ValueController.IUpdateListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/rd/draw/data/Indicator;Lcom/rd/animation/controller/ValueController$UpdateListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((indicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indicator).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_basic;
#pragma warning disable 0169
		static Delegate GetBasicHandler ()
		{
			if (cb_basic == null)
				cb_basic = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Basic);
			return cb_basic;
		}

		static void n_Basic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Controller.AnimationController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.AnimationController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Basic ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='AnimationController']/method[@name='basic' and count(parameter)=0]"
		[Register ("basic", "()V", "GetBasicHandler")]
		public virtual unsafe void Basic ()
		{
			const string __id = "basic.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_end;
#pragma warning disable 0169
		static Delegate GetEndHandler ()
		{
			if (cb_end == null)
				cb_end = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_End);
			return cb_end;
		}

		static void n_End (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Controller.AnimationController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.AnimationController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='AnimationController']/method[@name='end' and count(parameter)=0]"
		[Register ("end", "()V", "GetEndHandler")]
		public virtual unsafe void End ()
		{
			const string __id = "end.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_interactive_F;
#pragma warning disable 0169
		static Delegate GetInteractive_FHandler ()
		{
			if (cb_interactive_F == null)
				cb_interactive_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_Interactive_F);
			return cb_interactive_F;
		}

		static void n_Interactive_F (IntPtr jnienv, IntPtr native__this, float progress)
		{
			global::Com.RD.Animation.Controller.AnimationController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.AnimationController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Interactive (progress);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='AnimationController']/method[@name='interactive' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("interactive", "(F)V", "GetInteractive_FHandler")]
		public virtual unsafe void Interactive (float progress)
		{
			const string __id = "interactive.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (progress);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
