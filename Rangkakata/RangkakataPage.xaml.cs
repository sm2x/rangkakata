using System;
using System.Diagnostics;
using Plugin.Geolocator;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Rangkakata
{
    public partial class RangkakataPage : ContentPage
    {
        public RangkakataPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

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
    }
}