using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw.Drawer.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw.drawer.type']/class[@name='WormDrawer']"
	[global::Android.Runtime.Register ("com/rd/draw/drawer/type/WormDrawer", DoNotGenerateAcw=true)]
	public partial class WormDrawer : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.drawer.type']/class[@name='WormDrawer']/field[@name='rect']"
		[Register ("rect")]
		public global::Android.Graphics.RectF Rect {
			get {
				const string __id = "rect.Landroid/graphics/RectF;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "rect.Landroid/graphics/RectF;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/drawer/type/WormDrawer", typeof (WormDrawer));
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

		protected WormDrawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.draw.drawer.type']/class[@name='WormDrawer']/constructor[@name='WormDrawer' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint'] and parameter[2][@type='com.rd.draw.data.Indicator']]"
		[Register (".ctor", "(Landroid/graphics/Paint;Lcom/rd/draw/data/Indicator;)V", "")]
		public unsafe WormDrawer (global::Android.Graphics.Paint paint, global::Com.RD.Draw.Data.Indicator indicator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/Paint;Lcom/rd/draw/data/Indicator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [1] = new JniArgumentValue ((indicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indicator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_II;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_IIHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_II == null)
				cb_draw_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_Draw_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_II);
			return cb_draw_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_II;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_II (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_value, int coordinateX, int coordinateY)
		{
			global::Com.RD.Draw.Drawer.Type.WormDrawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Type.WormDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Data.IValue value = (global::Com.RD.Animation.Data.IValue)global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.IValue> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas, value, coordinateX, coordinateY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer.type']/class[@name='WormDrawer']/method[@name='draw' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.rd.animation.data.Value'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;II)V", "GetDraw_Landroid_graphics_Canvas_Lcom_rd_animation_data_Value_IIHandler")]
		public virtual unsafe void Draw (global::Android.Graphics.Canvas canvas, global::Com.RD.Animation.Data.IValue value, int coordinateX, int coordinateY)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;Lcom/rd/animation/data/Value;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				__args [2] = new JniArgumentValue (coordinateX);
				__args [3] = new JniArgumentValue (coordinateY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
