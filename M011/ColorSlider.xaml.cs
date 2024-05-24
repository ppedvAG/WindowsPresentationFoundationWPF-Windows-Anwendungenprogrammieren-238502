using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace M011;

[ContentProperty("Value")]
public partial class ColorSlider : UserControl
{
	public ColorSlider() => InitializeComponent();

	/// <summary>
	/// propdp + Tab + Tab
	/// 
	/// DependencyProperty
	/// Kombination aus einem normalen .NET Property und einer static readonly Variable, welche für Bindings verwendet wird
	/// </summary>
	public Color SliderColor
	{
		get => (Color) GetValue(SliderColorProperty);
		set => SetValue(SliderColorProperty, value);
	}

	public SolidColorBrush SliderBrush => new SolidColorBrush(SliderColor);

	public static readonly DependencyProperty SliderColorProperty =
		DependencyProperty.Register
		(
			nameof(SliderColor), //Name des unterliegenden Properties
			typeof(Color), //Typ des unterliegenden Properties
			typeof(ColorSlider), //Typ der umliegenden Klasse des DPs
			new FrameworkPropertyMetadata(Colors.Transparent) //DP konfigurieren (z.B. Standardwert, Code der vor/nach Wertänderung ausgeführt wird, ...)
		);



	public string TextColor
	{
		get => (string) GetValue(TextColorProperty);
		set => SetValue(TextColorProperty, value);
	}

	public static readonly DependencyProperty TextColorProperty =
		DependencyProperty.Register
		(
			nameof(TextColor),
			typeof(string),
			typeof(ColorSlider),
			new FrameworkPropertyMetadata(string.Empty)
		);




	public byte Value
	{
		get => (byte) GetValue(ValueProperty);
		set => SetValue(ValueProperty, value);
	}

	public static readonly DependencyProperty ValueProperty =
		DependencyProperty.Register
		(
			nameof(Value),
			typeof(byte),
			typeof(ColorSlider),
			new PropertyMetadata((byte) 0)
		);


	public event RoutedPropertyChangedEventHandler<double> ValueChanged
	{
		add { AddHandler(ValueChangedEvent, value); }
		remove { RemoveHandler(ValueChangedEvent, value); }
	}

	public static readonly RoutedEvent ValueChangedEvent =
		EventManager.RegisterRoutedEvent
		(
			nameof(ValueChanged),
			RoutingStrategy.Direct,
			typeof(RoutedPropertyChangedEventHandler<double>),
			typeof(ColorSlider)
		);

}