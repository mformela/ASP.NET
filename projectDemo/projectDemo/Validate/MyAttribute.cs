using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projectDemo.Validate
{
    public class MyAttribute : ValidationAttribute

    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString() == "Kotek")
              return ValidationResult.Success;
           
                return new ValidationResult("Bleda mamy");
            
            
        }
    }
}