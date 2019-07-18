using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw.Drawer.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw.drawer.type']/class[@name='BasicDrawer']"
	[global::Android.Runtime.Register ("com/rd/draw/drawer/type/BasicDrawer", DoNotGenerateAcw=true)]
	public partial class BasicDrawer : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/drawer/type/BasicDrawer", typeof (BasicDrawer));
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

		protected BasicDrawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.draw.drawer.type']/class[@name='BasicDrawer']/constructor[@name='BasicDrawer' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint'] and parameter[2][@type='com.rd.draw.data.Indicator']]"
		[Register (".ctor", "(Landroid/graphics/Paint;Lcom/rd/draw/data/Indicator;)V", "")]
		public unsafe BasicDrawer (global::Android.Graphics.Paint paint, global::Com.RD.Draw.Data.Indicator indicator)
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

		static Delegate cb_draw_Landroid_graphics_Canvas_IZII;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_IZIIHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_IZII == null)
				cb_draw_Landroid_graphics_Canvas_IZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool, int, int>) n_Draw_Landroid_graphics_Canvas_IZII);
			return cb_draw_Landroid_graphics_Canvas_IZII;
		}

		static void n_Draw_Landroid_graphics_Canvas_IZII (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, int position, bool isSelectedItem, int coordinateX, int coordinateY)
		{
			global::Com.RD.Draw.Drawer.Type.BasicDrawer __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Drawer.Type.BasicDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas, position, isSelectedItem, coordinateX, coordinateY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.drawer.type']/class[@name='BasicDrawer']/method[@name='draw' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("draw", "(Landroid/graphics/Canvas;IZII)V", "GetDraw_Landroid_graphics_Canvas_IZIIHandler")]
		public virtual unsafe void Draw (global::Android.Graphics.Canvas canvas, int position, bool isSelectedItem, int coordinateX, int coordinateY)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;IZII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue (position);
				__args [2] = new JniArgumentValue (isSelectedItem);
				__args [3] = new JniArgumentValue (coordinateX);
				__args [4] = new JniArgumentValue (coordinateY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
