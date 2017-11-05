using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;

namespace ZaproszenieImprezaGotowiec.Validate
{
    public class MailAttribute : ValidationAttribute

    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            

    
            Regex a = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (a.IsMatch(value.ToString()))
                return ValidationResult.Success;

            return new ValidationResult("Błędny e-mail. SPRÓBUJ JESZCZE RAZ");






            ////walidacja email
            //    public bool IsValid(string emailaddress)
            //{
            //    try
            //    {
            //        MailAddress m = new MailAddress(emailaddress);
            //    return true;
            //    }
            //    catch (FormatException)
            //    {
            //        return false;
            //    }
            //}
        }
    }
}