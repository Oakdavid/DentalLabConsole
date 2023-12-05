using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalLabConsoleApp.Models
{
    public class Doctor : BaseEntity
    {
        public string UserEmail{get; set;}
        public string Password{get; set;}
        public string Role{get; set;}
        public string LicenseNumber{get; set;}
        public string Education {get; set;}
        public int YearsOfExperience{get; set;}
        public List<string> Specializations{get; set;}
    }
}