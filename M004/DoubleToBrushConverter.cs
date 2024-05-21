using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M004;

public class DoubleToBrushConverter : IValueConverter
{
	/// <summary>
	/// Quelle -> Ziel
	/// Slider -> Rectangle
	/// 
	/// value: double
	/// return: Brush
	/// </summary>
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		double sliderValue = (double)value;
		byte color = (byte) sliderValue;
		SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, color, color, color));
		return brush;
	}

	/// <summary>
	/// Ziel -> Quelle
	/// Rectangle -> Slider
	/// 
	/// value: Brush
	/// return: double
	/// 
	/// (Kann nicht passieren)
	/// </summary>
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return 0;
	}
}