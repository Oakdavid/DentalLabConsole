using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.Repository.Interface
{
    public interface IAppointmentRepository
    {
        void Create (Appointment obj);
        Appointment Get(string refNumber);
        List<Appointment> GetAll();
        void RefreshFile();
    }
   
}