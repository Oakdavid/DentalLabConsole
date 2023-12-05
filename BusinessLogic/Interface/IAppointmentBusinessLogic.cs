using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.BusinessLogic.Interface
{
    public interface IAppointmentBusinessLogic
    {
        Appointment Create(string email, int patientCardNo, string patientComplain, DateTime dateOfAppoitment);
        Appointment Get(string email);
        void GetAll();
        bool Update(int cardNo);
        bool Delete(string email);
        // void PhysicalAppointment(string email, string patientComplain, string dateOfAppoitment);
    }
}