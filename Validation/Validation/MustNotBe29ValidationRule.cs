using System.Globalization;
using System.Windows.Controls;

namespace Validation
{
    internal class MustNotBe29ValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) => value is string s && s == "29"
            ? new ValidationResult(false, "29 gefällt mir nicht. :P")
            : ValidationResult.ValidResult;
    }
}
