using System;
using System.Collections.Generic;
using Rangkakata.ViewModels;
using Rangkakata.ViewModels.Core;
using Xamarin.Forms;

namespace Rangkakata.Pages
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            ViewModel = new ProfilePageViewModel(new PageService());
            InitializeComponent();
        }

        void BackOnTapGestureRecognizerTapped(object sender, System.EventArgs e)
        {
            ViewModel.GoBackToHomeCommand.Execute(null);
        }

        public ProfilePageViewModel ViewModel
        {
            get { return BindingContext as ProfilePageViewModel; }
            set { BindingContext = value; }
        }
    }
}
