using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalLabConsoleApp.Models
{
    public class Patient : BaseEntity
    {
        public string CardNo{get; set;}
        public string UserEmail{get; set;}
        public string Password {get; set;}

    }
}