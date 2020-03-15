using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusOnXamarin.Models;
using FocusOnXamarin.ViewModels;
using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace FocusOnXamarin
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly double _height;
        private bool _isCartVisible = false;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();

            _height = (Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Height / Xamarin.Essentials.DeviceDisplay.MainDisplayInfo.Density) - 80;
        }

        async void SwipeGestureRecognizer_SwipedUp(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            if (_isCartVisible)
                return;

            _isCartVisible = true;

            MenuBarRow1.Height = 0;

            var animateGridRow1 = new Animation(v => GridRow1.HeightRequest = v, _height, 80);
            animateGridRow1.Commit(this, "GridRow1AnimationIn", 16, 200, Easing.CubicInOut);

            var animateGridRow2 = new Animation(v => GridRow2.HeightRequest = v, 80, _height);
            animateGridRow2.Commit(this, "GridRow2AnimationIn", 16, 200, Easing.CubicInOut);

            var animateCartSmall = new Animation(v => CartSmall.HeightRequest = v, 54, 0);
            animateCartSmall.Commit(this, "CartSmallAnimationIn", 16, 400, Easing.CubicInOut);

            await Task.WhenAll(
                MenuBarTitle.FadeTo(0, easing: Easing.CubicInOut),
                MenuBarIcon.FadeTo(0, easing: Easing.CubicInOut),
                TopGradient.FadeTo(0, easing: Easing.CubicInOut),
                CartSmall.FadeTo(0, easing: Easing.CubicInOut)
            );

            MenuBarTitle.IsVisible = false;
            MenuBarIcon.IsVisible = false;
            TopGradient.IsVisible = false;
            CartSmall.IsVisible = false;
        }

        async void SwipeGestureRecognizer_SwipedDown(System.Object sender, Xamarin.Forms.SwipedEventArgs e)
        {
            if (!_isCartVisible)
                return;

            _isCartVisible = false;

            MenuBarRow1.Height = 54;

            var animateGridRow1 = new Animation(v => GridRow1.HeightRequest = v, 80, _height);
            animateGridRow1.Commit(this, "GridRow1AnimationOut", 16, 200, Easing.CubicInOut);

            var animateGridRow2 = new Animation(v => GridRow2.HeightRequest = v, _height, 80);
            animateGridRow2.Commit(this, "GridRow2AnimationOut", 16, 200, Easing.CubicInOut);

            var animateCartSmall = new Animation(v => CartSmall.HeightRequest = v, 0, 54);
            animateCartSmall.Commit(this, "CartSmallAnimationIn", 16, 200, Easing.CubicInOut);

            MenuBarTitle.IsVisible = true;
            MenuBarIcon.IsVisible = true;
            TopGradient.IsVisible = true;
            CartSmall.IsVisible = true;

            await Task.WhenAll(
                MenuBarTitle.FadeTo(1, easing: Easing.CubicInOut),
                MenuBarIcon.FadeTo(1, easing: Easing.CubicInOut),
                TopGradient.FadeTo(1, easing: Easing.CubicInOut),
                CartSmall.FadeTo(1, easing: Easing.CubicInOut)
            );
        }

        async void ProductOverview_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {
                ProductOverview.SelectedItem = null;
                var tappedItemData = e.CurrentSelection.FirstOrDefault() as Product;

                //this is required in order to pass the views to animate
                SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, tappedItemData.Name);

                await Navigation.PushAsync(new DetailPage(tappedItemData));
            }
        }
    }
}
