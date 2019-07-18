using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd']/class[@name='IndicatorManager']"
	[global::Android.Runtime.Register ("com/rd/IndicatorManager", DoNotGenerateAcw=true)]
	public partial class IndicatorManager : global::Java.Lang.Object, global::Com.RD.Animation.Controller.ValueController.IUpdateListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/IndicatorManager", typeof (IndicatorManager));
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

		protected IndicatorManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_animate;
#pragma warning disable 0169
		static Delegate GetAnimateHandler ()
		{
			if (cb_animate == null)
				cb_animate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Animate);
			return cb_animate;
		}

		static IntPtr n_Animate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.IndicatorManager __this = global::Java.Lang.Object.GetObject<global::Com.RD.IndicatorManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Animate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='IndicatorManager']/method[@name='animate' and count(parameter)=0]"
		[Register ("animate", "()Lcom/rd/animation/AnimationManager;", "GetAnimateHandler")]
		public virtual unsafe global::Com.RD.Animation.AnimationManager Animate ()
		{
			const string __id = "animate.()Lcom/rd/animation/AnimationManager;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.AnimationManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_drawer;
#pragma warning disable 0169
		static Delegate GetDrawerHandler ()
		{
			if (cb_drawer == null)
				cb_drawer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Drawer);
			return cb_drawer;
		}

		static IntPtr n_Drawer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.IndicatorManager __this = global::Java.Lang.Object.GetObject<global::Com.RD.IndicatorManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Drawer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='IndicatorManager']/method[@name='drawer' and count(parameter)=0]"
		[Register ("drawer", "()Lcom/rd/draw/DrawManager;", "GetDrawerHandler")]
		public virtual unsafe global::Com.RD.Draw.DrawManager Drawer ()
		{
			const string __id = "drawer.()Lcom/rd/draw/DrawManager;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Draw.DrawManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_indicator;
#pragma warning disable 0169
		static Delegate GetIndicatorHandler ()
		{
			if (cb_indicator == null)
				cb_indicator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Indicator);
			return cb_indicator;
		}

		static IntPtr n_Indicator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.IndicatorManager __this = global::Java.Lang.Object.GetObject<global::Com.RD.IndicatorManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Indicator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='IndicatorManager']/method[@name='indicator' and count(parameter)=0]"
		[Register ("indicator", "()Lcom/rd/draw/data/Indicator;", "GetIndicatorHandler")]
		public virtual unsafe global::Com.RD.Draw.Data.Indicator Indicator ()
		{
			const string __id = "indicator.()Lcom/rd/draw/data/Indicator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onValueUpdated_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
		static Delegate GetOnValueUpdated_Lcom_rd_animation_data_Value_Handler ()
		{
			if (cb_onValueUpdated_Lcom_rd_animation_data_Value_ == null)
				cb_onValueUpdated_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnValueUpdated_Lcom_rd_animation_data_Value_);
			return cb_onValueUpdated_Lcom_rd_animation_data_Value_;
		}

		static void n_OnValueUpdated_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.RD.IndicatorManager __this = global::Java.Lang.Object.GetObject<global::Com.RD.IndicatorManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OnValueUpdated (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='IndicatorManager']/method[@name='onValueUpdated' and count(parameter)=1 and parameter[1][@type='com.rd.animation.data.Value']]"
		[Register ("onValueUpdated", "(Lcom/rd/animation/data/Value;)V", "GetOnValueUpdated_Lcom_rd_animation_data_Value_Handler")]
		public virtual unsafe void OnValueUpdated (global::Com.RD.Animation.Data.IValue value)
		{
			const string __id = "onValueUpdated.(Lcom/rd/animation/data/Value;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
