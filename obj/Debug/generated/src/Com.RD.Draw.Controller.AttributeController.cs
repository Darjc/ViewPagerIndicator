using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='AttributeController']"
	[global::Android.Runtime.Register ("com/rd/draw/controller/AttributeController", DoNotGenerateAcw=true)]
	public partial class AttributeController : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/controller/AttributeController", typeof (AttributeController));
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

		protected AttributeController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='AttributeController']/constructor[@name='AttributeController' and count(parameter)=1 and parameter[1][@type='com.rd.draw.data.Indicator']]"
		[Register (".ctor", "(Lcom/rd/draw/data/Indicator;)V", "")]
		public unsafe AttributeController (global::Com.RD.Draw.Data.Indicator indicator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/rd/draw/data/Indicator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((indicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indicator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_Landroid_util_AttributeSet_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Landroid_util_AttributeSet_Handler ()
		{
			if (cb_init_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
				cb_init_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Landroid_util_AttributeSet_);
			return cb_init_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		static void n_Init_Landroid_content_Context_Landroid_util_AttributeSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_attrs)
		{
			global::Com.RD.Draw.Controller.AttributeController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Controller.AttributeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.IAttributeSet attrs = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_attrs, JniHandleOwnership.DoNotTransfer);
			__this.Init (context, attrs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='AttributeController']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register ("init", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "GetInit_Landroid_content_Context_Landroid_util_AttributeSet_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
		{
			const string __id = "init.(Landroid/content/Context;Landroid/util/AttributeSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
