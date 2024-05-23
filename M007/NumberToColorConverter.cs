using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M007;

public class NumberToColorConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		=> new SolidColorBrush((((int) value % 10 + (int) value / 10) % 10) switch
		{
			0 => (Color) ColorConverter.ConvertFromString("#CC2F00"),
			1 => (Color) ColorConverter.ConvertFromString("#DB6600"),
			2 => (Color) ColorConverter.ConvertFromString("#E39E00"),
			3 => (Color) ColorConverter.ConvertFromString("#76B80D"),
			4 => (Color) ColorConverter.ConvertFromString("#007668"),
			5 => (Color) ColorConverter.ConvertFromString("#006486"),
			6 => (Color) ColorConverter.ConvertFromString("#007CB5"),
			7 => (Color) ColorConverter.ConvertFromString("#465AB2"),
			8 => (Color) ColorConverter.ConvertFromString("#6D47B1"),
			9 => (Color) ColorConverter.ConvertFromString("#873B9C"),
			_ => Colors.Black
		});

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => 0;
}