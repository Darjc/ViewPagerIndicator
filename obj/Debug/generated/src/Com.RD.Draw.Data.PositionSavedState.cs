using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw.data']/class[@name='PositionSavedState']"
	[global::Android.Runtime.Register ("com/rd/draw/data/PositionSavedState", DoNotGenerateAcw=true)]
	public partial class PositionSavedState : global::Android.Views.View.BaseSavedState {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.data']/class[@name='PositionSavedState']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/data/PositionSavedState", typeof (PositionSavedState));
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

		protected PositionSavedState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.draw.data']/class[@name='PositionSavedState']/constructor[@name='PositionSavedState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register (".ctor", "(Landroid/os/Parcelable;)V", "")]
		public unsafe PositionSavedState (global::Android.OS.IParcelable superState)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcelable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((superState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) superState).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getLastSelectedPosition;
#pragma warning disable 0169
		static Delegate GetGetLastSelectedPositionHandler ()
		{
			if (cb_getLastSelectedPosition == null)
				cb_getLastSelectedPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastSelectedPosition);
			return cb_getLastSelectedPosition;
		}

		static int n_GetLastSelectedPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.PositionSavedState __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.PositionSavedState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastSelectedPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setLastSelectedPosition_I;
#pragma warning disable 0169
		static Delegate GetSetLastSelectedPosition_IHandler ()
		{
			if (cb_setLastSelectedPosition_I == null)
				cb_setLastSelectedPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLastSelectedPosition_I);
			return cb_setLastSelectedPosition_I;
		}

		static void n_SetLastSelectedPosition_I (IntPtr jnienv, IntPtr native__this, int lastSelectedPosition)
		{
			global::Com.RD.Draw.Data.PositionSavedState __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.PositionSavedState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastSelectedPosition = lastSelectedPosition;
		}
#pragma warning restore 0169

		public virtual unsafe int LastSelectedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='PositionSavedState']/method[@name='getLastSelectedPosition' and count(parameter)=0]"
			[Register ("getLastSelectedPosition", "()I", "GetGetLastSelectedPositionHandler")]
			get {
				const string __id = "getLastSelectedPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='PositionSavedState']/method[@name='setLastSelectedPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLastSelectedPosition", "(I)V", "GetSetLastSelectedPosition_IHandler")]
			set {
				const string __id = "setLastSelectedPosition.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedPosition;
#pragma warning disable 0169
		static Delegate GetGetSelectedPositionHandler ()
		{
			if (cb_getSelectedPosition == null)
				cb_getSelectedPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedPosition);
			return cb_getSelectedPosition;
		}

		static int n_GetSelectedPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.PositionSavedState __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.PositionSavedState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedPosition_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedPosition_IHandler ()
		{
			if (cb_setSelectedPosition_I == null)
				cb_setSelectedPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedPosition_I);
			return cb_setSelectedPosition_I;
		}

		static void n_SetSelectedPosition_I (IntPtr jnienv, IntPtr native__this, int selectedPosition)
		{
			global::Com.RD.Draw.Data.PositionSavedState __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.PositionSavedState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedPosition = selectedPosition;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='PositionSavedState']/method[@name='getSelectedPosition' and count(parameter)=0]"
			[Register ("getSelectedPosition", "()I", "GetGetSelectedPositionHandler")]
			get {
				const string __id = "getSelectedPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='PositionSavedState']/method[@name='setSelectedPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedPosition", "(I)V", "GetSetSelectedPosition_IHandler")]
			set {
				const string __id = "setSelectedPosition.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectingPosition;
#pragma warning disable 0169
		static Delegate GetGetSelectingPositionHandler ()
		{
			if (cb_getSelectingPosition == null)
				cb_getSelectingPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectingPosition);
			return cb_getSelectingPosition;
		}

		static int n_GetSelectingPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.PositionSavedState __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.PositionSavedState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectingPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectingPosition_I;
#pragma warning disable 0169
		static Delegate GetSetSelectingPosition_IHandler ()
		{
			if (cb_setSelectingPosition_I == null)
				cb_setSelectingPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectingPosition_I);
			return cb_setSelectingPosition_I;
		}

		static void n_SetSelectingPosition_I (IntPtr jnienv, IntPtr native__this, int selectingPosition)
		{
			global::Com.RD.Draw.Data.PositionSavedState __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.PositionSavedState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectingPosition = selectingPosition;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectingPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='PositionSavedState']/method[@name='getSelectingPosition' and count(parameter)=0]"
			[Register ("getSelectingPosition", "()I", "GetGetSelectingPositionHandler")]
			get {
				const string __id = "getSelectingPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='PositionSavedState']/method[@name='setSelectingPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectingPosition", "(I)V", "GetSetSelectingPosition_IHandler")]
			set {
				const string __id = "setSelectingPosition.(I)V";
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
