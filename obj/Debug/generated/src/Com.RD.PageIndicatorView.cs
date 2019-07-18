using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.RD {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']"
	[global::Android.Runtime.Register ("com/rd/PageIndicatorView", DoNotGenerateAcw=true)]
	public partial class PageIndicatorView : global::Android.Views.View, global::Android.Support.V4.View.ViewPager.IOnAdapterChangeListener, global::Android.Support.V4.View.ViewPager.IOnPageChangeListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/rd/PageIndicatorView", typeof (PageIndicatorView));
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

		protected PageIndicatorView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/constructor[@name='PageIndicatorView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PageIndicatorView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/constructor[@name='PageIndicatorView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PageIndicatorView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/constructor[@name='PageIndicatorView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe PageIndicatorView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/constructor[@name='PageIndicatorView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe PageIndicatorView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr, int defStyleRes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				__args [3] = new JniArgumentValue (defStyleRes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetAnimationDuration_J (IntPtr jnienv, IntPtr native__this, long duration)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimationDuration = duration;
		}
#pragma warning restore 0169

		public virtual unsafe long AnimationDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='getAnimationDuration' and count(parameter)=0]"
			[Register ("getAnimationDuration", "()J", "GetGetAnimationDurationHandler")]
			get {
				const string __id = "getAnimationDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setAnimationDuration' and count(parameter)=1 and parameter[1][@type='long']]"
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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Count = count;
		}
#pragma warning restore 0169

		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setCount' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetPadding_I (IntPtr jnienv, IntPtr native__this, int paddingDp)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Padding = paddingDp;
		}
#pragma warning restore 0169

		public virtual unsafe int Padding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()I", "GetGetPaddingHandler")]
			get {
				const string __id = "getPadding.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetRadius_I (IntPtr jnienv, IntPtr native__this, int radiusDp)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = radiusDp;
		}
#pragma warning restore 0169

		public virtual unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetScaleFactor_F (IntPtr jnienv, IntPtr native__this, float factor)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScaleFactor = factor;
		}
#pragma warning restore 0169

		public virtual unsafe float ScaleFactor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='getScaleFactor' and count(parameter)=0]"
			[Register ("getScaleFactor", "()F", "GetGetScaleFactorHandler")]
			get {
				const string __id = "getScaleFactor.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setScaleFactor' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetSelectedColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='getSelectedColor' and count(parameter)=0]"
			[Register ("getSelectedColor", "()I", "GetGetSelectedColorHandler")]
			get {
				const string __id = "getSelectedColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setSelectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getSelection;
#pragma warning disable 0169
		static Delegate GetGetSelectionHandler ()
		{
			if (cb_getSelection == null)
				cb_getSelection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelection);
			return cb_getSelection;
		}

		static int n_GetSelection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Selection;
		}
#pragma warning restore 0169

		static Delegate cb_setSelection_I;
#pragma warning disable 0169
		static Delegate GetSetSelection_IHandler ()
		{
			if (cb_setSelection_I == null)
				cb_setSelection_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelection_I);
			return cb_setSelection_I;
		}

		static void n_SetSelection_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Selection = position;
		}
#pragma warning restore 0169

		public virtual unsafe int Selection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='getSelection' and count(parameter)=0]"
			[Register ("getSelection", "()I", "GetGetSelectionHandler")]
			get {
				const string __id = "getSelection.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setSelection' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelection", "(I)V", "GetSetSelection_IHandler")]
			set {
				const string __id = "setSelection.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStrokeWidth;
#pragma warning disable 0169
		static Delegate GetGetStrokeWidthHandler ()
		{
			if (cb_getStrokeWidth == null)
				cb_getStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrokeWidth);
			return cb_getStrokeWidth;
		}

		static int n_GetStrokeWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setStrokeWidth_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeWidth_IHandler ()
		{
			if (cb_setStrokeWidth_I == null)
				cb_setStrokeWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStrokeWidth_I);
			return cb_setStrokeWidth_I;
		}

		static void n_SetStrokeWidth_I (IntPtr jnienv, IntPtr native__this, int strokeDp)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrokeWidth = strokeDp;
		}
#pragma warning restore 0169

		public virtual unsafe int StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()I", "GetGetStrokeWidthHandler")]
			get {
				const string __id = "getStrokeWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrokeWidth", "(I)V", "GetSetStrokeWidth_IHandler")]
			set {
				const string __id = "setStrokeWidth.(I)V";
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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetUnselectedColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnselectedColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int UnselectedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='getUnselectedColor' and count(parameter)=0]"
			[Register ("getUnselectedColor", "()I", "GetGetUnselectedColorHandler")]
			get {
				const string __id = "getUnselectedColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setUnselectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_clearSelection;
#pragma warning disable 0169
		static Delegate GetClearSelectionHandler ()
		{
			if (cb_clearSelection == null)
				cb_clearSelection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearSelection);
			return cb_clearSelection;
		}

		static void n_ClearSelection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearSelection ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='clearSelection' and count(parameter)=0]"
		[Register ("clearSelection", "()V", "GetClearSelectionHandler")]
		public virtual unsafe void ClearSelection ()
		{
			const string __id = "clearSelection.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onAdapterChanged_Landroid_support_v4_view_ViewPager_Landroid_support_v4_view_PagerAdapter_Landroid_support_v4_view_PagerAdapter_;
#pragma warning disable 0169
		static Delegate GetOnAdapterChanged_Landroid_support_v4_view_ViewPager_Landroid_support_v4_view_PagerAdapter_Landroid_support_v4_view_PagerAdapter_Handler ()
		{
			if (cb_onAdapterChanged_Landroid_support_v4_view_ViewPager_Landroid_support_v4_view_PagerAdapter_Landroid_support_v4_view_PagerAdapter_ == null)
				cb_onAdapterChanged_Landroid_support_v4_view_ViewPager_Landroid_support_v4_view_PagerAdapter_Landroid_support_v4_view_PagerAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdapterChanged_Landroid_support_v4_view_ViewPager_Landroid_support_v4_view_PagerAdapter_Landroid_support_v4_view_PagerAdapter_);
			return cb_onAdapterChanged_Landroid_support_v4_view_ViewPager_Landroid_support_v4_view_PagerAdapter_Landroid_support_v4_view_PagerAdapter_;
		}

		static void n_OnAdapterChanged_Landroid_support_v4_view_ViewPager_Landroid_support_v4_view_PagerAdapter_Landroid_support_v4_view_PagerAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_viewPager, IntPtr native_oldAdapter, IntPtr native_newAdapter)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager viewPager = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_viewPager, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.PagerAdapter oldAdapter = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.PagerAdapter> (native_oldAdapter, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.PagerAdapter newAdapter = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.PagerAdapter> (native_newAdapter, JniHandleOwnership.DoNotTransfer);
			__this.OnAdapterChanged (viewPager, oldAdapter, newAdapter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='onAdapterChanged' and count(parameter)=3 and parameter[1][@type='android.support.v4.view.ViewPager'] and parameter[2][@type='android.support.v4.view.PagerAdapter'] and parameter[3][@type='android.support.v4.view.PagerAdapter']]"
		[Register ("onAdapterChanged", "(Landroid/support/v4/view/ViewPager;Landroid/support/v4/view/PagerAdapter;Landroid/support/v4/view/PagerAdapter;)V", "GetOnAdapterChanged_Landroid_support_v4_view_ViewPager_Landroid_support_v4_view_PagerAdapter_Landroid_support_v4_view_PagerAdapter_Handler")]
		public virtual unsafe void OnAdapterChanged (global::Android.Support.V4.View.ViewPager viewPager, global::Android.Support.V4.View.PagerAdapter oldAdapter, global::Android.Support.V4.View.PagerAdapter newAdapter)
		{
			const string __id = "onAdapterChanged.(Landroid/support/v4/view/ViewPager;Landroid/support/v4/view/PagerAdapter;Landroid/support/v4/view/PagerAdapter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((viewPager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPager).Handle);
				__args [1] = new JniArgumentValue ((oldAdapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldAdapter).Handle);
				__args [2] = new JniArgumentValue ((newAdapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newAdapter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onIndicatorUpdated;
#pragma warning disable 0169
		static Delegate GetOnIndicatorUpdatedHandler ()
		{
			if (cb_onIndicatorUpdated == null)
				cb_onIndicatorUpdated = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnIndicatorUpdated);
			return cb_onIndicatorUpdated;
		}

		static void n_OnIndicatorUpdated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnIndicatorUpdated ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='onIndicatorUpdated' and count(parameter)=0]"
		[Register ("onIndicatorUpdated", "()V", "GetOnIndicatorUpdatedHandler")]
		public virtual unsafe void OnIndicatorUpdated ()
		{
			const string __id = "onIndicatorUpdated.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onPageScrollStateChanged_I;
#pragma warning disable 0169
		static Delegate GetOnPageScrollStateChanged_IHandler ()
		{
			if (cb_onPageScrollStateChanged_I == null)
				cb_onPageScrollStateChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageScrollStateChanged_I);
			return cb_onPageScrollStateChanged_I;
		}

		static void n_OnPageScrollStateChanged_I (IntPtr jnienv, IntPtr native__this, int state)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrollStateChanged (state);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='onPageScrollStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onPageScrollStateChanged", "(I)V", "GetOnPageScrollStateChanged_IHandler")]
		public virtual unsafe void OnPageScrollStateChanged (int state)
		{
			const string __id = "onPageScrollStateChanged.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (state);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onPageScrolled_IFI;
#pragma warning disable 0169
		static Delegate GetOnPageScrolled_IFIHandler ()
		{
			if (cb_onPageScrolled_IFI == null)
				cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, int>) n_OnPageScrolled_IFI);
			return cb_onPageScrolled_IFI;
		}

		static void n_OnPageScrolled_IFI (IntPtr jnienv, IntPtr native__this, int position, float positionOffset, int positionOffsetPixels)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrolled (position, positionOffset, positionOffsetPixels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='onPageScrolled' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register ("onPageScrolled", "(IFI)V", "GetOnPageScrolled_IFIHandler")]
		public virtual unsafe void OnPageScrolled (int position, float positionOffset, int positionOffsetPixels)
		{
			const string __id = "onPageScrolled.(IFI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (position);
				__args [1] = new JniArgumentValue (positionOffset);
				__args [2] = new JniArgumentValue (positionOffsetPixels);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onPageSelected_I;
#pragma warning disable 0169
		static Delegate GetOnPageSelected_IHandler ()
		{
			if (cb_onPageSelected_I == null)
				cb_onPageSelected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageSelected_I);
			return cb_onPageSelected_I;
		}

		static void n_OnPageSelected_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageSelected (position);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='onPageSelected' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onPageSelected", "(I)V", "GetOnPageSelected_IHandler")]
		public virtual unsafe void OnPageSelected (int position)
		{
			const string __id = "onPageSelected.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Parcelable_);
			return cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable state = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_state, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (state);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		public virtual unsafe void OnRestoreInstanceState (global::Android.OS.IParcelable state)
		{
			const string __id = "onRestoreInstanceState.(Landroid/os/Parcelable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((state == null) ? IntPtr.Zero : ((global::Java.Lang.Object) state).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceStateHandler ()
		{
			if (cb_onSaveInstanceState == null)
				cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState);
			return cb_onSaveInstanceState;
		}

		static IntPtr n_OnSaveInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='onSaveInstanceState' and count(parameter)=0]"
		[Register ("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public virtual unsafe global::Android.OS.IParcelable OnSaveInstanceState ()
		{
			const string __id = "onSaveInstanceState.()Landroid/os/Parcelable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_releaseViewPager;
#pragma warning disable 0169
		static Delegate GetReleaseViewPagerHandler ()
		{
			if (cb_releaseViewPager == null)
				cb_releaseViewPager = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseViewPager);
			return cb_releaseViewPager;
		}

		static void n_ReleaseViewPager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseViewPager ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='releaseViewPager' and count(parameter)=0]"
		[Register ("releaseViewPager", "()V", "GetReleaseViewPagerHandler")]
		public virtual unsafe void ReleaseViewPager ()
		{
			const string __id = "releaseViewPager.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setAnimationType_Lcom_rd_animation_type_AnimationType_;
#pragma warning disable 0169
		static Delegate GetSetAnimationType_Lcom_rd_animation_type_AnimationType_Handler ()
		{
			if (cb_setAnimationType_Lcom_rd_animation_type_AnimationType_ == null)
				cb_setAnimationType_Lcom_rd_animation_type_AnimationType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnimationType_Lcom_rd_animation_type_AnimationType_);
			return cb_setAnimationType_Lcom_rd_animation_type_AnimationType_;
		}

		static void n_SetAnimationType_Lcom_rd_animation_type_AnimationType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Animation.Type.AnimationType type = global::Java.Lang.Object.GetObject<global::Com.RD.Animation.Type.AnimationType> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationType (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setAnimationType' and count(parameter)=1 and parameter[1][@type='com.rd.animation.type.AnimationType']]"
		[Register ("setAnimationType", "(Lcom/rd/animation/type/AnimationType;)V", "GetSetAnimationType_Lcom_rd_animation_type_AnimationType_Handler")]
		public virtual unsafe void SetAnimationType (global::Com.RD.Animation.Type.AnimationType type)
		{
			const string __id = "setAnimationType.(Lcom/rd/animation/type/AnimationType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAutoVisibility (autoVisibility);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setAutoVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAutoVisibility", "(Z)V", "GetSetAutoVisibility_ZHandler")]
		public virtual unsafe void SetAutoVisibility (bool autoVisibility)
		{
			const string __id = "setAutoVisibility.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (autoVisibility);
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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Draw.Controller.DrawController.IClickListener listener = (global::Com.RD.Draw.Controller.DrawController.IClickListener)global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Controller.DrawController.IClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetClickListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setClickListener' and count(parameter)=1 and parameter[1][@type='com.rd.draw.controller.DrawController.ClickListener']]"
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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDynamicCount (dynamicCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setDynamicCount' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDynamicCount", "(Z)V", "GetSetDynamicCount_ZHandler")]
		public virtual unsafe void SetDynamicCount (bool dynamicCount)
		{
			const string __id = "setDynamicCount.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dynamicCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setInteractiveAnimation_Z;
#pragma warning disable 0169
		static Delegate GetSetInteractiveAnimation_ZHandler ()
		{
			if (cb_setInteractiveAnimation_Z == null)
				cb_setInteractiveAnimation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInteractiveAnimation_Z);
			return cb_setInteractiveAnimation_Z;
		}

		static void n_SetInteractiveAnimation_Z (IntPtr jnienv, IntPtr native__this, bool isInteractive)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInteractiveAnimation (isInteractive);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setInteractiveAnimation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setInteractiveAnimation", "(Z)V", "GetSetInteractiveAnimation_ZHandler")]
		public virtual unsafe void SetInteractiveAnimation (bool isInteractive)
		{
			const string __id = "setInteractiveAnimation.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isInteractive);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Draw.Data.Orientation orientation = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.Orientation> (native_orientation, JniHandleOwnership.DoNotTransfer);
			__this.SetOrientation (orientation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='com.rd.draw.data.Orientation']]"
		[Register ("setOrientation", "(Lcom/rd/draw/data/Orientation;)V", "GetSetOrientation_Lcom_rd_draw_data_Orientation_Handler")]
		public virtual unsafe void SetOrientation (global::Com.RD.Draw.Data.Orientation orientation)
		{
			const string __id = "setOrientation.(Lcom/rd/draw/data/Orientation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((orientation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) orientation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPadding_F;
#pragma warning disable 0169
		static Delegate GetSetPadding_FHandler ()
		{
			if (cb_setPadding_F == null)
				cb_setPadding_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPadding_F);
			return cb_setPadding_F;
		}

		static void n_SetPadding_F (IntPtr jnienv, IntPtr native__this, float paddingPx)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPadding (paddingPx);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setPadding", "(F)V", "GetSetPadding_FHandler")]
		public virtual unsafe void SetPadding (float paddingPx)
		{
			const string __id = "setPadding.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (paddingPx);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setProgress_IF;
#pragma warning disable 0169
		static Delegate GetSetProgress_IFHandler ()
		{
			if (cb_setProgress_IF == null)
				cb_setProgress_IF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float>) n_SetProgress_IF);
			return cb_setProgress_IF;
		}

		static void n_SetProgress_IF (IntPtr jnienv, IntPtr native__this, int selectingPosition, float progress)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProgress (selectingPosition, progress);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setProgress' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("setProgress", "(IF)V", "GetSetProgress_IFHandler")]
		public virtual unsafe void SetProgress (int selectingPosition, float progress)
		{
			const string __id = "setProgress.(IF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (selectingPosition);
				__args [1] = new JniArgumentValue (progress);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRadius_F;
#pragma warning disable 0169
		static Delegate GetSetRadius_FHandler ()
		{
			if (cb_setRadius_F == null)
				cb_setRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRadius_F);
			return cb_setRadius_F;
		}

		static void n_SetRadius_F (IntPtr jnienv, IntPtr native__this, float radiusPx)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (radiusPx);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRadius", "(F)V", "GetSetRadius_FHandler")]
		public virtual unsafe void SetRadius (float radiusPx)
		{
			const string __id = "setRadius.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (radiusPx);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRtlMode_Lcom_rd_draw_data_RtlMode_;
#pragma warning disable 0169
		static Delegate GetSetRtlMode_Lcom_rd_draw_data_RtlMode_Handler ()
		{
			if (cb_setRtlMode_Lcom_rd_draw_data_RtlMode_ == null)
				cb_setRtlMode_Lcom_rd_draw_data_RtlMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRtlMode_Lcom_rd_draw_data_RtlMode_);
			return cb_setRtlMode_Lcom_rd_draw_data_RtlMode_;
		}

		static void n_SetRtlMode_Lcom_rd_draw_data_RtlMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.RD.Draw.Data.RtlMode mode = global::Java.Lang.Object.GetObject<global::Com.RD.Draw.Data.RtlMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			__this.SetRtlMode (mode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setRtlMode' and count(parameter)=1 and parameter[1][@type='com.rd.draw.data.RtlMode']]"
		[Register ("setRtlMode", "(Lcom/rd/draw/data/RtlMode;)V", "GetSetRtlMode_Lcom_rd_draw_data_RtlMode_Handler")]
		public virtual unsafe void SetRtlMode (global::Com.RD.Draw.Data.RtlMode mode)
		{
			const string __id = "setRtlMode.(Lcom/rd/draw/data/RtlMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSelected_I;
#pragma warning disable 0169
		static Delegate GetSetSelected_IHandler ()
		{
			if (cb_setSelected_I == null)
				cb_setSelected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelected_I);
			return cb_setSelected_I;
		}

		static void n_SetSelected_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelected (position);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setSelected' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelected", "(I)V", "GetSetSelected_IHandler")]
		public virtual unsafe void SetSelected (int position)
		{
			const string __id = "setSelected.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setStrokeWidth_F;
#pragma warning disable 0169
		static Delegate GetSetStrokeWidth_FHandler ()
		{
			if (cb_setStrokeWidth_F == null)
				cb_setStrokeWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetStrokeWidth_F);
			return cb_setStrokeWidth_F;
		}

		static void n_SetStrokeWidth_F (IntPtr jnienv, IntPtr native__this, float strokePx)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStrokeWidth (strokePx);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setStrokeWidth", "(F)V", "GetSetStrokeWidth_FHandler")]
		public virtual unsafe void SetStrokeWidth (float strokePx)
		{
			const string __id = "setStrokeWidth.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (strokePx);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setViewPager_Landroid_support_v4_view_ViewPager_;
#pragma warning disable 0169
		static Delegate GetSetViewPager_Landroid_support_v4_view_ViewPager_Handler ()
		{
			if (cb_setViewPager_Landroid_support_v4_view_ViewPager_ == null)
				cb_setViewPager_Landroid_support_v4_view_ViewPager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetViewPager_Landroid_support_v4_view_ViewPager_);
			return cb_setViewPager_Landroid_support_v4_view_ViewPager_;
		}

		static void n_SetViewPager_Landroid_support_v4_view_ViewPager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pager)
		{
			global::Com.RD.PageIndicatorView __this = global::Java.Lang.Object.GetObject<global::Com.RD.PageIndicatorView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.View.ViewPager pager = global::Java.Lang.Object.GetObject<global::Android.Support.V4.View.ViewPager> (native_pager, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPager (pager);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.rd']/class[@name='PageIndicatorView']/method[@name='setViewPager' and count(parameter)=1 and parameter[1][@type='android.support.v4.view.ViewPager']]"
		[Register ("setViewPager", "(Landroid/support/v4/view/ViewPager;)V", "GetSetViewPager_Landroid_support_v4_view_ViewPager_Handler")]
		public virtual unsafe void SetViewPager (global::Android.Support.V4.View.ViewPager pager)
		{
			const string __id = "setViewPager.(Landroid/support/v4/view/ViewPager;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pager).Handle);
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
