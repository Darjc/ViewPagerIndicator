using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.utils']/class[@name='CoordinatesUtils']"
	[global::Android.Runtime.Register ("com/rd/utils/CoordinatesUtils", DoNotGenerateAcw=true)]
	public partial class CoordinatesUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/utils/CoordinatesUtils", typeof (CoordinatesUtils));
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

		protected CoordinatesUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.utils']/class[@name='CoordinatesUtils']/constructor[@name='CoordinatesUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoordinatesUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.utils']/class[@name='CoordinatesUtils']/method[@name='getCoordinate' and count(parameter)=2 and parameter[1][@type='com.rd.draw.data.Indicator'] and parameter[2][@type='int']]"
		[Register ("getCoordinate", "(Lcom/rd/draw/data/Indicator;I)I", "")]
		public static unsafe int GetCoordinate (global::Com.RD.Draw.Data.Indicator indicator, int position)
		{
			const string __id = "getCoordinate.(Lcom/rd/draw/data/Indicator;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((indicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indicator).Handle);
				__args [1] = new JniArgumentValue (position);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.utils']/class[@name='CoordinatesUtils']/method[@name='getPosition' and count(parameter)=3 and parameter[1][@type='com.rd.draw.data.Indicator'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("getPosition", "(Lcom/rd/draw/data/Indicator;FF)I", "")]
		public static unsafe int GetPosition (global::Com.RD.Draw.Data.Indicator indicator, float x, float y)
		{
			const string __id = "getPosition.(Lcom/rd/draw/data/Indicator;FF)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((indicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indicator).Handle);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.utils']/class[@name='CoordinatesUtils']/method[@name='getProgress' and count(parameter)=4 and parameter[1][@type='com.rd.draw.data.Indicator'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='boolean']]"
		[Register ("getProgress", "(Lcom/rd/draw/data/Indicator;IFZ)Landroid/util/Pair;", "")]
		public static unsafe global::Android.Util.Pair GetProgress (global::Com.RD.Draw.Data.Indicator indicator, int position, float positionOffset, bool isRtl)
		{
			const string __id = "getProgress.(Lcom/rd/draw/data/Indicator;IFZ)Landroid/util/Pair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((indicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indicator).Handle);
				__args [1] = new JniArgumentValue (position);
				__args [2] = new JniArgumentValue (positionOffset);
				__args [3] = new JniArgumentValue (isRtl);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.utils']/class[@name='CoordinatesUtils']/method[@name='getXCoordinate' and count(parameter)=2 and parameter[1][@type='com.rd.draw.data.Indicator'] and parameter[2][@type='int']]"
		[Register ("getXCoordinate", "(Lcom/rd/draw/data/Indicator;I)I", "")]
		public static unsafe int GetXCoordinate (global::Com.RD.Draw.Data.Indicator indicator, int position)
		{
			const string __id = "getXCoordinate.(Lcom/rd/draw/data/Indicator;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((indicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indicator).Handle);
				__args [1] = new JniArgumentValue (position);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.utils']/class[@name='CoordinatesUtils']/method[@name='getYCoordinate' and count(parameter)=2 and parameter[1][@type='com.rd.draw.data.Indicator'] and parameter[2][@type='int']]"
		[Register ("getYCoordinate", "(Lcom/rd/draw/data/Indicator;I)I", "")]
		public static unsafe int GetYCoordinate (global::Com.RD.Draw.Data.Indicator indicator, int position)
		{
			const string __id = "getYCoordinate.(Lcom/rd/draw/data/Indicator;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((indicator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) indicator).Handle);
				__args [1] = new JniArgumentValue (position);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
