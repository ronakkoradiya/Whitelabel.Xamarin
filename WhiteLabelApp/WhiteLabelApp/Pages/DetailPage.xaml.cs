using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhiteLabelApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{

        public DetailPage(string technology, string path)
        {
            InitializeComponent();

            if (technology == "android")
            {
                Title = "Android";
                SvgImage.StrokeWidth = 0.5f;
            }
            else if (technology == "ios")
            {
                Title = "iOS";
                SvgImage.StrokeWidth = 9f;
            }
            else if (technology == "xamarin")
            {
                Title = "Xamarin";
                SvgImage.StrokeWidth = 9f;
            }
            else if (technology == "flutter")
            {
                Title = "Flutter";
                SvgImage.StrokeWidth = 9f;
            }

            SvgImage.Path = path;
        }
	}
}