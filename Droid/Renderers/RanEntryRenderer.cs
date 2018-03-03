using System;
using Android.Content;
using Rangkakata.Controls;
using Rangkakata.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RanEntry), typeof(RanEntryRenderer))]
namespace Rangkakata.Droid.Renderers
{
    public class RanEntryRenderer: EntryRenderer
    {
        public RanEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                
            }
        }
    }
}
