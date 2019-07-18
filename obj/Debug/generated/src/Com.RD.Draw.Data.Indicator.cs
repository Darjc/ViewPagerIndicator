using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD.Draw.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']"
	[global::Android.Runtime.Register ("com/rd/draw/data/Indicator", DoNotGenerateAcw=true)]
	public partial class Indicator : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/field[@name='COUNT_NONE']"
		[Register ("COUNT_NONE")]
		public const int CountNone = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/field[@name='DEFAULT_COUNT']"
		[Register ("DEFAULT_COUNT")]
		public const int DefaultCount = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/field[@name='DEFAULT_PADDING_DP']"
		[Register ("DEFAULT_PADDING_DP")]
		public const int DefaultPaddingDp = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/field[@name='DEFAULT_RADIUS_DP']"
		[Register ("DEFAULT_RADIUS_DP")]
		public const int DefaultRadiusDp = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/field[@name='MIN_COUNT']"
		[Register ("MIN_COUNT")]
		public const int MinCount = (int) 1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/draw/data/Indicator", typeof (Indicator));
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

		protected Indicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/constructor[@name='Indicator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Indicator ()
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

		static Delegate cb_getAnimationDuration;
#pragma warning disable 0169
		static Delegate GetGetAnimationDurationHandler ()
		{
			if (cb_getAnimationDuration == null)
				cb_getAnimationDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAnimationDuration);
			return cb_getAnimationDuration;
		}

		static long n_GetAnimationDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnimationDuration;
		}
#pragma warning restore 0169

		static Delegate cb_setAnimationDuration_J;
#pragma warning disable 0169
		static Delegate GetSetAnimationDuration_JHandler ()
		{
			if (cb_setAnimationDuration_J == null)
				cb_setAnimationDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAnimationDuration_J);
			return cb_setAnimationDuration_J;
		}

		static void n_SetAnimationDuration_J (IntPtr jnienv, IntPtr native__this, long animationDuration)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimationDuration = animationDuration;
		}
#pragma warning restore 0169

		public virtual unsafe long AnimationDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getAnimationDuration' and count(parameter)=0]"
			[Register ("getAnimationDuration", "()J", "GetGetAnimationDurationHandler")]
			get {
				const string __id = "getAnimationDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setAnimationDuration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAnimationDuration", "(J)V", "GetSetAnimationDuration_JHandler")]
			set {
				const string __id = "setAnimationDuration.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAnimationType;
#pragma warning disable 0169
		static Delegate GetGetAnimationTypeHandler ()
		{
			if (cb_getAnimationType == null)
				cb_getAnimationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnimationType);
			return cb_getAnimationType;
		}

		static IntPtr n_GetAnimationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnimationType);
		}
#pragma warning restore 0169

		static Delegate cb_setAnimationType_Lcom_rd_animation_type_AnimationType_;
#pragma warning disable 0169
		static Delegate GetSetAnimationType_Lcom_rd_animation_type_AnimationType_Handler ()
		{
			if (cb_setAnimationType_Lcom_rd_animation_type_AnimationType_ == null)
				cb_setAnimationType_Lcom_rd_animation_type_AnimationType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnimationType_Lcom_rd_animation_type_AnimationType_);
			return cb_setAnimationType_Lcom_rd_animation_type_AnimationType_;
		}

		static void n_SetAnimationType_Lcom_rd_animation_type_AnimationType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animationType)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Type.AnimationType animationType = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (native_animationType, JniHandleOwnership.DoNotTransfer);
			__this.AnimationType = animationType;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.RD.Animation.Type.AnimationType AnimationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getAnimationType' and count(parameter)=0]"
			[Register ("getAnimationType", "()Lcom/rd/animation/type/AnimationType;", "GetGetAnimationTypeHandler")]
			get {
				const string __id = "getAnimationType.()Lcom/rd/animation/type/AnimationType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setAnimationType' and count(parameter)=1 and parameter[1][@type='com.rd.animation.type.AnimationType']]"
			[Register ("setAnimationType", "(Lcom/rd/animation/type/AnimationType;)V", "GetSetAnimationType_Lcom_rd_animation_type_AnimationType_Handler")]
			set {
				const string __id = "setAnimationType.(Lcom/rd/animation/type/AnimationType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAutoVisibility;
#pragma warning disable 0169
		static Delegate GetIsAutoVisibilityHandler ()
		{
			if (cb_isAutoVisibility == null)
				cb_isAutoVisibility = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoVisibility);
			return cb_isAutoVisibility;
		}

		static bool n_IsAutoVisibility (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoVisibility;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoVisibility_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoVisibility_ZHandler ()
		{
			if (cb_setAutoVisibility_Z == null)
				cb_setAutoVisibility_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoVisibility_Z);
			return cb_setAutoVisibility_Z;
		}

		static void n_SetAutoVisibility_Z (IntPtr jnienv, IntPtr native__this, bool autoVisibility)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoVisibility = autoVisibility;
		}
#pragma warning restore 0169

		public virtual unsafe bool AutoVisibility {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='isAutoVisibility' and count(parameter)=0]"
			[Register ("isAutoVisibility", "()Z", "GetIsAutoVisibilityHandler")]
			get {
				const string __id = "isAutoVisibility.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setAutoVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoVisibility", "(Z)V", "GetSetAutoVisibility_ZHandler")]
			set {
				const string __id = "setAutoVisibility.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static Delegate cb_setCount_I;
#pragma warning disable 0169
		static Delegate GetSetCount_IHandler ()
		{
			if (cb_setCount_I == null)
				cb_setCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCount_I);
			return cb_setCount_I;
		}

		static void n_SetCount_I (IntPtr jnienv, IntPtr native__this, int count)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Count = count;
		}
#pragma warning restore 0169

		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCount", "(I)V", "GetSetCount_IHandler")]
			set {
				const string __id = "setCount.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDynamicCount;
#pragma warning disable 0169
		static Delegate GetIsDynamicCountHandler ()
		{
			if (cb_isDynamicCount == null)
				cb_isDynamicCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDynamicCount);
			return cb_isDynamicCount;
		}

		static bool n_IsDynamicCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DynamicCount;
		}
#pragma warning restore 0169

		static Delegate cb_setDynamicCount_Z;
#pragma warning disable 0169
		static Delegate GetSetDynamicCount_ZHandler ()
		{
			if (cb_setDynamicCount_Z == null)
				cb_setDynamicCount_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDynamicCount_Z);
			return cb_setDynamicCount_Z;
		}

		static void n_SetDynamicCount_Z (IntPtr jnienv, IntPtr native__this, bool dynamicCount)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DynamicCount = dynamicCount;
		}
#pragma warning restore 0169

		public virtual unsafe bool DynamicCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='isDynamicCount' and count(parameter)=0]"
			[Register ("isDynamicCount", "()Z", "GetIsDynamicCountHandler")]
			get {
				const string __id = "isDynamicCount.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setDynamicCount' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDynamicCount", "(Z)V", "GetSetDynamicCount_ZHandler")]
			set {
				const string __id = "setDynamicCount.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static Delegate cb_setHeight_I;
#pragma warning disable 0169
		static Delegate GetSetHeight_IHandler ()
		{
			if (cb_setHeight_I == null)
				cb_setHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeight_I);
			return cb_setHeight_I;
		}

		static void n_SetHeight_I (IntPtr jnienv, IntPtr native__this, int height)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Height = height;
		}
#pragma warning restore 0169

		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				const string __id = "getHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeight", "(I)V", "GetSetHeight_IHandler")]
			set {
				const string __id = "setHeight.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isInteractiveAnimation;
#pragma warning disable 0169
		static Delegate GetIsInteractiveAnimationHandler ()
		{
			if (cb_isInteractiveAnimation == null)
				cb_isInteractiveAnimation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInteractiveAnimation);
			return cb_isInteractiveAnimation;
		}

		static bool n_IsInteractiveAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InteractiveAnimation;
		}
#pragma warning restore 0169

		static Delegate cb_setInteractiveAnimation_Z;
#pragma warning disable 0169
		static Delegate GetSetInteractiveAnimation_ZHandler ()
		{
			if (cb_setInteractiveAnimation_Z == null)
				cb_setInteractiveAnimation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInteractiveAnimation_Z);
			return cb_setInteractiveAnimation_Z;
		}

		static void n_SetInteractiveAnimation_Z (IntPtr jnienv, IntPtr native__this, bool interactiveAnimation)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InteractiveAnimation = interactiveAnimation;
		}
#pragma warning restore 0169

		public virtual unsafe bool InteractiveAnimation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='isInteractiveAnimation' and count(parameter)=0]"
			[Register ("isInteractiveAnimation", "()Z", "GetIsInteractiveAnimationHandler")]
			get {
				const string __id = "isInteractiveAnimation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setInteractiveAnimation' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setInteractiveAnimation", "(Z)V", "GetSetInteractiveAnimation_ZHandler")]
			set {
				const string __id = "setInteractiveAnimation.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastSelectedPosition = lastSelectedPosition;
		}
#pragma warning restore 0169

		public virtual unsafe int LastSelectedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getLastSelectedPosition' and count(parameter)=0]"
			[Register ("getLastSelectedPosition", "()I", "GetGetLastSelectedPositionHandler")]
			get {
				const string __id = "getLastSelectedPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setLastSelectedPosition' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrientation);
			return cb_getOrientation;
		}

		static IntPtr n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Orientation);
		}
#pragma warning restore 0169

		static Delegate cb_setOrientation_Lcom_rd_draw_data_Orientation_;
#pragma warning disable 0169
		static Delegate GetSetOrientation_Lcom_rd_draw_data_Orientation_Handler ()
		{
			if (cb_setOrientation_Lcom_rd_draw_data_Orientation_ == null)
				cb_setOrientation_Lcom_rd_draw_data_Orientation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrientation_Lcom_rd_draw_data_Orientation_);
			return cb_setOrientation_Lcom_rd_draw_data_Orientation_;
		}

		static void n_SetOrientation_Lcom_rd_draw_data_Orientation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_orientation)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Draw.Data.Orientation orientation = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Orientation> (native_orientation, JniHandleOwnership.DoNotTransfer);
			__this.Orientation = orientation;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.RD.Draw.Data.Orientation Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()Lcom/rd/draw/data/Orientation;", "GetGetOrientationHandler")]
			get {
				const string __id = "getOrientation.()Lcom/rd/draw/data/Orientation;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Orientation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='com.rd.draw.data.Orientation']]"
			[Register ("setOrientation", "(Lcom/rd/draw/data/Orientation;)V", "GetSetOrientation_Lcom_rd_draw_data_Orientation_Handler")]
			set {
				const string __id = "setOrientation.(Lcom/rd/draw/data/Orientation;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPadding;
#pragma warning disable 0169
		static Delegate GetGetPaddingHandler ()
		{
			if (cb_getPadding == null)
				cb_getPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPadding);
			return cb_getPadding;
		}

		static int n_GetPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Padding;
		}
#pragma warning restore 0169

		static Delegate cb_setPadding_I;
#pragma warning disable 0169
		static Delegate GetSetPadding_IHandler ()
		{
			if (cb_setPadding_I == null)
				cb_setPadding_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPadding_I);
			return cb_setPadding_I;
		}

		static void n_SetPadding_I (IntPtr jnienv, IntPtr native__this, int padding)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Padding = padding;
		}
#pragma warning restore 0169

		public virtual unsafe int Padding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()I", "GetGetPaddingHandler")]
			get {
				const string __id = "getPadding.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPadding", "(I)V", "GetSetPadding_IHandler")]
			set {
				const string __id = "setPadding.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPaddingBottom;
#pragma warning disable 0169
		static Delegate GetGetPaddingBottomHandler ()
		{
			if (cb_getPaddingBottom == null)
				cb_getPaddingBottom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPaddingBottom);
			return cb_getPaddingBottom;
		}

		static int n_GetPaddingBottom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PaddingBottom;
		}
#pragma warning restore 0169

		static Delegate cb_setPaddingBottom_I;
#pragma warning disable 0169
		static Delegate GetSetPaddingBottom_IHandler ()
		{
			if (cb_setPaddingBottom_I == null)
				cb_setPaddingBottom_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPaddingBottom_I);
			return cb_setPaddingBottom_I;
		}

		static void n_SetPaddingBottom_I (IntPtr jnienv, IntPtr native__this, int paddingBottom)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PaddingBottom = paddingBottom;
		}
#pragma warning restore 0169

		public virtual unsafe int PaddingBottom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getPaddingBottom' and count(parameter)=0]"
			[Register ("getPaddingBottom", "()I", "GetGetPaddingBottomHandler")]
			get {
				const string __id = "getPaddingBottom.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setPaddingBottom' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPaddingBottom", "(I)V", "GetSetPaddingBottom_IHandler")]
			set {
				const string __id = "setPaddingBottom.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPaddingLeft;
#pragma warning disable 0169
		static Delegate GetGetPaddingLeftHandler ()
		{
			if (cb_getPaddingLeft == null)
				cb_getPaddingLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPaddingLeft);
			return cb_getPaddingLeft;
		}

		static int n_GetPaddingLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PaddingLeft;
		}
#pragma warning restore 0169

		static Delegate cb_setPaddingLeft_I;
#pragma warning disable 0169
		static Delegate GetSetPaddingLeft_IHandler ()
		{
			if (cb_setPaddingLeft_I == null)
				cb_setPaddingLeft_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPaddingLeft_I);
			return cb_setPaddingLeft_I;
		}

		static void n_SetPaddingLeft_I (IntPtr jnienv, IntPtr native__this, int paddingLeft)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PaddingLeft = paddingLeft;
		}
#pragma warning restore 0169

		public virtual unsafe int PaddingLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getPaddingLeft' and count(parameter)=0]"
			[Register ("getPaddingLeft", "()I", "GetGetPaddingLeftHandler")]
			get {
				const string __id = "getPaddingLeft.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setPaddingLeft' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPaddingLeft", "(I)V", "GetSetPaddingLeft_IHandler")]
			set {
				const string __id = "setPaddingLeft.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPaddingRight;
#pragma warning disable 0169
		static Delegate GetGetPaddingRightHandler ()
		{
			if (cb_getPaddingRight == null)
				cb_getPaddingRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPaddingRight);
			return cb_getPaddingRight;
		}

		static int n_GetPaddingRight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PaddingRight;
		}
#pragma warning restore 0169

		static Delegate cb_setPaddingRight_I;
#pragma warning disable 0169
		static Delegate GetSetPaddingRight_IHandler ()
		{
			if (cb_setPaddingRight_I == null)
				cb_setPaddingRight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPaddingRight_I);
			return cb_setPaddingRight_I;
		}

		static void n_SetPaddingRight_I (IntPtr jnienv, IntPtr native__this, int paddingRight)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PaddingRight = paddingRight;
		}
#pragma warning restore 0169

		public virtual unsafe int PaddingRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getPaddingRight' and count(parameter)=0]"
			[Register ("getPaddingRight", "()I", "GetGetPaddingRightHandler")]
			get {
				const string __id = "getPaddingRight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setPaddingRight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPaddingRight", "(I)V", "GetSetPaddingRight_IHandler")]
			set {
				const string __id = "setPaddingRight.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPaddingTop;
#pragma warning disable 0169
		static Delegate GetGetPaddingTopHandler ()
		{
			if (cb_getPaddingTop == null)
				cb_getPaddingTop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPaddingTop);
			return cb_getPaddingTop;
		}

		static int n_GetPaddingTop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PaddingTop;
		}
#pragma warning restore 0169

		static Delegate cb_setPaddingTop_I;
#pragma warning disable 0169
		static Delegate GetSetPaddingTop_IHandler ()
		{
			if (cb_setPaddingTop_I == null)
				cb_setPaddingTop_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPaddingTop_I);
			return cb_setPaddingTop_I;
		}

		static void n_SetPaddingTop_I (IntPtr jnienv, IntPtr native__this, int paddingTop)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PaddingTop = paddingTop;
		}
#pragma warning restore 0169

		public virtual unsafe int PaddingTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getPaddingTop' and count(parameter)=0]"
			[Register ("getPaddingTop", "()I", "GetGetPaddingTopHandler")]
			get {
				const string __id = "getPaddingTop.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setPaddingTop' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPaddingTop", "(I)V", "GetSetPaddingTop_IHandler")]
			set {
				const string __id = "setPaddingTop.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRadius);
			return cb_getRadius;
		}

		static int n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		static Delegate cb_setRadius_I;
#pragma warning disable 0169
		static Delegate GetSetRadius_IHandler ()
		{
			if (cb_setRadius_I == null)
				cb_setRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRadius_I);
			return cb_setRadius_I;
		}

		static void n_SetRadius_I (IntPtr jnienv, IntPtr native__this, int radius)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = radius;
		}
#pragma warning restore 0169

		public virtual unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRadius", "(I)V", "GetSetRadius_IHandler")]
			set {
				const string __id = "setRadius.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRtlMode;
#pragma warning disable 0169
		static Delegate GetGetRtlModeHandler ()
		{
			if (cb_getRtlMode == null)
				cb_getRtlMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRtlMode);
			return cb_getRtlMode;
		}

		static IntPtr n_GetRtlMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RtlMode);
		}
#pragma warning restore 0169

		static Delegate cb_setRtlMode_Lcom_rd_draw_data_RtlMode_;
#pragma warning disable 0169
		static Delegate GetSetRtlMode_Lcom_rd_draw_data_RtlMode_Handler ()
		{
			if (cb_setRtlMode_Lcom_rd_draw_data_RtlMode_ == null)
				cb_setRtlMode_Lcom_rd_draw_data_RtlMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRtlMode_Lcom_rd_draw_data_RtlMode_);
			return cb_setRtlMode_Lcom_rd_draw_data_RtlMode_;
		}

		static void n_SetRtlMode_Lcom_rd_draw_data_RtlMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rtlMode)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Draw.Data.RtlMode rtlMode = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.RtlMode> (native_rtlMode, JniHandleOwnership.DoNotTransfer);
			__this.RtlMode = rtlMode;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.RD.Draw.Data.RtlMode RtlMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getRtlMode' and count(parameter)=0]"
			[Register ("getRtlMode", "()Lcom/rd/draw/data/RtlMode;", "GetGetRtlModeHandler")]
			get {
				const string __id = "getRtlMode.()Lcom/rd/draw/data/RtlMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.RtlMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setRtlMode' and count(parameter)=1 and parameter[1][@type='com.rd.draw.data.RtlMode']]"
			[Register ("setRtlMode", "(Lcom/rd/draw/data/RtlMode;)V", "GetSetRtlMode_Lcom_rd_draw_data_RtlMode_Handler")]
			set {
				const string __id = "setRtlMode.(Lcom/rd/draw/data/RtlMode;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleFactor;
#pragma warning disable 0169
		static Delegate GetGetScaleFactorHandler ()
		{
			if (cb_getScaleFactor == null)
				cb_getScaleFactor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScaleFactor);
			return cb_getScaleFactor;
		}

		static float n_GetScaleFactor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleFactor;
		}
#pragma warning restore 0169

		static Delegate cb_setScaleFactor_F;
#pragma warning disable 0169
		static Delegate GetSetScaleFactor_FHandler ()
		{
			if (cb_setScaleFactor_F == null)
				cb_setScaleFactor_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScaleFactor_F);
			return cb_setScaleFactor_F;
		}

		static void n_SetScaleFactor_F (IntPtr jnienv, IntPtr native__this, float scaleFactor)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScaleFactor = scaleFactor;
		}
#pragma warning restore 0169

		public virtual unsafe float ScaleFactor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getScaleFactor' and count(parameter)=0]"
			[Register ("getScaleFactor", "()F", "GetGetScaleFactorHandler")]
			get {
				const string __id = "getScaleFactor.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setScaleFactor' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setScaleFactor", "(F)V", "GetSetScaleFactor_FHandler")]
			set {
				const string __id = "setScaleFactor.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedColorHandler ()
		{
			if (cb_getSelectedColor == null)
				cb_getSelectedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedColor);
			return cb_getSelectedColor;
		}

		static int n_GetSelectedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedColor_IHandler ()
		{
			if (cb_setSelectedColor_I == null)
				cb_setSelectedColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedColor_I);
			return cb_setSelectedColor_I;
		}

		static void n_SetSelectedColor_I (IntPtr jnienv, IntPtr native__this, int selectedColor)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedColor = selectedColor;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getSelectedColor' and count(parameter)=0]"
			[Register ("getSelectedColor", "()I", "GetGetSelectedColorHandler")]
			get {
				const string __id = "getSelectedColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setSelectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedColor", "(I)V", "GetSetSelectedColor_IHandler")]
			set {
				const string __id = "setSelectedColor.(I)V";
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
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedPosition = selectedPosition;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getSelectedPosition' and count(parameter)=0]"
			[Register ("getSelectedPosition", "()I", "GetGetSelectedPositionHandler")]
			get {
				const string __id = "getSelectedPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setSelectedPosition' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectingPosition = selectingPosition;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectingPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getSelectingPosition' and count(parameter)=0]"
			[Register ("getSelectingPosition", "()I", "GetGetSelectingPositionHandler")]
			get {
				const string __id = "getSelectingPosition.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setSelectingPosition' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getStroke;
#pragma warning disable 0169
		static Delegate GetGetStrokeHandler ()
		{
			if (cb_getStroke == null)
				cb_getStroke = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStroke);
			return cb_getStroke;
		}

		static int n_GetStroke (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Stroke;
		}
#pragma warning restore 0169

		static Delegate cb_setStroke_I;
#pragma warning disable 0169
		static Delegate GetSetStroke_IHandler ()
		{
			if (cb_setStroke_I == null)
				cb_setStroke_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStroke_I);
			return cb_setStroke_I;
		}

		static void n_SetStroke_I (IntPtr jnienv, IntPtr native__this, int stroke)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stroke = stroke;
		}
#pragma warning restore 0169

		public virtual unsafe int Stroke {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getStroke' and count(parameter)=0]"
			[Register ("getStroke", "()I", "GetGetStrokeHandler")]
			get {
				const string __id = "getStroke.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setStroke' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStroke", "(I)V", "GetSetStroke_IHandler")]
			set {
				const string __id = "setStroke.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUnselectedColor;
#pragma warning disable 0169
		static Delegate GetGetUnselectedColorHandler ()
		{
			if (cb_getUnselectedColor == null)
				cb_getUnselectedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnselectedColor);
			return cb_getUnselectedColor;
		}

		static int n_GetUnselectedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnselectedColor;
		}
#pragma warning restore 0169

		static Delegate cb_setUnselectedColor_I;
#pragma warning disable 0169
		static Delegate GetSetUnselectedColor_IHandler ()
		{
			if (cb_setUnselectedColor_I == null)
				cb_setUnselectedColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUnselectedColor_I);
			return cb_setUnselectedColor_I;
		}

		static void n_SetUnselectedColor_I (IntPtr jnienv, IntPtr native__this, int unselectedColor)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnselectedColor = unselectedColor;
		}
#pragma warning restore 0169

		public virtual unsafe int UnselectedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getUnselectedColor' and count(parameter)=0]"
			[Register ("getUnselectedColor", "()I", "GetGetUnselectedColorHandler")]
			get {
				const string __id = "getUnselectedColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setUnselectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUnselectedColor", "(I)V", "GetSetUnselectedColor_IHandler")]
			set {
				const string __id = "setUnselectedColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getViewPagerId;
#pragma warning disable 0169
		static Delegate GetGetViewPagerIdHandler ()
		{
			if (cb_getViewPagerId == null)
				cb_getViewPagerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetViewPagerId);
			return cb_getViewPagerId;
		}

		static int n_GetViewPagerId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ViewPagerId;
		}
#pragma warning restore 0169

		static Delegate cb_setViewPagerId_I;
#pragma warning disable 0169
		static Delegate GetSetViewPagerId_IHandler ()
		{
			if (cb_setViewPagerId_I == null)
				cb_setViewPagerId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetViewPagerId_I);
			return cb_setViewPagerId_I;
		}

		static void n_SetViewPagerId_I (IntPtr jnienv, IntPtr native__this, int viewPagerId)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ViewPagerId = viewPagerId;
		}
#pragma warning restore 0169

		public virtual unsafe int ViewPagerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getViewPagerId' and count(parameter)=0]"
			[Register ("getViewPagerId", "()I", "GetGetViewPagerIdHandler")]
			get {
				const string __id = "getViewPagerId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setViewPagerId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setViewPagerId", "(I)V", "GetSetViewPagerId_IHandler")]
			set {
				const string __id = "setViewPagerId.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_I;
#pragma warning disable 0169
		static Delegate GetSetWidth_IHandler ()
		{
			if (cb_setWidth_I == null)
				cb_setWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWidth_I);
			return cb_setWidth_I;
		}

		static void n_SetWidth_I (IntPtr jnienv, IntPtr native__this, int width)
		{
			global::Com.RD.Draw.Data.Indicator __this = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Indicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = width;
		}
#pragma warning restore 0169

		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd.draw.data']/class[@name='Indicator']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWidth", "(I)V", "GetSetWidth_IHandler")]
			set {
				const string __id = "setWidth.(I)V";
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
