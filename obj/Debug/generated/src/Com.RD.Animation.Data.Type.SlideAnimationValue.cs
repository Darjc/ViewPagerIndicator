using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Animation.Data.Type {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='SlideAnimationValue']"
	[global::Android.Runtime.Register ("com/rd/animation/data/type/SlideAnimationValue", DoNotGenerateAcw=true)]
	public partial class SlideAnimationValue : global::Java.Lang.Object, global::Com.RD.Animation.Data.IValue {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/animation/data/type/SlideAnimationValue", typeof (SlideAnimationValue));
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

		protected SlideAnimationValue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='SlideAnimationValue']/constructor[@name='SlideAnimationValue' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SlideAnimationValue ()
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

		static Delegate cb_getCoordinate;
#pragma warning disable 0169
		static Delegate GetGetCoordinateHandler ()
		{
			if (cb_getCoordinate == null)
				cb_getCoordinate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCoordinate);
			return cb_getCoordinate;
		}

		static int n_GetCoordinate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Animation.Data.Type.SlideAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.SlideAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Coordinate;
		}
#pragma warning restore 0169

		static Delegate cb_setCoordinate_I;
#pragma warning disable 0169
		static Delegate GetSetCoordinate_IHandler ()
		{
			if (cb_setCoordinate_I == null)
				cb_setCoordinate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCoordinate_I);
			return cb_setCoordinate_I;
		}

		static void n_SetCoordinate_I (IntPtr jnienv, IntPtr native__this, int coordinate)
		{
			global::Com.RD.Animation.Data.Type.SlideAnimationValue __this = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Data.Type.SlideAnimationValue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Coordinate = coordinate;
		}
#pragma warning restore 0169

		public virtual unsafe int Coordinate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='SlideAnimationValue']/method[@name='getCoordinate' and count(parameter)=0]"
			[Register ("getCoordinate", "()I", "GetGetCoordinateHandler")]
			get {
				const string __id = "getCoordinate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.animation.data.type']/class[@name='SlideAnimationValue']/method[@name='setCoordinate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCoordinate", "(I)V", "GetSetCoordinate_IHandler")]
			set {
				const string __id = "setCoordinate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
