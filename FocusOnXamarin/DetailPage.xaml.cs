using System;
using System.Collections.Generic;
using FocusOnXamarin.Models;
using FocusOnXamarin.ViewModels;
using Xamarin.Forms;

namespace FocusOnXamarin
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Product product)
        {
            InitializeComponent();

            BindingContext = new DetailPageViewModel() { Product = product };
        }

        async void BackButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
