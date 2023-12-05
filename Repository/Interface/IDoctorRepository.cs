using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.Repository.Interface
{
    public interface IDoctorRepository
    {
        void Create(Doctor obj);
        Doctor Get(string email);
        List<Doctor> GetAll();
        void RefreshFile();
    }
}