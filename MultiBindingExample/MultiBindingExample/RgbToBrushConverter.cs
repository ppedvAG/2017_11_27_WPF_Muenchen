using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace MultiBindingExample
{
    internal class RgbToBrushConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var a = (byte)(double)values[0];
            var r = (byte)(double)values[1];
            var g = (byte)(double)values[2];
            var b = (byte)(double)values[3];

            return new SolidColorBrush(Color.FromArgb(a, r, g, b));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var color = (value as SolidColorBrush).Color;
            return new object[]
            {
                (double)color.A,
                (double)color.R,
                (double)color.G,
                (double)color.B
            };
        }
    }
}
