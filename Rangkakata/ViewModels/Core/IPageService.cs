using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Rangkakata.ViewModels.Core
{
    public interface IPageService
    {
        Task<bool> DisplayAlert(string title, string message, string ok, string cancel);

        Task PushAsync(Page page, bool isAnimated = true);
    }
}
