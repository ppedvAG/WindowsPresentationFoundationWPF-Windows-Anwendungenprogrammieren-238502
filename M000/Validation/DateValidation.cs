using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

public class DateValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		DateTime dt = (DateTime)value;

		if (dt.Year < DateTime.Now.Year - 120)
		{
			return new ValidationResult(false, $"Wähle ein Jahr nach {DateTime.Now.Year - 120} aus!");
		}

		if (dt > DateTime.Now)
		{
			return new ValidationResult(false, $"Wähle ein Jahr vor heute aus!");
		}

		return ValidationResult.ValidResult;
	}
}