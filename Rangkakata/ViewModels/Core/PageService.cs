using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Rangkakata.ViewModels.Core
{
    public class PageService : IPageService
    {
        public async Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);
        }

        public async Task PopAsync(bool isAnimated = true)
        {
            await Application.Current.MainPage.Navigation.PopAsync(isAnimated);
        }

        public async Task PopModalAsync(bool isAnimated = true)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync(isAnimated);
        }

        public async Task PushAsync(Page page, bool isAnimated = true)
        {
            await Application.Current.MainPage.Navigation.PushAsync(page, isAnimated);
        }

        public async Task PushModalAsync(Page page, bool isAnimated = true)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(page, isAnimated);
        }
    }
}
