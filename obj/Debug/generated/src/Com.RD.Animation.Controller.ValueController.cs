using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='ValueController']"
	[global::Android.Runtime.Register ("com/rd/animation/controller/ValueController", DoNotGenerateAcw=true)]
	public partial class ValueController : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.rd.animation.controller']/interface[@name='ValueController.UpdateListener']"
		[Register ("com/rd/animation/controller/ValueController$UpdateListener", "", "Com.RD.Animation.Controller.ValueController/IUpdateListenerInvoker")]
		public partial interface IUpdateListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/interface[@name='ValueController.UpdateListener']/method[@name='onValueUpdated' and count(parameter)=1 and parameter[1][@type='com.rd.animation.data.Value']]"
			[Register ("onValueUpdated", "(Lcom/rd/animation/data/Value;)V", "GetOnValueUpdated_Lcom_rd_animation_data_Value_Handler:Com.RD.Animation.Controller.ValueController/IUpdateListenerInvoker, ViewPagerIndicatorBinding")]
			void OnValueUpdated (global::Com.RD.Animation.Data.IValue p0);

		}

		[global::Android.Runtime.Register ("com/rd/animation/controller/ValueController$UpdateListener", DoNotGenerateAcw=true)]
		internal class IUpdateListenerInvoker : global::Java.Lang.Object, IUpdateListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/rd/animation/controller/ValueController$UpdateListener", typeof (IUpdateListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IUpdateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUpdateListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.rd.animation.controller.ValueController.UpdateListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUpdateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onValueUpdated_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
			static Delegate GetOnValueUpdated_Lcom_rd_animation_data_Value_Handler ()
			{
				if (cb_onValueUpdated_Lcom_rd_animation_data_Value_ == null)
					cb_onValueUpdated_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnValueUpdated_Lcom_rd_animation_data_Value_);
				return cb_onValueUpdated_Lcom_rd_animation_data_Value_;
			}

			static void n_OnValueUpdated_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.RD.Animation.Controller.ValueController.IUpdateListener __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.ValueController.IUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.RD.Animation.Data.IValue p0 = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnValueUpdated (p0);
			}
#pragma warning restore 0169

			IntPtr id_onValueUpdated_Lcom_rd_animation_data_Value_;
			public unsafe void OnValueUpdated (global::Com.RD.Animation.Data.IValue p0)
			{
				if (id_onValueUpdated_Lcom_rd_animation_data_Value_ == IntPtr.Zero)
					id_onValueUpdated_Lcom_rd_animation_data_Value_ = JNIEnv.GetMethodID (class_ref, "onValueUpdated", "(Lcom/rd/animation/data/Value;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onValueUpdated_Lcom_rd_animation_data_Value_, __args);
			}

		}

		// event args for com.rd.animation.controller.ValueController.UpdateListener.onValueUpdated
		public partial class UpdateEventArgs : global::System.EventArgs {

			public UpdateEventArgs (global::Com.RD.Animation.Data.IValue p0)
			{
				this.p0 = p0;
			}

			global::Com.RD.Animation.Data.IValue p0;
			public global::Com.RD.Animation.Data.IValue P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/rd/animation/controller/ValueController_UpdateListenerImplementor")]
		internal sealed partial class IUpdateListenerImplementor : global::Java.Lang.Object, IUpdateListener {

			object sender;

			public IUpdateListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/rd/animation/controller/ValueController_UpdateListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<UpdateEventArgs> Handler;
#pragma warning restore 0649

			public void OnValueUpdated (global::Com.RD.Animation.Data.IValue p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new UpdateEventArgs (p0));
			}

			internal static bool __IsEmpty (IUpdateListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/controller/ValueController", typeof (ValueController));
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

		protected ValueController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='ValueController']/constructor[@name='ValueController' and count(parameter)=1 and parameter[1][@type='com.rd.animation.controller.ValueController.UpdateListener']]"
		[Register (".ctor", "(Lcom/rd/animation/controller/ValueController$UpdateListener;)V", "")]
		public unsafe ValueController (global::Com.RD.Animation.Controller.ValueController.IUpdateListener listener)
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

		static Delegate cb_color;
#pragma warning disable 0169
		static Delegate GetColorHandler ()
		{
			if (cb_color == null)
				cb_color = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Color);
			return cb_color;
		}

		static IntPtr n_Color (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Controller.ValueController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.ValueController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Color ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='ValueController']/method[@name='color' and count(parameter)=0]"
		[Register ("color", "()Lcom/rd/animation/type/ColorAnimation;", "GetColorHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.ColorAnimation Color ()
		{
			const string __id = "color.()Lcom/rd/animation/type/ColorAnimation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.ColorAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_drop;
#pragma warning disable 0169
		static Delegate GetDropHandler ()
		{
			if (cb_drop == null)
				cb_drop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Drop);
			return cb_drop;
		}

		static IntPtr n_Drop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Controller.ValueController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.ValueController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Drop ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='ValueController']/method[@name='drop' and count(parameter)=0]"
		[Register ("drop", "()Lcom/rd/animation/type/DropAnimation;", "GetDropHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.DropAnimation Drop ()
		{
			const string __id = "drop.()Lcom/rd/animation/type/DropAnimation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.DropAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fill;
#pragma warning disable 0169
		static Delegate GetFillHandler ()
		{
			if (cb_fill == null)
				cb_fill = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Fill);
			return cb_fill;
		}

		static IntPtr n_Fill (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Controller.ValueController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.ValueController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fill ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='ValueController']/method[@name='fill' and count(parameter)=0]"
		[Register ("fill", "()Lcom/rd/animation/type/FillAnimation;", "GetFillHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.FillAnimation Fill ()
		{
			const string __id = "fill.()Lcom/rd/animation/type/FillAnimation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.FillAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_scale;
#pragma warning disable 0169
		static Delegate GetScaleHandler ()
		{
			if (cb_scale == null)
				cb_scale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Scale);
			return cb_scale;
		}

		static IntPtr n_Scale (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Controller.ValueController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.ValueController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Scale ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='ValueController']/method[@name='scale' and count(parameter)=0]"
		[Register ("scale", "()Lcom/rd/animation/type/ScaleAnimation;", "GetScaleHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.ScaleAnimation Scale ()
		{
			const string __id = "scale.()Lcom/rd/animation/type/ScaleAnimation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.ScaleAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_scaleDown;
#pragma warning disable 0169
		static Delegate GetScaleDownHandler ()
		{
			if (cb_scaleDown == null)
				cb_scaleDown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ScaleDown);
			return cb_scaleDown;
		}

		static IntPtr n_ScaleDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Controller.ValueController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.ValueController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleDown ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='ValueController']/method[@name='scaleDown' and count(parameter)=0]"
		[Register ("scaleDown", "()Lcom/rd/animation/type/ScaleDownAnimation;", "GetScaleDownHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.ScaleDownAnimation ScaleDown ()
		{
			const string __id = "scaleDown.()Lcom/rd/animation/type/ScaleDownAnimation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.ScaleDownAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_slide;
#pragma warning disable 0169
		static Delegate GetSlideHandler ()
		{
			if (cb_slide == null)
				cb_slide = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Slide);
			return cb_slide;
		}

		static IntPtr n_Slide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Controller.ValueController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.ValueController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Slide ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='ValueController']/method[@name='slide' and count(parameter)=0]"
		[Register ("slide", "()Lcom/rd/animation/type/SlideAnimation;", "GetSlideHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.SlideAnimation Slide ()
		{
			const string __id = "slide.()Lcom/rd/animation/type/SlideAnimation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.SlideAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_swap;
#pragma warning disable 0169
		static Delegate GetSwapHandler ()
		{
			if (cb_swap == null)
				cb_swap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Swap);
			return cb_swap;
		}

		static IntPtr n_Swap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Controller.ValueController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.ValueController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Swap ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='ValueController']/method[@name='swap' and count(parameter)=0]"
		[Register ("swap", "()Lcom/rd/animation/type/SwapAnimation;", "GetSwapHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.SwapAnimation Swap ()
		{
			const string __id = "swap.()Lcom/rd/animation/type/SwapAnimation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.SwapAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_thinWorm;
#pragma warning disable 0169
		static Delegate GetThinWormHandler ()
		{
			if (cb_thinWorm == null)
				cb_thinWorm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ThinWorm);
			return cb_thinWorm;
		}

		static IntPtr n_ThinWorm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Controller.ValueController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.ValueController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThinWorm ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='ValueController']/method[@name='thinWorm' and count(parameter)=0]"
		[Register ("thinWorm", "()Lcom/rd/animation/type/ThinWormAnimation;", "GetThinWormHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.ThinWormAnimation ThinWorm ()
		{
			const string __id = "thinWorm.()Lcom/rd/animation/type/ThinWormAnimation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.ThinWormAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_worm;
#pragma warning disable 0169
		static Delegate GetWormHandler ()
		{
			if (cb_worm == null)
				cb_worm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Worm);
			return cb_worm;
		}

		static IntPtr n_Worm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Controller.ValueController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Controller.ValueController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Worm ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.controller']/class[@name='ValueController']/method[@name='worm' and count(parameter)=0]"
		[Register ("worm", "()Lcom/rd/animation/type/WormAnimation;", "GetWormHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.WormAnimation Worm ()
		{
			const string __id = "worm.()Lcom/rd/animation/type/WormAnimation;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.WormAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
