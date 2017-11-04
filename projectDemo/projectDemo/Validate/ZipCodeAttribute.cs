using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace projectDemo.Validate
{
    public class ZipCodeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Regex a = new Regex(@"^[0-9]{2}\-[0-9]{3}$");
            if (a.IsMatch(value.ToString()))
                return ValidationResult.Success;

            return new ValidationResult("Błędny kod pocztowy. SPRÓBUJ JESZCZE RAZ");
        }
    }
}