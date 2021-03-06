﻿using System;
using System.Diagnostics;
using Plugin.Geolocator;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Rangkakata.ViewModels;
using Rangkakata.ViewModels.Core;
using Xamanimation;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Rangkakata.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            ViewModel = new HomePageViewModel(new PageService());
            InitializeComponent();
            InitialiseMap();
            AnimateBeaconCard();

        }

        void ProfileOnTapGestureRecognizerTapped(object sender, System.EventArgs e)
        {
            ViewModel.GoToProfileCommand.Execute(null);
        }

        void DestinationLabelOnTapGestureRecognizerTapped(object sender, System.EventArgs e)
        {
            ViewModel.GoToSearchLocationCommand.Execute(null);
        }

        void DestinationEntryFocused(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            ViewModel.GoToSearchLocationCommand.Execute(null);
        }

        void BeaconTappedOnTapGestureRecognizerTapped(object sender, System.EventArgs e)
        {
            ViewModel.BeaconTapCommand.Execute(null);
            ViewModel.LoadTripCommand.Execute(null);
            ViewModel.IsBeaconTapped = true;
        }

        void LoadTripClicked(object sender, System.EventArgs e)
        {
            ViewModel.LoadTripCommand.Execute(null);
            AnimateBeaconCard();
        }

        void AnimateBeaconCard()
        {
            BeaconCard.Animate(new HeartAnimation()
            {
                Duration = "800",
                Easing = EasingType.SpringOut
            });
        }

        private async void InitialiseMap()
        {

            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);

                if (status != PermissionStatus.Granted)
                {

                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                    {
                        await DisplayAlert("Rankgkakata location", "We need your location while you use Rangkakata and it is in the background", "OK");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Permission.Location });
                    status = results[Permission.Location];

                }

                if (status == PermissionStatus.Granted)
                {

                    var locator = CrossGeolocator.Current;
                    TimeSpan ts = TimeSpan.FromSeconds(1);
                    var position = await locator.GetPositionAsync(ts);
                    HomeMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude), Distance.FromKilometers(1)));

                    var zoomLevel = 15;
                    var degreeCoordinates = 360 / (Math.Pow(2, zoomLevel));
                    HomeMap.MoveToRegion(new MapSpan(HomeMap.VisibleRegion.Center, degreeCoordinates, degreeCoordinates));

                }
                else if (status != PermissionStatus.Unknown)
                {
                    await DisplayAlert("Location Denied", "Can not continue, try again.", "OK");
                }

            }
            catch (Exception ex)
            {

                Debug.WriteLine("Error: " + ex);
            }

        }

        public HomePageViewModel ViewModel
        {
            get { return BindingContext as HomePageViewModel; }
            set { BindingContext = value; }
        }
    }
}