﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;
using Rangkakata.Pages;
using Rangkakata.ViewModels.Core;
using Xamarin.Forms;

namespace Rangkakata.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {

        private readonly IPageService _pageService;

        public ICommand GoToProfileCommand { get; private set; }
        public ICommand GoToInvoiceCommand { get; private set; }
        public ICommand GoToSearchLocationCommand { get; private set; }
        public ICommand BeaconTapCommand { get; private set; }
        public ICommand LoadTripCommand { get; private set; }

        public bool IsDestinationLoaded { get; set; }
        public bool IsBeaconTapped { get; set; }

        public HomePageViewModel(IPageService pageService)
        {

            _pageService = pageService;

            GoToProfileCommand = new Command(async () => await GoToProfile());
            GoToInvoiceCommand = new Command(async () => await GoToInvoice());
            GoToSearchLocationCommand = new Command(async () => await GoToSearchLocation());
            BeaconTapCommand = new Command(async () => await BeaconTap());
            LoadTripCommand = new Command(async () => await LoadTrip());

        }

        private async Task GoToProfile()
        {
            await _pageService.PushAsync(new ProfilePage());
        }

        private async Task GoToInvoice()
        {
            await _pageService.PushModalAsync(new InvoicePage(), false);
        }

        private async Task GoToSearchLocation()
        {
            IsDestinationLoaded = false;
            IsBeaconTapped = false;
            await _pageService.PushAsync(new SearchLocationPage());
        }

        private async Task BeaconTap()
        {
            IsBeaconTapped = true;
        }

        private async Task LoadTrip()
        {
            IsBeaconTapped = false;
            IsDestinationLoaded = true;
        }

    }
}
