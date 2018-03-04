using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Rangkakata.Model;
using Rangkakata.ViewModels.Core;
using Xamarin.Forms;

namespace Rangkakata.ViewModels
{
    public class SearchLocationPageViewModel : BaseViewModel
    {

        private readonly IPageService _pageService;

        public ICommand GoBackToHomeCommand { get; private set; }
        public ICommand LoadSearchLocationItemsCommand { get; private set; }

        public string Departure { get; set; }
        public string Destination { get; set; }
        public ObservableCollection<SearchLocation> SearchLocationItems { get; set; }

        public SearchLocationPageViewModel(IPageService pageService)
        {
            _pageService = pageService;

            GoBackToHomeCommand = new Command(async obj => await GoBackToHome(obj));
            LoadSearchLocationItemsCommand = new Command(async () => await LoadSearchLocationItems());

            LoadSearchLocationItemsCommand.Execute(null);

        }

        private async Task GoBackToHome(Object obj)
        {
            await _pageService.PopAsync();
        }

        private async Task LoadSearchLocationItems()
        {
            SearchLocationItems = new ObservableCollection<SearchLocation>()
            {
                new SearchLocation(){
                    Icon = "taxirankicon.png",
                    Title = "Tzaneen Taxi Rank",
                    Description = "37 California St, Arbor Park, Tzaneen, 0850"
                },
                new SearchLocation(){
                    Icon = "taxirankicon.png",
                    Title = "Tzaneen Taxi Rank",
                    Description = "37 California St, Arbor Park, Tzaneen, 0850"
                }
            };
        }

    }
}
