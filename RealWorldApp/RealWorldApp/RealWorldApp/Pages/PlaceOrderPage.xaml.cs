using RealWorldApp.Models;
using RealWorldApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealWorldApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaceOrderPage : ContentPage
    {
        private double _totalPrice;
        public PlaceOrderPage(double totalPrice)
        {
            InitializeComponent();
            _totalPrice = totalPrice;
        }

        private async void BtnPlaceOrder_Clicked(object sender, EventArgs e)
        {
            var order = new Order();
            order.FullName = EntName.Text;
            order.Phone = EntPhone.Text;
            order.Address = EntAddress.Text;
            order.UserId = Preferences.Get("userId", 0);
            order.OrderTotal = (int)_totalPrice;

            var response = await ApiService.PlaceOrder(order);
            if (response != null)
            {
                await DisplayAlert("", "Your Order Id is " + response.OrderId, "Alright");
                Application.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
            {
                await DisplayAlert("Oops", "Something went wrong", "Cancel");
            }
        }

        private void TapBack_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}