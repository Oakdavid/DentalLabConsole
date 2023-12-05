using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.BusinessLogic.Interface
{
    public interface IPatientBusinessLogic
    {
        public Patient Create(string firstName, string lastName, string address, string contact, string dateOfBirth, string gender, string userEmail, string password);
        Patient Get(string email);
        Patient GetAll();
        bool Delete(string email);
        void PatientToothComplain(string email);
       // public void OnlineConsultation(string email);
        //public void PhysicalConsultation(string email);
    }
}