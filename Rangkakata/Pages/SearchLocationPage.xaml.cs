using System;
using System.Collections.Generic;
using Rangkakata.ViewModels;
using Rangkakata.ViewModels.Core;
using Xamarin.Forms;

namespace Rangkakata.Pages
{
    public partial class SearchLocationPage : ContentPage
    {
        
        public SearchLocationPage(String location)
        {
            ViewModel = new SearchLocationPageViewModel(new PageService());
            InitializeComponent();
        }

        public SearchLocationPageViewModel ViewModel
        {
            get { return BindingContext as SearchLocationPageViewModel; }
            set { BindingContext = value; }
        }

    }
}
