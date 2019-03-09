using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeCareMedical_Test.Models;

namespace HomeCareMedical_Test.ViewModels
{
    public class PersonalView
    {
        public Personal Personal { get; set; }
        
        public int Age {
            get
            {
                if (!(Personal.DateOfBirth == null))
                {
                    return Convert.ToInt32(DateTime.Today.Subtract(Personal.DateOfBirth));
                }
                return 0;
            }
        }
    }
}