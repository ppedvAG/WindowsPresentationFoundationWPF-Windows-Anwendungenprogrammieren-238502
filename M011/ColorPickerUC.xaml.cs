using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace M011;

public partial class ColorPickerUC : UserControl
{
	public ColorPickerUC()
	{
		InitializeComponent();
	}

	public Color SelectedColor
	{
		get => (Color) GetValue(SelectedColorProperty);
		set
		{
			//RSliderValue = value.R;
			//GSliderValue = value.G;
			//BSliderValue = value.B;
			//ASliderValue = value.A;
			SetValue(SelectedColorProperty, value);
		}
	}

	public static readonly DependencyProperty SelectedColorProperty =
		DependencyProperty.Register
		(
			nameof(SelectedColor),
			typeof(Color),
			typeof(ColorPickerUC),
			new PropertyMetadata(Colors.Black)
		);

	//Slider Properties
	public byte RSliderValue
	{
		get => (byte) GetValue(RSliderValueProperty);
		set => SetValue(RSliderValueProperty, value);
	}

	public static readonly DependencyProperty RSliderValueProperty =
		DependencyProperty.Register
		(
			nameof(RSliderValue),
			typeof(byte),
			typeof(ColorPickerUC),
			new FrameworkPropertyMetadata((byte) 0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, SliderValueChanged)
		);

	public byte GSliderValue
	{
		get => (byte) GetValue(GSliderValueProperty);
		set => SetValue(GSliderValueProperty, value);
	}

	public static readonly DependencyProperty GSliderValueProperty =
		DependencyProperty.Register
		(
			nameof(GSliderValue),
			typeof(byte),
			typeof(ColorPickerUC),
			new FrameworkPropertyMetadata((byte) 0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, SliderValueChanged)
		);

	public byte BSliderValue
	{
		get => (byte) GetValue(BSliderValueProperty);
		set => SetValue(BSliderValueProperty, value);
	}

	public static readonly DependencyProperty BSliderValueProperty =
		DependencyProperty.Register
		(
			nameof(BSliderValue),
			typeof(byte),
			typeof(ColorPickerUC),
			new FrameworkPropertyMetadata((byte) 0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, SliderValueChanged)
		);

	public byte ASliderValue
	{
		get => (byte) GetValue(ASliderValueProperty);
		set => SetValue(ASliderValueProperty, value);
	}

	public static readonly DependencyProperty ASliderValueProperty =
		DependencyProperty.Register
		(
			nameof(ASliderValue),
			typeof(byte),
			typeof(ColorPickerUC),
			new FrameworkPropertyMetadata((byte) 255, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, SliderValueChanged)
		);

	public static void SliderValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		d.SetValue(SelectedColorProperty,
			Color.FromArgb((byte) d.GetValue(ASliderValueProperty),
						   (byte) d.GetValue(RSliderValueProperty),
						   (byte) d.GetValue(GSliderValueProperty),
						   (byte) d.GetValue(BSliderValueProperty)));
	}

	private void ASlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{

    }
}