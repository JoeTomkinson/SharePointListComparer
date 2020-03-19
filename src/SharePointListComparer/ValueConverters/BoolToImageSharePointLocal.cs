using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace SharePointListComparer.ValueConverters
{
    [ValueConversion(typeof(bool), typeof(BitmapImage))]
    public class BoolToImageSharePointLocal : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value == true)
            {
                return new BitmapImage(new Uri("/Assets/local.png", UriKind.Relative));
            }
            else
            {
                return new BitmapImage(new Uri("/Assets/online.png", UriKind.Relative));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Don't need any convert back
            return null;
        }
    }
}