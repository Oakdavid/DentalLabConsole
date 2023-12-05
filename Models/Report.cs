using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalLabConsoleApp.Models
{
    public class Report : BaseEntity
    {
        public string RefNumber{get; set;}
        public string DrNumber{get; set;}
        public string PtCardNumber{get; set;}
        public string Content{get; set;}
    }
}