using Xamarin.Forms;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Rangkakata
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RangkakataPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=410d0382-00e8-40d6-b563-18af6124c29e;" + "ios=36bb0eb3-8846-4eeb-84a4-a2be8900ce37", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
