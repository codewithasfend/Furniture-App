using RealWorldApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealWorldApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private async void TapSignup_Tapped(object sender, EventArgs e)
        {
            var response = await ApiService.RegisterUser(EntUsername.Text, EntEmail.Text, EntPassword.Text);
            if (response)
            {
                await DisplayAlert("", "Your account has been created", "Alright");
                await Navigation.PushModalAsync(new LoginPage());
            }
            else
            {
                await DisplayAlert("Oops", "Something went wrong", "Cancel");
            }
        }

        private async void SpanSignin_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}