using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WhiteLabelApp.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhiteLabelApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        //ViewModel _vm;

        public DashboardPage()
        {
            InitializeComponent();

            //_vm = new ViewModel(this);
            //this.BindingContext = _vm;

            //var tapGestureRecognizer = new TapGestureRecognizer();
            //tapGestureRecognizer.Tapped += (s, e) => {
            //    // handle the tap
            //    Navigation.PushAsync(new DetailPage(SvgPaths.andriod));
            //};
            //StkAndroid.GestureRecognizers.Add(tapGestureRecognizer);
        }

        private void Android_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailPage("android",SvgPaths.andriod));
        }

        private void iOS_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailPage("ios", SvgPaths.ios));
        }

        private void Xamarin_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailPage("xamarin", SvgPaths.xamarin));
        }

        private void Flutter_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailPage("flutter",SvgPaths.flutter));
        }

    }

    public class ViewModel : INotifyPropertyChanged
    {
        private Page _page;

        public ViewModel(Page page)
        {
            _page = page;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}