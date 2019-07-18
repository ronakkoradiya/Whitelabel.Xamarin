using WhiteLabelApp.CustomControl;
using WhiteLabelApp.iOS.Renderers;
using CoreAnimation;
using CoreGraphics;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomStackLayout), typeof(CustomStackLayoutRenderer))]
namespace WhiteLabelApp.iOS.Renderers
{
   public class CustomStackLayoutRenderer : VisualElementRenderer<CustomStackLayout>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomStackLayout> e)
        {
            try
            {
                base.OnElementChanged(e);
                if (Element != null)
                {
                    Layer.CornerRadius = (nfloat)e.NewElement.CornerRadius;
                    Layer.BackgroundColor = e.NewElement.BackgroundColor.ToCGColor();
                    Layer.BorderColor = e.NewElement.StrokeColor.ToCGColor();
                    Layer.BorderWidth = (nfloat)e.NewElement.Stroke;
                    Layer.MasksToBounds = true;
                }
            }catch(Exception ex){
                
            }
        }

        public override void Draw(CGRect rect)
        {
            try
            {
                base.Draw(rect);
                var stack = (CustomStackLayout)this.Element;
                CGColor startColor = stack.StartColor.ToCGColor();

                CGColor endColor = stack.EndColor.ToCGColor();

                if (stack.StartColor != Color.Transparent && stack.EndColor != Color.Transparent)
                {
                    #region for Vertical Gradient

                    var gradientLayer = new CAGradientLayer();

                    #endregion

                    #region for Horizontal Gradient

                    //var gradientLayer = new CAGradientLayer()
                    //{
                    //  StartPoint = new CGPoint(0, 0.5),
                    //  EndPoint = new CGPoint(1, 0.5)
                    //};

                    #endregion

                    gradientLayer.Frame = rect;
                    gradientLayer.Colors = new CGColor[] { startColor, endColor };
                    NativeView.Layer.InsertSublayer(gradientLayer, 0);
                }
            }catch(Exception e){
                
            }
        }
    }
}
