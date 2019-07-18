using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']"
	[global::Android.Runtime.Register ("com/rd/animation/type/BaseAnimation", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.animation.Animator"})]
	public abstract partial class BaseAnimation : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/field[@name='DEFAULT_ANIMATION_TIME']"
		[Register ("DEFAULT_ANIMATION_TIME")]
		public const int DefaultAnimationTime = (int) 350;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/field[@name='animationDuration']"
		[Register ("animationDuration")]
		protected long AnimationDuration {
			get {
				const string __id = "animationDuration.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "animationDuration.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/field[@name='animator']"
		[Register ("animator")]
		protected global::Android.Animation.Animator Animator {
			get {
				const string __id = "animator.Landroid/animation/Animator;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "animator.Landroid/animation/Animator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/field[@name='listener']"
		[Register ("listener")]
		protected global::Com.RD.Animation.Controller.ValueController.IUpdateListener Listener {
			get {
				const string __id = "listener.Lcom/rd/animation/controller/ValueController$UpdateListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.ValueController.IUpdateListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "listener.Lcom/rd/animation/controller/ValueController$UpdateListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/type/BaseAnimation", typeof (BaseAnimation));
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

		protected BaseAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/constructor[@name='BaseAnimation' and count(parameter)=1 and parameter[1][@type='com.rd.animation.controller.ValueController.UpdateListener']]"
		[Register (".ctor", "(Lcom/rd/animation/controller/ValueController$UpdateListener;)V", "")]
		public unsafe BaseAnimation (global::Com.RD.Animation.Controller.ValueController.IUpdateListener listener)
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
			global::Com.RD.Animation.Type.BaseAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.BaseAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateAnimator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/method[@name='createAnimator' and count(parameter)=0]"
		[Register ("createAnimator", "()Lcom/rd/animation/type/BaseAnimation;", "GetCreateAnimatorHandler")]
		public abstract global::Com.RD.Animation.Type.BaseAnimation CreateAnimator ();

		static Delegate cb_duration_J;
#pragma warning disable 0169
		static Delegate GetDuration_JHandler ()
		{
			if (cb_duration_J == null)
				cb_duration_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Duration_J);
			return cb_duration_J;
		}

		static IntPtr n_Duration_J (IntPtr jnienv, IntPtr native__this, long duration)
		{
			global::Com.RD.Animation.Type.BaseAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.BaseAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Duration (duration));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/method[@name='duration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("duration", "(J)Lcom/rd/animation/type/BaseAnimation;", "GetDuration_JHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.BaseAnimation Duration (long duration)
		{
			const string __id = "duration.(J)Lcom/rd/animation/type/BaseAnimation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (duration);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.BaseAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.RD.Animation.Type.BaseAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.BaseAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.End ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/method[@name='end' and count(parameter)=0]"
		[Register ("end", "()V", "GetEndHandler")]
		public virtual unsafe void End ()
		{
			const string __id = "end.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		static IntPtr n_Progress_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.RD.Animation.Type.BaseAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.BaseAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Progress (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/method[@name='progress' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("progress", "(F)Lcom/rd/animation/type/BaseAnimation;", "GetProgress_FHandler")]
		public abstract global::Com.RD.Animation.Type.BaseAnimation Progress (float p0);

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Type.BaseAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.BaseAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/rd/animation/type/BaseAnimation", DoNotGenerateAcw=true)]
	internal partial class BaseAnimationInvoker : BaseAnimation {

		public BaseAnimationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/rd/animation/type/BaseAnimation", typeof (BaseAnimationInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/method[@name='createAnimator' and count(parameter)=0]"
		[Register ("createAnimator", "()Lcom/rd/animation/type/BaseAnimation;", "GetCreateAnimatorHandler")]
		public override unsafe global::Com.RD.Animation.Type.BaseAnimation CreateAnimator ()
		{
			const string __id = "createAnimator.()Lcom/rd/animation/type/BaseAnimation;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.BaseAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='BaseAnimation']/method[@name='progress' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("progress", "(F)Lcom/rd/animation/type/BaseAnimation;", "GetProgress_FHandler")]
		public override unsafe global::Com.RD.Animation.Type.BaseAnimation Progress (float p0)
		{
			const string __id = "progress.(F)Lcom/rd/animation/type/BaseAnimation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.BaseAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
