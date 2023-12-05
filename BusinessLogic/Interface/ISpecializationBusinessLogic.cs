using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.BusinessLogic.Interface
{
    public interface ISpecializationBusinessLogic
    {
        void Create(Specialization obj);
        Specialization Get(string name);
        Specialization GetAll();
    }
}