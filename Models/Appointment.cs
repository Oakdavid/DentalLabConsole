using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalLabConsoleApp.Models
{
    public class Appointment : BaseEntity
    {
      public string RefNumber{get; set;}
      public int PatientCardNo{get; set;}
      public string DrNumber{get; set;}
      public string PatientComplain{get; set;}
      public DateTime DateOfAppoitment{get; set;}
      public string ReportContent{get; set;}
      public AppointmentStatus appointmentStatus {get; set;}
    }
}  