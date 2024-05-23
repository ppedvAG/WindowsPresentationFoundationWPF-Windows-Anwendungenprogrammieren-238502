using System.Globalization;
using System.Windows.Data;

namespace M000.Converter;

public class GenderConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        //Quelle -> Ziel
        //Person -> RB
        //Geschlecht Property -> IsChecked
        //Rückgabewert: bool

        //value: Wert im der Person Objekt
        //parameter: Parameter vom RadioButton
        return (Geschlecht)value == (Geschlecht)parameter;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        //Ziel -> Quelle
        //RB -> Person
        //IsChecked -> Geschlecht Property
        //Rückgabewert: Geschlecht

        //value: IsChecked
        //parameter: Parameter vom RadioButton
        if ((bool)value == true)
            return parameter;
        return Binding.DoNothing;
    }
}