using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.BusinessLogic.Interface
{
    public interface IConsultationTypeBusinessLogic
    {
        ConsultationType Get(string name);
        ConsultationType GetAll();
    }
}