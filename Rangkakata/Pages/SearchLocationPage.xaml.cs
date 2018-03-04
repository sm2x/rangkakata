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

        public SearchLocationPageViewModel ViewModel
        {
            get { return BindingContext as SearchLocationPageViewModel; }
            set { BindingContext = value; }
        }

    }
}
