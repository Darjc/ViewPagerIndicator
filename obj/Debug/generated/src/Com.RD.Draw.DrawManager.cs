using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw']/class[@name='DrawManager']"
	[global::Android.Runtime.Register ("com/rd/draw/DrawManager", DoNotGenerateAcw=true)]
	public partial class DrawManager : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/DrawManager", typeof (DrawManager));
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

		protected DrawManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.draw']/class[@name='DrawManager']/constructor[@name='DrawManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrawManager ()
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

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			global::Com.RD.Draw.DrawManager __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.DrawManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw']/class[@name='DrawManager']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public virtual unsafe void Draw (global::Android.Graphics.Canvas canvas)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.RD.Draw.DrawManager __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.DrawManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Indicator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw']/class[@name='DrawManager']/method[@name='indicator' and count(parameter)=0]"
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

		static Delegate cb_initAttributes_Landroid_content_Context_Landroid_util_AttributeSet_;
#pragma warning disable 0169
		static Delegate GetInitAttributes_Landroid_content_Context_Landroid_util_AttributeSet_Handler ()
		{
			if (cb_initAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
				cb_initAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InitAttributes_Landroid_content_Context_Landroid_util_AttributeSet_);
			return cb_initAttributes_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		static void n_InitAttributes_Landroid_content_Context_Landroid_util_AttributeSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_attrs)
		{
			global::Com.RD.Draw.DrawManager __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.DrawManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.IAttributeSet attrs = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_attrs, JniHandleOwnership.DoNotTransfer);
			__this.InitAttributes (context, attrs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw']/class[@name='DrawManager']/method[@name='initAttributes' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register ("initAttributes", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "GetInitAttributes_Landroid_content_Context_Landroid_util_AttributeSet_Handler")]
		public virtual unsafe void InitAttributes (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
		{
			const string __id = "initAttributes.(Landroid/content/Context;Landroid/util/AttributeSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_measureViewSize_II;
#pragma warning disable 0169
		static Delegate GetMeasureViewSize_IIHandler ()
		{
			if (cb_measureViewSize_II == null)
				cb_measureViewSize_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_MeasureViewSize_II);
			return cb_measureViewSize_II;
		}

		static IntPtr n_MeasureViewSize_II (IntPtr jnienv, IntPtr native__this, int widthMeasureSpec, int heightMeasureSpec)
		{
			global::Com.RD.Draw.DrawManager __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.DrawManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MeasureViewSize (widthMeasureSpec, heightMeasureSpec));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw']/class[@name='DrawManager']/method[@name='measureViewSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("measureViewSize", "(II)Landroid/util/Pair;", "GetMeasureViewSize_IIHandler")]
		public virtual unsafe global::Android.Util.Pair MeasureViewSize (int widthMeasureSpec, int heightMeasureSpec)
		{
			const string __id = "measureViewSize.(II)Landroid/util/Pair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (widthMeasureSpec);
				__args [1] = new JniArgumentValue (heightMeasureSpec);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setClickListener_Lcom_rd_draw_controller_DrawController_ClickListener_;
#pragma warning disable 0169
		static Delegate GetSetClickListener_Lcom_rd_draw_controller_DrawController_ClickListener_Handler ()
		{
			if (cb_setClickListener_Lcom_rd_draw_controller_DrawController_ClickListener_ == null)
				cb_setClickListener_Lcom_rd_draw_controller_DrawController_ClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClickListener_Lcom_rd_draw_controller_DrawController_ClickListener_);
			return cb_setClickListener_Lcom_rd_draw_controller_DrawController_ClickListener_;
		}

		static void n_SetClickListener_Lcom_rd_draw_controller_DrawController_ClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.RD.Draw.DrawManager __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.DrawManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Draw.Controller.DrawController.IClickListener listener = (global::Com.RD.Draw.Controller.DrawController.IClickListener)global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Controller.DrawController.IClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetClickListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw']/class[@name='DrawManager']/method[@name='setClickListener' and count(parameter)=1 and parameter[1][@type='com.rd.draw.controller.DrawController.ClickListener']]"
		[Register ("setClickListener", "(Lcom/rd/draw/controller/DrawController$ClickListener;)V", "GetSetClickListener_Lcom_rd_draw_controller_DrawController_ClickListener_Handler")]
		public virtual unsafe void SetClickListener (global::Com.RD.Draw.Controller.DrawController.IClickListener listener)
		{
			const string __id = "setClickListener.(Lcom/rd/draw/controller/DrawController$ClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_touch_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetTouch_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_touch_Landroid_view_MotionEvent_ == null)
				cb_touch_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Touch_Landroid_view_MotionEvent_);
			return cb_touch_Landroid_view_MotionEvent_;
		}

		static void n_Touch_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.RD.Draw.DrawManager __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.DrawManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Touch (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw']/class[@name='DrawManager']/method[@name='touch' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("touch", "(Landroid/view/MotionEvent;)V", "GetTouch_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void Touch (global::Android.Views.MotionEvent e)
		{
			const string __id = "touch.(Landroid/view/MotionEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateValue_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
		static Delegate GetUpdateValue_Lcom_rd_animation_data_Value_Handler ()
		{
			if (cb_updateValue_Lcom_rd_animation_data_Value_ == null)
				cb_updateValue_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateValue_Lcom_rd_animation_data_Value_);
			return cb_updateValue_Lcom_rd_animation_data_Value_;
		}

		static void n_UpdateValue_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.RD.Draw.DrawManager __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.DrawManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.UpdateValue (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw']/class[@name='DrawManager']/method[@name='updateValue' and count(parameter)=1 and parameter[1][@type='com.rd.animation.data.Value']]"
		[Register ("updateValue", "(Lcom/rd/animation/data/Value;)V", "GetUpdateValue_Lcom_rd_animation_data_Value_Handler")]
		public virtual unsafe void UpdateValue (global::Com.RD.Animation.Data.IValue value)
		{
			const string __id = "updateValue.(Lcom/rd/animation/data/Value;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.RD.Draw.Controller.DrawController.IClickListener"
		public event EventHandler<global::Com.RD.Draw.Controller.DrawController.ClickEventArgs> Click {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.RD.Draw.Controller.DrawController.IClickListener, global::Com.RD.Draw.Controller.DrawController.IClickListenerImplementor>(
						ref weak_implementor_SetClickListener,
						__CreateIClickListenerImplementor,
						SetClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.RD.Draw.Controller.DrawController.IClickListener, global::Com.RD.Draw.Controller.DrawController.IClickListenerImplementor>(
						ref weak_implementor_SetClickListener,
						global::Com.RD.Draw.Controller.DrawController.IClickListenerImplementor.__IsEmpty,
						__v => SetClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetClickListener;

		global::Com.RD.Draw.Controller.DrawController.IClickListenerImplementor __CreateIClickListenerImplementor ()
		{
			return new global::Com.RD.Draw.Controller.DrawController.IClickListenerImplementor (this);
		}
#endregion
	}
}
