using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Rangkakata.ViewModels.Core;
using Xamarin.Forms;

namespace Rangkakata.ViewModels
{
    public class InvoicePageViewModel : BaseViewModel
    {
        private readonly IPageService _pageService;

        public ICommand DoneCommand { get; private set; }

        public InvoicePageViewModel(IPageService pageService)
        {
            _pageService = pageService;

            DoneCommand = new Command(async () => await Done());
        }

        private async Task Done()
        {
            await _pageService.PopModalAsync(false);
        }
    }
}
