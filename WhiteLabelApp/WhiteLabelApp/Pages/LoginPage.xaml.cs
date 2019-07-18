using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WhiteLabelApp.Helpers;
using System.Windows.Input;

namespace WhiteLabelApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        public ICommand ShakeUsernameCommand { get; set; }
        public ICommand ShakePasswordCommand { get; set; }

        public static BindableProperty UsernamePlaceholderProperty =
        BindableProperty.Create(nameof(UsernamePlaceholder), typeof(string), typeof(LoginPage), null, BindingMode.TwoWay);

        public static BindableProperty PasswordPlaceholderProperty =
        BindableProperty.Create(nameof(PassworPlaceholder), typeof(string), typeof(LoginPage), null, BindingMode.TwoWay);

        public string UsernamePlaceholder
        {
            get => (string)GetValue(UsernamePlaceholderProperty);
            set => SetValue(UsernamePlaceholderProperty, value);
        }

        public string PassworPlaceholder
        {
            get => (string)GetValue(PasswordPlaceholderProperty);
            set => SetValue(PasswordPlaceholderProperty, value);
        }

        public string CompanyName;

        public LoginPage ()
		{
			InitializeComponent ();

            username.Placeholder = "Username";
            password.Placeholder = "Password";

            lblCompanyName.Text = Settings.CompanyName;

            username.BindingContext = this;
            password.BindingContext = this;
         }

        private void Login_Tapped(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(username.Text) && !String.IsNullOrEmpty(password.Text))
            {
                Navigation.PushAsync(new DashboardPage());
            }
            else if (String.IsNullOrEmpty(username.Text))
            {
                //DisplayAlert(Constants.AppName,"Username or Password is Wrong","OK");
                ShakeUsernameCommand.Execute(null);
            }
            else if (String.IsNullOrEmpty(password.Text))
            {
                ShakePasswordCommand.Execute(null);
            }
        }
        protected override void OnAppearing()
        {
            username.Text = "";
            password.Text = "";
            base.OnAppearing();
        }
    }
}