﻿using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Rangkakata.ViewModels.Core;
using Xamarin.Forms;

namespace Rangkakata.ViewModels
{
    public class ProfilePageViewModel : BaseViewModel
    {

        private readonly IPageService _pageService;

        public ICommand GoBackToHomeCommand { get; private set; }

        public ProfilePageViewModel(IPageService pageService)
        {
            _pageService = pageService;

            GoBackToHomeCommand = new Command(async obj => await GoBackToHome(obj));
        }

        private async Task GoBackToHome(Object obj)
        {
            await _pageService.PopAsync();
        }

    }
}
