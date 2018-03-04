using System;
using System.Collections.Generic;
using Rangkakata.ViewModels;
using Rangkakata.ViewModels.Core;
using Xamarin.Forms;

namespace Rangkakata.Pages
{
    public partial class MatchPage : ContentPage
    {
        public MatchPage()
        {
            ViewModel = new MatchPageViewModel(new PageService());
            InitializeComponent();
        }

        public MatchPageViewModel ViewModel
        {
            get { return BindingContext as MatchPageViewModel; }
            set { BindingContext = value; }
        }
    }
}
