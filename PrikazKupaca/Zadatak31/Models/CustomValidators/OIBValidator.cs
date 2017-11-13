using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Zadatak31.Models.CustomValidators
{
    public class OIBValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((validationContext.ObjectInstance as Kupac).OIB.Trim().Length != 11)
            {
                return new ValidationResult("Neispravan OIB.");
            }

            return ValidationResult.Success;
        }
    }
}