using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='MeasureController']"
	[global::Android.Runtime.Register ("com/rd/draw/controller/MeasureController", DoNotGenerateAcw=true)]
	public partial class MeasureController : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/controller/MeasureController", typeof (MeasureController));
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

		protected MeasureController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='MeasureController']/constructor[@name='MeasureController' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MeasureController ()
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

		static Delegate cb_measureViewSize_Lcom_rd_draw_data_Indicator_II;
#pragma warning disable 0169
		static Delegate GetMeasureViewSize_Lcom_rd_draw_data_Indicator_IIHandler ()
		{
			if (cb_measureViewSize_Lcom_rd_draw_data_Indicator_II == null)
				cb_measureViewSize_Lcom_rd_draw_data_Indicator_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_MeasureViewSize_Lcom_rd_draw_data_Indicator_II);
			return cb_measureViewSize_Lcom_rd_draw_data_Indicator_II;
		}

		static IntPtr n_MeasureViewSize_Lcom_rd_draw_data_Indicator_II (IntPtr jnienv, IntPtr native__this, IntPtr native_indicator, int widthMeasureSpec, int heightMeasureSpec)
		{
			global::Com.RD.Draw.Controller.MeasureController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Controller.MeasureController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Draw.Data.Indicator indicator = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (native_indicator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MeasureViewSize (indicator, widthMeasureSpec, heightMeasureSpec));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='MeasureController']/method[@name='measureViewSize' and count(parameter)=3 and parameter[1][@type='com.rd.draw.data.Indicator'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("measureViewSize", "(Lcom/rd/draw/data/Indicator;II)Landroid/util/Pair;", "GetMeasureViewSize_Lcom_rd_draw_data_Indicator_IIHandler")]
		public virtual unsafe global::Android.Util.Pair MeasureViewSize (global::Com.RD.Draw.Data.Indicator indicator, int widthMeasureSpec, int heightMeasureSpec)
		{
			const string __id = "measureViewSize.(Lcom/rd/draw/data/Indicator;II)Landroid/util/Pair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((indicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indicator).Handle);
				__args [1] = new JniArgumentValue (widthMeasureSpec);
				__args [2] = new JniArgumentValue (heightMeasureSpec);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
