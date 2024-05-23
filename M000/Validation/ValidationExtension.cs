using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace M000.Validation;

public class ValidationExtension : MarkupExtension
{
    public Binding Binding { get; set; } //{Binding Text}

    public ValidationRule Rule { get; set; }

	public ValidationRuleCollection RuleCollection { get; set; } = new();

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        if (Rule != null)
            RuleCollection.Add(Rule);

        foreach (ValidationRule rule in RuleCollection)
        {
            Binding.ValidationRules.Add(rule);
        }

        return Binding.ProvideValue(serviceProvider);
    }
}

public class ValidationRuleCollection : Collection<ValidationRule>;