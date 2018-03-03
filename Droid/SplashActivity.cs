using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content;

namespace Rangkakata.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        public override void OnCreate(Android.OS.Bundle savedInstanceState, Android.OS.PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task start = new Task(() => { Start(); });
            start.Start();
        }

        async void Start()
        {
            await Task.Delay(3000);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

    }
}
