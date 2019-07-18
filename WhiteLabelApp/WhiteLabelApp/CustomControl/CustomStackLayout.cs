using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WhiteLabelApp.CustomControl
{
   public class CustomStackLayout : StackLayout
    {
        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(
            propertyName: nameof(CornerRadius),
            returnType: typeof(double),
            declaringType: typeof(CustomStackLayout),
            defaultValue: 0.0,
            defaultBindingMode: BindingMode.TwoWay
        );

        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty StrokeProperty = BindableProperty.Create(
            propertyName: nameof(Stroke),
            returnType: typeof(double),
            declaringType: typeof(CustomStackLayout),
            defaultValue: 0.0,
            defaultBindingMode: BindingMode.TwoWay
        );

        public double Stroke
        {
            get { return (double)GetValue(StrokeProperty); }
            set { SetValue(StrokeProperty, value); }
        }

        public static readonly BindableProperty StrokeColorProperty = BindableProperty.Create(
            propertyName: nameof(StrokeColor),
            returnType: typeof(Color),
            declaringType: typeof(CustomStackLayout),
            defaultValue: Color.Transparent,
            defaultBindingMode: BindingMode.TwoWay
        );

        public Color StrokeColor
        {
            get { return (Color)GetValue(StrokeColorProperty); }
            set { SetValue(StrokeColorProperty, value); }
        }

        public static readonly BindableProperty IsCircleProperty = BindableProperty.Create(
            propertyName: nameof(IsCircle),
            returnType: typeof(bool),
            declaringType: typeof(CustomStackLayout),
            defaultValue: false,
            defaultBindingMode: BindingMode.TwoWay
        );

        public bool IsCircle
        {
            get { return (bool)GetValue(IsCircleProperty); }
            set { SetValue(IsCircleProperty, value); }
        }


        public static readonly BindableProperty StartColorProperty = BindableProperty.Create(
            propertyName: nameof(StartColor),
            returnType: typeof(Color),
            declaringType: typeof(CustomStackLayout),
            defaultValue: Color.Transparent,
            defaultBindingMode: BindingMode.TwoWay
        );

        public Color StartColor
        {
            get { return (Color)GetValue(StartColorProperty); }
            set { SetValue(StartColorProperty, value); }
        }

        public static readonly BindableProperty EndColorProperty = BindableProperty.Create(
            propertyName: nameof(EndColor),
            returnType: typeof(Color),
            declaringType: typeof(CustomStackLayout),
            defaultValue: Color.Transparent,
            defaultBindingMode: BindingMode.TwoWay
        );

        public Color EndColor
        {
            get { return (Color)GetValue(EndColorProperty); }
            set { SetValue(EndColorProperty, value); }
        }
    }
}
