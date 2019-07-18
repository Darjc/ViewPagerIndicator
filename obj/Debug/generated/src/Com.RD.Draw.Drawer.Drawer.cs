using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw.Drawer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']"
	[global::Android.Runtime.Register ("com/rd/draw/drawer/Drawer", DoNotGenerateAcw=true)]
	public partial class Drawer : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/drawer/Drawer", typeof (Drawer));
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

		protected Drawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/constructor[@name='Drawer' and count(parameter)=1 and parameter[1][@type='com.rd.draw.data.Indicator']]"
		[Register (".ctor", "(Lcom/rd/draw/data/Indicator;)V", "")]
		public unsafe Drawer (global::Com.RD.Draw.Data.Indicator indicator)
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

		static Delegate cb_drawBasic_Landroid_graphics_Canvas_Z;
#pragma warning disable 0169
		static Delegate GetDrawBasic_Landroid_graphics_Canvas_ZHandler ()
		{
			if (cb_drawBasic_Landroid_graphics_Canvas_Z == null)
				cb_drawBasic_Landroid_graphics_Canvas_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_DrawBasic_Landroid_graphics_Canvas_Z);
			return cb_drawBasic_Landroid_graphics_Canvas_Z;
		}

		static void n_DrawBasic_Landroid_graphics_Canvas_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, bool isSelectedItem)
		{
			global::Com.RD.Draw.Drawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.DrawBasic (canvas, isSelectedItem);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/method[@name='drawBasic' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='boolean']]"
		[Register ("drawBasic", "(Landroid/graphics/Canvas;Z)V", "GetDrawBasic_Landroid_graphics_Canvas_ZHandler")]
		public virtual unsafe void DrawBasic (global::Android.Graphics.Canvas canvas, bool isSelectedItem)
		{
			const string __id = "drawBasic.(Landroid/graphics/Canvas;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue (isSelectedItem);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawColor_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
		static Delegate GetDrawColor_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler ()
		{
			if (cb_drawColor_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ == null)
				cb_drawColor_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawColor_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_);
			return cb_drawColor_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
		}

		static void n_DrawColor_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_value)
		{
			global::Com.RD.Draw.Drawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DrawColor (canvas, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/method[@name='drawColor' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.rd.animation.data.Value']]"
		[Register ("drawColor", "(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V", "GetDrawColor_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler")]
		public virtual unsafe void DrawColor (global::Android.Graphics.Canvas canvas, global::Com.RD.Animation.Data.IValue value)
		{
			const string __id = "drawColor.(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawDrop_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
		static Delegate GetDrawDrop_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler ()
		{
			if (cb_drawDrop_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ == null)
				cb_drawDrop_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawDrop_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_);
			return cb_drawDrop_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
		}

		static void n_DrawDrop_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_value)
		{
			global::Com.RD.Draw.Drawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DrawDrop (canvas, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/method[@name='drawDrop' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.rd.animation.data.Value']]"
		[Register ("drawDrop", "(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V", "GetDrawDrop_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler")]
		public virtual unsafe void DrawDrop (global::Android.Graphics.Canvas canvas, global::Com.RD.Animation.Data.IValue value)
		{
			const string __id = "drawDrop.(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawFill_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
		static Delegate GetDrawFill_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler ()
		{
			if (cb_drawFill_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ == null)
				cb_drawFill_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawFill_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_);
			return cb_drawFill_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
		}

		static void n_DrawFill_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_value)
		{
			global::Com.RD.Draw.Drawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DrawFill (canvas, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/method[@name='drawFill' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.rd.animation.data.Value']]"
		[Register ("drawFill", "(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V", "GetDrawFill_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler")]
		public virtual unsafe void DrawFill (global::Android.Graphics.Canvas canvas, global::Com.RD.Animation.Data.IValue value)
		{
			const string __id = "drawFill.(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawScale_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
		static Delegate GetDrawScale_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler ()
		{
			if (cb_drawScale_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ == null)
				cb_drawScale_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawScale_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_);
			return cb_drawScale_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
		}

		static void n_DrawScale_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_value)
		{
			global::Com.RD.Draw.Drawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DrawScale (canvas, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/method[@name='drawScale' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.rd.animation.data.Value']]"
		[Register ("drawScale", "(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V", "GetDrawScale_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler")]
		public virtual unsafe void DrawScale (global::Android.Graphics.Canvas canvas, global::Com.RD.Animation.Data.IValue value)
		{
			const string __id = "drawScale.(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawScaleDown_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
		static Delegate GetDrawScaleDown_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler ()
		{
			if (cb_drawScaleDown_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ == null)
				cb_drawScaleDown_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawScaleDown_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_);
			return cb_drawScaleDown_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
		}

		static void n_DrawScaleDown_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_value)
		{
			global::Com.RD.Draw.Drawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DrawScaleDown (canvas, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/method[@name='drawScaleDown' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.rd.animation.data.Value']]"
		[Register ("drawScaleDown", "(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V", "GetDrawScaleDown_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler")]
		public virtual unsafe void DrawScaleDown (global::Android.Graphics.Canvas canvas, global::Com.RD.Animation.Data.IValue value)
		{
			const string __id = "drawScaleDown.(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawSlide_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
		static Delegate GetDrawSlide_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler ()
		{
			if (cb_drawSlide_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ == null)
				cb_drawSlide_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawSlide_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_);
			return cb_drawSlide_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
		}

		static void n_DrawSlide_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_value)
		{
			global::Com.RD.Draw.Drawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DrawSlide (canvas, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/method[@name='drawSlide' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.rd.animation.data.Value']]"
		[Register ("drawSlide", "(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V", "GetDrawSlide_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler")]
		public virtual unsafe void DrawSlide (global::Android.Graphics.Canvas canvas, global::Com.RD.Animation.Data.IValue value)
		{
			const string __id = "drawSlide.(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawSwap_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
		static Delegate GetDrawSwap_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler ()
		{
			if (cb_drawSwap_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ == null)
				cb_drawSwap_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawSwap_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_);
			return cb_drawSwap_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
		}

		static void n_DrawSwap_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_value)
		{
			global::Com.RD.Draw.Drawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DrawSwap (canvas, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/method[@name='drawSwap' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.rd.animation.data.Value']]"
		[Register ("drawSwap", "(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V", "GetDrawSwap_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler")]
		public virtual unsafe void DrawSwap (global::Android.Graphics.Canvas canvas, global::Com.RD.Animation.Data.IValue value)
		{
			const string __id = "drawSwap.(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawThinWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
		static Delegate GetDrawThinWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler ()
		{
			if (cb_drawThinWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ == null)
				cb_drawThinWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawThinWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_);
			return cb_drawThinWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
		}

		static void n_DrawThinWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_value)
		{
			global::Com.RD.Draw.Drawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DrawThinWorm (canvas, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/method[@name='drawThinWorm' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.rd.animation.data.Value']]"
		[Register ("drawThinWorm", "(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V", "GetDrawThinWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler")]
		public virtual unsafe void DrawThinWorm (global::Android.Graphics.Canvas canvas, global::Com.RD.Animation.Data.IValue value)
		{
			const string __id = "drawThinWorm.(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
#pragma warning disable 0169
		static Delegate GetDrawWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler ()
		{
			if (cb_drawWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ == null)
				cb_drawWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_);
			return cb_drawWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_;
		}

		static void n_DrawWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_value)
		{
			global::Com.RD.Draw.Drawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DrawWorm (canvas, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/method[@name='drawWorm' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.rd.animation.data.Value']]"
		[Register ("drawWorm", "(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V", "GetDrawWorm_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_Handler")]
		public virtual unsafe void DrawWorm (global::Android.Graphics.Canvas canvas, global::Com.RD.Animation.Data.IValue value)
		{
			const string __id = "drawWorm.(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setup_III;
#pragma warning disable 0169
		static Delegate GetSetup_IIIHandler ()
		{
			if (cb_setup_III == null)
				cb_setup_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_Setup_III);
			return cb_setup_III;
		}

		static void n_Setup_III (IntPtr jnienv, IntPtr native__this, int position, int coordinateX, int coordinateY)
		{
			global::Com.RD.Draw.Drawer.Drawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Drawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Setup (position, coordinateX, coordinateY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer']/class[@name='Drawer']/method[@name='setup' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setup", "(III)V", "GetSetup_IIIHandler")]
		public virtual unsafe void Setup (int position, int coordinateX, int coordinateY)
		{
			const string __id = "setup.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (position);
				__args [1] = new JniArgumentValue (coordinateX);
				__args [2] = new JniArgumentValue (coordinateY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
