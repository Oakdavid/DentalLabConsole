using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.Repository.Interface
{
    public interface IConsultationTypeRepository
    {
        ConsultationType Get(string name);
        List<ConsultationType> GetAll();

    }
}