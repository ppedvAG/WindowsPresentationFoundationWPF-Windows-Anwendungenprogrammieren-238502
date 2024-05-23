using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M000.Converter;

public class FourValueToBrushConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        byte[] bytes = values
            .OfType<double>()
            .Select(e => (byte)e)
            .ToArray();
        return new SolidColorBrush(Color.FromArgb(bytes[3], bytes[0], bytes[1], bytes[2]));
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}