﻿using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M000.Converter;

public class ColorToBrushConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return new SolidColorBrush((Color)value);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => Colors.Transparent;
}