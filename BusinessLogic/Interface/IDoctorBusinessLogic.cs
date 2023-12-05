using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.BusinessLogic.Interface
{
    public interface IDoctorBusinessLogic
    {
        Doctor Create(string email,string password,string firstName, string lastName, string address, string contact, string dateOfBirth, string gender, string lisenceNumber, string education, int yearsOfExperience, List<string> Specializations);
        Doctor Get(string email);
        List<Doctor> GetAll();
        bool DoctorsUpdate(string email, string education, int yearsOfExperience, List<string> Specializations);
    }
}