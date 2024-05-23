using System.Windows.Markup;

namespace M010;

public class EnumExtension : MarkupExtension
{
	public Type EnumType { get; set; }

	/// <summary>
	/// ProvideValue stellt den Wert bereit, welcher im XAML eingebunden werden soll
	/// D.h. wenn z.B. eine ComboBox ihre Elemente erzeugen soll, wird dieser MarkupExtension befragt, welche Elemente dargestellt werden sollen
	/// Hier soll eine Liste zurückgegeben werden, welche in weiterer Folge in der ComboBox gezeigt wird
	/// </summary>
	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return Enum.GetValues(EnumType);
	}
}