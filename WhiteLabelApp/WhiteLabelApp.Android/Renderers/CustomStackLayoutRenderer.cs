using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using WhiteLabelApp.CustomControl;
using Xamarin.Forms;
using WhiteLabelApp.Droid.Renderers;
using Android.Graphics.Drawables;
using Android.Content.Res;

[assembly: ExportRenderer(typeof(CustomStackLayout), typeof(CustomStackLayoutRenderer))]
namespace WhiteLabelApp.Droid.Renderers
{
   public class CustomStackLayoutRenderer : VisualElementRenderer<CustomStackLayout>
    {
        private GradientDrawable _normal;
        private Color StartColor { get; set; }
        private Color EndColor { get; set; }

        public CustomStackLayoutRenderer(Context context) : base(context)
        {

        }

        protected override void DispatchDraw(global::Android.Graphics.Canvas canvas)
        {
            #region for Vertical Gradient
            //var gradient = new Android.Graphics.LinearGradient(0, 0, 0, Height,
            #endregion

            #region for Horizontal Gradient
            var gradient = new Android.Graphics.LinearGradient(0, 0, Width, 0,
            #endregion

                   this.StartColor.ToAndroid(),
                   this.EndColor.ToAndroid(),
                   Android.Graphics.Shader.TileMode.Mirror);

            var paint = new Android.Graphics.Paint()
            {
                Dither = true,
            };
            paint.SetShader(gradient);
            canvas.DrawPaint(paint);
            base.DispatchDraw(canvas);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CustomStackLayout> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }
            try
            {
                var stack = e.NewElement as CustomStackLayout;
                this.StartColor = stack.StartColor;
                this.EndColor = stack.EndColor;

                _normal = new GradientDrawable();
                _normal.SetColor(e.NewElement.BackgroundColor.ToAndroid());

                _normal.SetStroke((int)e.NewElement.Stroke, e.NewElement.StrokeColor.ToAndroid());
                _normal.SetCornerRadius((float)e.NewElement.CornerRadius * 2);

                this.Background = _normal;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(@"ERROR:", ex.Message);
            }

            //if (e.NewElement != null)
            //{
            //    //ColorStateList colorStateList;
            //    this.StartColor = e.NewElement.StartColor;
            //    this.EndColor = e.NewElement.EndColor;
            //    _normal = new GradientDrawable();

            //    //if (this.StartColor != Xamarin.Forms.Color.Transparent &&
            //    //    this.EndColor != Xamarin.Forms.Color.Transparent)
            //    //{
            //    //    //colorStateList=new ColorStateList(new int[1][], new int[] {StartColor.ToAndroid(),EndColor.ToAndroid()});
            //    //    _normal.SetColors(new int[] {StartColor.ToAndroid(),EndColor.ToAndroid()});
            //    //}
            //    //else
            //    //{
            //    //    _normal.SetColor(e.NewElement.BackgroundColor.ToAndroid());
            //    //}
            //    _normal.SetColor(e.NewElement.BackgroundColor.ToAndroid());

            //    _normal.SetStroke((int)e.NewElement.Stroke, e.NewElement.StrokeColor.ToAndroid());
            //    _normal.SetCornerRadius((float)e.NewElement.CornerRadius * 2);

            //    this.Background = _normal;
            //}
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            //this.Invalidate();
        }
    }
}