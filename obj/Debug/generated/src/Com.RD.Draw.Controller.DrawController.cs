using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='DrawController']"
	[global::Android.Runtime.Register ("com/rd/draw/controller/DrawController", DoNotGenerateAcw=true)]
	public partial class DrawController : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.rd.draw.controller']/interface[@name='DrawController.ClickListener']"
		[Register ("com/rd/draw/controller/DrawController$ClickListener", "", "Com.RD.Draw.Controller.DrawController/IClickListenerInvoker")]
		public partial interface IClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.controller']/interface[@name='DrawController.ClickListener']/method[@name='onIndicatorClicked' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onIndicatorClicked", "(I)V", "GetOnIndicatorClicked_IHandler:Com.RD.Draw.Controller.DrawController/IClickListenerInvoker, ViewPagerIndicatorBinding")]
			void OnIndicatorClicked (int p0);

		}

		[global::Android.Runtime.Register ("com/rd/draw/controller/DrawController$ClickListener", DoNotGenerateAcw=true)]
		internal class IClickListenerInvoker : global::Java.Lang.Object, IClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/rd/draw/controller/DrawController$ClickListener", typeof (IClickListenerInvoker));

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

			public static IClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.rd.draw.controller.DrawController.ClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onIndicatorClicked_I;
#pragma warning disable 0169
			static Delegate GetOnIndicatorClicked_IHandler ()
			{
				if (cb_onIndicatorClicked_I == null)
					cb_onIndicatorClicked_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnIndicatorClicked_I);
				return cb_onIndicatorClicked_I;
			}

			static void n_OnIndicatorClicked_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.RD.Draw.Controller.DrawController.IClickListener __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Controller.DrawController.IClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnIndicatorClicked (p0);
			}
#pragma warning restore 0169

			IntPtr id_onIndicatorClicked_I;
			public unsafe void OnIndicatorClicked (int p0)
			{
				if (id_onIndicatorClicked_I == IntPtr.Zero)
					id_onIndicatorClicked_I = JNIEnv.GetMethodID (class_ref, "onIndicatorClicked", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIndicatorClicked_I, __args);
			}

		}

		// event args for com.rd.draw.controller.DrawController.ClickListener.onIndicatorClicked
		public partial class ClickEventArgs : global::System.EventArgs {

			public ClickEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/rd/draw/controller/DrawController_ClickListenerImplementor")]
		internal sealed partial class IClickListenerImplementor : global::Java.Lang.Object, IClickListener {

			object sender;

			public IClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/rd/draw/controller/DrawController_ClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnIndicatorClicked (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/controller/DrawController", typeof (DrawController));
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

		protected DrawController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='DrawController']/constructor[@name='DrawController' and count(parameter)=1 and parameter[1][@type='com.rd.draw.data.Indicator']]"
		[Register (".ctor", "(Lcom/rd/draw/data/Indicator;)V", "")]
		public unsafe DrawController (global::Com.RD.Draw.Data.Indicator indicator)
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
			global::Com.RD.Draw.Controller.DrawController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Controller.DrawController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='DrawController']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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
			global::Com.RD.Draw.Controller.DrawController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Controller.DrawController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Draw.Controller.DrawController.IClickListener listener = (global::Com.RD.Draw.Controller.DrawController.IClickListener)global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Controller.DrawController.IClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetClickListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='DrawController']/method[@name='setClickListener' and count(parameter)=1 and parameter[1][@type='com.rd.draw.controller.DrawController.ClickListener']]"
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
			global::Com.RD.Draw.Controller.DrawController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Controller.DrawController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Touch (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='DrawController']/method[@name='touch' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
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
			global::Com.RD.Draw.Controller.DrawController __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Controller.DrawController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.UpdateValue (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.controller']/class[@name='DrawController']/method[@name='updateValue' and count(parameter)=1 and parameter[1][@type='com.rd.animation.data.Value']]"
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
