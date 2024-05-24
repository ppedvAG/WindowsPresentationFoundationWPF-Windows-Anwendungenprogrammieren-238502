using System.Globalization;
using System.Windows.Data;

namespace M012;

public class FibonacciConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		return values.OfType<int>().Sum().ToString();
	}

	public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}