using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Rangkakata.ViewModels.Core;
using Xamarin.Forms;

namespace Rangkakata.ViewModels
{
    public class MatchPageViewModel : BaseViewModel
    {

        private readonly IPageService _pageService;

        public ICommand CancelCommand { get; private set; }

        public MatchPageViewModel(IPageService pageService)
        {
            _pageService = pageService;

            CancelCommand = new Command(async () => await Cancel());
        }

        private async Task Cancel()
        {
            await _pageService.PopModalAsync(false);
        }

    }
}
