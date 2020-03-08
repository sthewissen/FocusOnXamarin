using System;
using System.Collections.Generic;
using FocusOnXamarin.ViewModels;
using Xamarin.Forms;

namespace FocusOnXamarin
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();

            BindingContext = new DetailPageViewModel();
        }
    }
}
