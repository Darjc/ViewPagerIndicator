using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.type']/class[@name='ScaleAnimation']"
	[global::Android.Runtime.Register ("com/rd/animation/type/ScaleAnimation", DoNotGenerateAcw=true)]
	public partial class ScaleAnimation : global::Com.RD.Animation.Type.ColorAnimation {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='ScaleAnimation']/field[@name='DEFAULT_SCALE_FACTOR']"
		[Register ("DEFAULT_SCALE_FACTOR")]
		public const float DefaultScaleFactor = (float) 0.7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='ScaleAnimation']/field[@name='MAX_SCALE_FACTOR']"
		[Register ("MAX_SCALE_FACTOR")]
		public const float MaxScaleFactor = (float) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.animation.type']/class[@name='ScaleAnimation']/field[@name='MIN_SCALE_FACTOR']"
		[Register ("MIN_SCALE_FACTOR")]
		public const float MinScaleFactor = (float) 0.3;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/type/ScaleAnimation", typeof (ScaleAnimation));
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

		protected ScaleAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.type']/class[@name='ScaleAnimation']/constructor[@name='ScaleAnimation' and count(parameter)=1 and parameter[1][@type='com.rd.animation.controller.ValueController.UpdateListener']]"
		[Register (".ctor", "(Lcom/rd/animation/controller/ValueController$UpdateListener;)V", "")]
		public unsafe ScaleAnimation (global::Com.RD.Animation.Controller.ValueController.IUpdateListener listener)
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

		static Delegate cb_createScalePropertyHolder_Z;
#pragma warning disable 0169
		static Delegate GetCreateScalePropertyHolder_ZHandler ()
		{
			if (cb_createScalePropertyHolder_Z == null)
				cb_createScalePropertyHolder_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_CreateScalePropertyHolder_Z);
			return cb_createScalePropertyHolder_Z;
		}

		static IntPtr n_CreateScalePropertyHolder_Z (IntPtr jnienv, IntPtr native__this, bool isReverse)
		{
			global::Com.RD.Animation.Type.ScaleAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.ScaleAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateScalePropertyHolder (isReverse));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='ScaleAnimation']/method[@name='createScalePropertyHolder' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("createScalePropertyHolder", "(Z)Landroid/animation/PropertyValuesHolder;", "GetCreateScalePropertyHolder_ZHandler")]
		protected virtual unsafe global::Android.Animation.PropertyValuesHolder CreateScalePropertyHolder (bool isReverse)
		{
			const string __id = "createScalePropertyHolder.(Z)Landroid/animation/PropertyValuesHolder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isReverse);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.PropertyValuesHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_with_IIIF;
#pragma warning disable 0169
		static Delegate GetWith_IIIFHandler ()
		{
			if (cb_with_IIIF == null)
				cb_with_IIIF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, float, IntPtr>) n_With_IIIF);
			return cb_with_IIIF;
		}

		static IntPtr n_With_IIIF (IntPtr jnienv, IntPtr native__this, int colorStart, int colorEnd, int radius, float scaleFactor)
		{
			global::Com.RD.Animation.Type.ScaleAnimation __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.ScaleAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.With (colorStart, colorEnd, radius, scaleFactor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.type']/class[@name='ScaleAnimation']/method[@name='with' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float']]"
		[Register ("with", "(IIIF)Lcom/rd/animation/type/ScaleAnimation;", "GetWith_IIIFHandler")]
		public virtual unsafe global::Com.RD.Animation.Type.ScaleAnimation With (int colorStart, int colorEnd, int radius, float scaleFactor)
		{
			const string __id = "with.(IIIF)Lcom/rd/animation/type/ScaleAnimation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (colorStart);
				__args [1] = new JniArgumentValue (colorEnd);
				__args [2] = new JniArgumentValue (radius);
				__args [3] = new JniArgumentValue (scaleFactor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.ScaleAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
