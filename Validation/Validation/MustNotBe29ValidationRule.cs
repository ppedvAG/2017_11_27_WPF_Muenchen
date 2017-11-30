using System.Globalization;
using System.Windows.Controls;

namespace Validation
{
    internal class MustNotBeForbiddenVAlueValidationRule : ValidationRule
    {
        public string ForbiddenValue { get; set; } = "29";

        public override ValidationResult Validate(object value, CultureInfo cultureInfo) => value is string s && s == ForbiddenValue
            ? new ValidationResult(false, $"{ForbiddenValue} gefällt mir nicht. :P")
            : ValidationResult.ValidResult;
    }
}
