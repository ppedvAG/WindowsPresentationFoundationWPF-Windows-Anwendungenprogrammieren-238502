using System.Globalization;
using System.Windows.Data;

namespace M010;

public class WochenendeConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
			return null;

		DayOfWeek tag = (DayOfWeek)value;
		return !(tag >= DayOfWeek.Monday && tag <= DayOfWeek.Friday);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => false;
}