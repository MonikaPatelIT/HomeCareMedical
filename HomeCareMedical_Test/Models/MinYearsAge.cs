using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace HomeCareMedical_Test.Models
{
    public class MinYearsAge : ValidationAttribute
    {
        //Validate Date of birth
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var personal = (Personal)validationContext.ObjectInstance;

            //Required field validation on null
            if (personal.DateOfBirth == null)
                return new ValidationResult("Date of birth is required");

            int age = DateTime.Today.Year - personal.DateOfBirth.Year; // Calculate age

            //check minimum age age validation and return result 
            return (age > Personal.MinAge ? ValidationResult.Success : new ValidationResult("Person should be atleast 16 years old."));
        }
    }
}