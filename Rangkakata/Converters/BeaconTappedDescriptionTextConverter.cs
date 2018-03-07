using System;
using System.Globalization;
using Xamarin.Forms;

namespace Rangkakata.Converters
{
    public class BeaconTappedDescriptionTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (!(bool)value)
            {
                return "You will need to tap on a sensor or beacon to confirm your trip.";
            }
            else
            {
                return "You have confirmed your trip and can continue with your payment.";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
