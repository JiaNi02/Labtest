using System.Globalization;

namespace Labtest
{
    namespace Labtest
    {
        public partial class MainPage : ContentPage
        {
            public class SliderValueToTextConverter : IValueConverter
            {
                public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
                {
                    if (value is double doubleValue)
                    {
                        if (doubleValue < 40) return "Failed";
                        if (doubleValue < 80) return "Passed";
                        return "Excellent";
                    }
                    return string.Empty;
                }

                public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
                {
                    throw new NotSupportedException();
                }
            }

            public class SliderValueToColorConverter : IValueConverter
            {
                public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
                {
                    if (value is double doubleValue)
                    {
                        if (doubleValue < 40) return Colors.Red;
                        if (doubleValue < 80) return Colors.Black;
                        return Colors.Green;
                    }
                    return Colors.Black;
                }

                public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
                {
                    throw new NotSupportedException();
                }

            }

        }
    }
}
