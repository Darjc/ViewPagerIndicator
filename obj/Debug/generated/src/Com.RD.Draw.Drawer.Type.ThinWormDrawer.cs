using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw.Drawer.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw.drawer.type']/class[@name='ThinWormDrawer']"
	[global::Android.Runtime.Register ("com/rd/draw/drawer/type/ThinWormDrawer", DoNotGenerateAcw=true)]
	public partial class ThinWormDrawer : global::Com.RD.Draw.Drawer.Type.WormDrawer {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/drawer/type/ThinWormDrawer", typeof (ThinWormDrawer));
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

		protected ThinWormDrawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.draw.drawer.type']/class[@name='ThinWormDrawer']/constructor[@name='ThinWormDrawer' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint'] and parameter[2][@type='com.rd.draw.data.Indicator']]"
		[Register (".ctor", "(Landroid/graphics/Paint;Lcom/rd/draw/data/Indicator;)V", "")]
		public unsafe ThinWormDrawer (global::Android.Graphics.Paint paint, global::Com.RD.Draw.Data.Indicator indicator)
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

	}
}
