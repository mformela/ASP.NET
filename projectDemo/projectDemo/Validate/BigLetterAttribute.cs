using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace projectDemo.Validate
{
    public class BigLetterAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Regex a = new Regex(@"^\p{Lu}\p{Ll}*$");
            if (a.IsMatch(value.ToString()))
                return ValidationResult.Success;

            return new ValidationResult("Zacznij z wielkiej litery");

        }
    }
}