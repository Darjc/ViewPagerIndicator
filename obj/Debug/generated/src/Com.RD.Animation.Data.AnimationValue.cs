using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.data']/class[@name='AnimationValue']"
	[global::Android.Runtime.Register ("com/rd/animation/data/AnimationValue", DoNotGenerateAcw=true)]
	public partial class AnimationValue : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/data/AnimationValue", typeof (AnimationValue));
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

		protected AnimationValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.data']/class[@name='AnimationValue']/constructor[@name='AnimationValue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimationValue ()
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

		static Delegate cb_getColorAnimationValue;
#pragma warning disable 0169
		static Delegate GetGetColorAnimationValueHandler ()
		{
			if (cb_getColorAnimationValue == null)
				cb_getColorAnimationValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColorAnimationValue);
			return cb_getColorAnimationValue;
		}

		static IntPtr n_GetColorAnimationValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.AnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.AnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ColorAnimationValue);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.RD.Animation.Data.Type.ColorAnimationValue ColorAnimationValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data']/class[@name='AnimationValue']/method[@name='getColorAnimationValue' and count(parameter)=0]"
			[Register ("getColorAnimationValue", "()Lcom/rd/animation/data/type/ColorAnimationValue;", "GetGetColorAnimationValueHandler")]
			get {
				const string __id = "getColorAnimationValue.()Lcom/rd/animation/data/type/ColorAnimationValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.ColorAnimationValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDropAnimationValue;
#pragma warning disable 0169
		static Delegate GetGetDropAnimationValueHandler ()
		{
			if (cb_getDropAnimationValue == null)
				cb_getDropAnimationValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDropAnimationValue);
			return cb_getDropAnimationValue;
		}

		static IntPtr n_GetDropAnimationValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.AnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.AnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DropAnimationValue);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.RD.Animation.Data.Type.DropAnimationValue DropAnimationValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data']/class[@name='AnimationValue']/method[@name='getDropAnimationValue' and count(parameter)=0]"
			[Register ("getDropAnimationValue", "()Lcom/rd/animation/data/type/DropAnimationValue;", "GetGetDropAnimationValueHandler")]
			get {
				const string __id = "getDropAnimationValue.()Lcom/rd/animation/data/type/DropAnimationValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.DropAnimationValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFillAnimationValue;
#pragma warning disable 0169
		static Delegate GetGetFillAnimationValueHandler ()
		{
			if (cb_getFillAnimationValue == null)
				cb_getFillAnimationValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillAnimationValue);
			return cb_getFillAnimationValue;
		}

		static IntPtr n_GetFillAnimationValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.AnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.AnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillAnimationValue);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.RD.Animation.Data.Type.FillAnimationValue FillAnimationValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data']/class[@name='AnimationValue']/method[@name='getFillAnimationValue' and count(parameter)=0]"
			[Register ("getFillAnimationValue", "()Lcom/rd/animation/data/type/FillAnimationValue;", "GetGetFillAnimationValueHandler")]
			get {
				const string __id = "getFillAnimationValue.()Lcom/rd/animation/data/type/FillAnimationValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.FillAnimationValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleAnimationValue;
#pragma warning disable 0169
		static Delegate GetGetScaleAnimationValueHandler ()
		{
			if (cb_getScaleAnimationValue == null)
				cb_getScaleAnimationValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleAnimationValue);
			return cb_getScaleAnimationValue;
		}

		static IntPtr n_GetScaleAnimationValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.AnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.AnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleAnimationValue);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.RD.Animation.Data.Type.ScaleAnimationValue ScaleAnimationValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data']/class[@name='AnimationValue']/method[@name='getScaleAnimationValue' and count(parameter)=0]"
			[Register ("getScaleAnimationValue", "()Lcom/rd/animation/data/type/ScaleAnimationValue;", "GetGetScaleAnimationValueHandler")]
			get {
				const string __id = "getScaleAnimationValue.()Lcom/rd/animation/data/type/ScaleAnimationValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.ScaleAnimationValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSwapAnimationValue;
#pragma warning disable 0169
		static Delegate GetGetSwapAnimationValueHandler ()
		{
			if (cb_getSwapAnimationValue == null)
				cb_getSwapAnimationValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSwapAnimationValue);
			return cb_getSwapAnimationValue;
		}

		static IntPtr n_GetSwapAnimationValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.AnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.AnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SwapAnimationValue);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.RD.Animation.Data.Type.SwapAnimationValue SwapAnimationValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data']/class[@name='AnimationValue']/method[@name='getSwapAnimationValue' and count(parameter)=0]"
			[Register ("getSwapAnimationValue", "()Lcom/rd/animation/data/type/SwapAnimationValue;", "GetGetSwapAnimationValueHandler")]
			get {
				const string __id = "getSwapAnimationValue.()Lcom/rd/animation/data/type/SwapAnimationValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.SwapAnimationValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThinWormAnimationValue;
#pragma warning disable 0169
		static Delegate GetGetThinWormAnimationValueHandler ()
		{
			if (cb_getThinWormAnimationValue == null)
				cb_getThinWormAnimationValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThinWormAnimationValue);
			return cb_getThinWormAnimationValue;
		}

		static IntPtr n_GetThinWormAnimationValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.AnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.AnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ThinWormAnimationValue);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.RD.Animation.Data.Type.ThinWormAnimationValue ThinWormAnimationValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data']/class[@name='AnimationValue']/method[@name='getThinWormAnimationValue' and count(parameter)=0]"
			[Register ("getThinWormAnimationValue", "()Lcom/rd/animation/data/type/ThinWormAnimationValue;", "GetGetThinWormAnimationValueHandler")]
			get {
				const string __id = "getThinWormAnimationValue.()Lcom/rd/animation/data/type/ThinWormAnimationValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.ThinWormAnimationValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWormAnimationValue;
#pragma warning disable 0169
		static Delegate GetGetWormAnimationValueHandler ()
		{
			if (cb_getWormAnimationValue == null)
				cb_getWormAnimationValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWormAnimationValue);
			return cb_getWormAnimationValue;
		}

		static IntPtr n_GetWormAnimationValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.AnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.AnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WormAnimationValue);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.RD.Animation.Data.Type.WormAnimationValue WormAnimationValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data']/class[@name='AnimationValue']/method[@name='getWormAnimationValue' and count(parameter)=0]"
			[Register ("getWormAnimationValue", "()Lcom/rd/animation/data/type/WormAnimationValue;", "GetGetWormAnimationValueHandler")]
			get {
				const string __id = "getWormAnimationValue.()Lcom/rd/animation/data/type/WormAnimationValue;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.WormAnimationValue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
