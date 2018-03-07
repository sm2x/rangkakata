using System;
using System.Globalization;
using Xamarin.Forms;

namespace Rangkakata.Converters
{
    public class BeaconTappedIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (!(bool)value)
            {
                return "beaconicon.png";
            }
            else
            {
                return "tripconfirmedicon.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
