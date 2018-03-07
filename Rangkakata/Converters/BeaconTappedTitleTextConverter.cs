using System;
using System.Globalization;
using Xamarin.Forms;

namespace Rangkakata.Converters
{
    public class BeaconTappedTitleTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (!(bool)value)
            {
                return "Confirm Trip";
            }
            else
            {
                return "Trip Confirmed";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
