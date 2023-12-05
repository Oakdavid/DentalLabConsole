using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalLabConsoleApp.Models
{
    public class Profile : BaseEntity
    {
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public string Address{get; set;}
        public string Contact{get; set;}
        public string DateOfBirth{get; set;}
        public string Gender{get; set;}
        public string UserEmail{get; set;}
       
    }
}