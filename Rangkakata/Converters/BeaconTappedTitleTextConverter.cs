using System;
using System.Globalization;
using Xamarin.Forms;

namespace Rangkakata.Converters
{
    public class BeaconTappedTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (!(bool)value)
            {
                return "TAP SENSOR";
            }
            else
            {
                return "CONFIRM PAYMENT";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
