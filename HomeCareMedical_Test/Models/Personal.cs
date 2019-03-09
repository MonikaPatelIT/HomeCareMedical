using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeCareMedical_Test.Models
{
    [Table("Personal")]
    public class Personal
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false,ErrorMessage ="First name is required")]
        [RegularExpression(@"^[a-zA-Z]+( [a-zA-Z]+)*(\-[a-zA-Z]+)*$",
         ErrorMessage = "First name can only contain alphabetic characters with spaces or hyphens in between like monika megha-test")]
        [StringLength(100)]
        [Display(Name ="First name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "MiddlenName is required")]
        [RegularExpression(@"^[a-zA-Z]+( [a-zA-Z]+)*(\-[a-zA-Z]+)*$",
         ErrorMessage = "Middle name can only contain alphabetic characters with spaces or hyphens in between like monika megha-test")]
        [StringLength(100)]
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname is required")]
        [RegularExpression(@"^[a-zA-Z]+( [a-zA-Z]+)*(\-[a-zA-Z]+)*$",
         ErrorMessage = "Surname can only contain alphabetic characters with spaces or hyphens in between like monika megha-test")]
        [StringLength(100)]
        [Display(Name = "Surname")]
        public string SurName { get; set; }
                
        [MinYearsAge]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public static readonly byte MinAge = 16; // Specifiy Minimum age value here 

        // Calculate age
        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - DateOfBirth.Year;
                return age;
            }
        }
    }
}