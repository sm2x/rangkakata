using System;
using Rangkakata.ViewModels.Core;

namespace Rangkakata.ViewModels
{
    public class SearchLocationPageViewModel : BaseViewModel
    {
        
        private readonly IPageService _pageService;

        public SearchLocationPageViewModel(IPageService pageService)
        {
            _pageService = pageService;
        }
    }
}
