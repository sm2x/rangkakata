using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;
using Rangkakata.Pages;
using Rangkakata.ViewModels.Core;
using Xamarin.Forms;

namespace Rangkakata.ViewModels
{
    public class RangkakataPageViewModel : BaseViewModel
    {
        
        private readonly IPageService _pageService;

        public ICommand GoToProfileCommand { get; private set; }
        public ICommand GoToSearchLocationCommand { get; private set; }

        public RangkakataPageViewModel(IPageService pageService)
        {
            
            _pageService = pageService;

            GoToProfileCommand = new Command(async () => await GoToProfile());
            GoToSearchLocationCommand = new Command(async obj => await GoToSearchLocation(obj));

        }

        private async Task GoToProfile()
        {
            await _pageService.PushAsync(new ProfilePage());
        }

        private async Task GoToSearchLocation(Object obj)
        {

            String point = (String)obj;

            if (point.Equals("Departure"))
            {
                await _pageService.PushAsync(new SearchLocationPage(point));
            }
            else if (point.Equals("Destination"))
            {
                await _pageService.PushAsync(new SearchLocationPage(point));
            }
        }

    }
}
