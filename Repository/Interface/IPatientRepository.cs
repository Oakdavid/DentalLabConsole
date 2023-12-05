using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.Repository.Interface
{
    public interface IPatientRepository
    {   
        void Create(Patient obj);
        Patient Get(string cardNo);
        Patient GetByEmail(string email);
        List<Patient> GetAll();
        void RefreshFile();
        
    }
}