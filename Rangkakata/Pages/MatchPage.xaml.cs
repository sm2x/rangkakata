using System;
using System.Collections.Generic;
using Rangkakata.ViewModels;
using Rangkakata.ViewModels.Core;
using Xamanimation;
using Xamarin.Forms;

namespace Rangkakata.Pages
{
    public partial class MatchPage : ContentPage
    {
        public MatchPage()
        {
            ViewModel = new MatchPageViewModel(new PageService());
            InitializeComponent();

            HeartBeat();

            Device.StartTimer(TimeSpan.FromSeconds(3), HeartBeat);

        }

        bool HeartBeat()
        {
            DriverImage.Animate(new HeartAnimation());
            return true;
        }

        public MatchPageViewModel ViewModel
        {
            get { return BindingContext as MatchPageViewModel; }
            set { BindingContext = value; }
        }
    }
}
