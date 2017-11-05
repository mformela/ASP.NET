using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Impreza.Validation
{
    public class FormControlAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Regex a = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (a.IsMatch(value.ToString()))
                return ValidationResult.Success;

            return new ValidationResult("Błędny e-mail. SPRÓBUJ JESZCZE RAZ");




        }
    }
}