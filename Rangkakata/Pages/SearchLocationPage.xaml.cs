using System;
using System.Collections.Generic;
using Rangkakata.ViewModels;
using Rangkakata.ViewModels.Core;
using Xamarin.Forms;

namespace Rangkakata.Pages
{
    public partial class SearchLocationPage : ContentPage
    {

        public SearchLocationPage()
        {
            InitializeComponent();
        }

        public SearchLocationPage(String location)
        {
            ViewModel = new SearchLocationPageViewModel(new PageService());
            InitializeComponent();
        }

        void BackOnTapGestureRecognizerTapped(object sender, System.EventArgs e)
        {
            ViewModel.GoBackToHomeCommand.Execute(null);
        }


        void DepartureEntryTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            String text = e.NewTextValue;
            ViewModel.Departure = text;
        }

        void DestinationEntryTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            String text = e.NewTextValue;
            ViewModel.Destination = text;
        }

        void SearchLocationListViewItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            SearchLocationItemsListView.SelectedItem = null;
        }

        public SearchLocationPageViewModel ViewModel
        {
            get { return BindingContext as SearchLocationPageViewModel; }
            set { BindingContext = value; }
        }

    }
}
