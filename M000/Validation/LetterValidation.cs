using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

public class LetterValidation : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string s = value as string;
		if (!s.All(char.IsLetter))
		{
			return new ValidationResult(false, "Eingabe darf nur aus Buchstaben bestehen!");
		}
		return ValidationResult.ValidResult;
	}
}