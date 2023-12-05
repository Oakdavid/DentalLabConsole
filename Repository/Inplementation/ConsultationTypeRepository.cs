using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Dbcontext;
using DentalLabConsoleApp.Repository.Interface;

namespace DentalLabConsoleApp.Repository.Inplementation
{
    public class ConsultationTypeRepository : IConsultationTypeRepository
    {
        public Models.ConsultationType Get(string name)
        {
            return DentalLab.ConsultationTypeDb.SingleOrDefault(consultation => consultation.Name == name);
        }

        public List<Models.ConsultationType> GetAll()
        {
            return DentalLab.ConsultationTypeDb;
        }
        
    }
}