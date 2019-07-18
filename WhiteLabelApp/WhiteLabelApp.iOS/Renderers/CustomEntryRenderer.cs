using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using WhiteLabelApp.CustomControl;
using WhiteLabelApp.iOS.Renderers;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace WhiteLabelApp.iOS.Renderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null && e.NewElement != null)
            {
                Control.Layer.BorderWidth = 0;
                Control.TintColor = e.NewElement.TextColor.ToUIColor();
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
                Control.Layer.MasksToBounds = true;
            }
        }
    }
}
