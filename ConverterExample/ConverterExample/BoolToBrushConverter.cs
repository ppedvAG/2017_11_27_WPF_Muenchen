using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ConverterExample
{
    internal class BoolToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => (bool)value ? Brushes.Green : Brushes.Red;
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
