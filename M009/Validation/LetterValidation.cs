﻿using System.Globalization;
using System.Windows.Controls;

namespace M009.Validation;

public class LetterValidation : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        string s = value as string;
        if (s.All(char.IsLetter))
        {
            return ValidationResult.ValidResult;
        }
        return new ValidationResult(false, "Eingabe darf nur aus Buchstaben bestehen!");
    }
}