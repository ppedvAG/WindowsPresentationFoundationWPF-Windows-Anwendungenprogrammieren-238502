﻿using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace M004;

public class FourValueToMarginConverter : IMultiValueConverter
{
	/// <summary>
	/// values enthält hier vier Doubles
	/// LSlider, TSlider, RSlider, BSlider
	/// </summary>
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		//double[] doubles = values.OfType<double>().ToArray();
		double[] doubles = new double[values.Length];
		for (int i = 0; i < values.Length; i++)
		{
			doubles[i] = (double) values[i];
		}
		return new Thickness(doubles[0], doubles[1], doubles[2], doubles[3]);
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => Array.Empty<object>();
}