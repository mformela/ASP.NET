using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projectDemo.Validate
{
    public class ZipCodeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((int)value >= 18)
                return ValidationResult.Success;

            return new ValidationResult("Jesteś niepełnoletni");
        }
    }
}