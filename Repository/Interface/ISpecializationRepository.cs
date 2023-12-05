using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.Repository.Interface
{
    public interface ISpecializationRepository
    {
        void Create(Specialization obj);
        Specialization Get(string name);
        List<Specialization> GetAll();
        // void RefreshFile();
    }
}