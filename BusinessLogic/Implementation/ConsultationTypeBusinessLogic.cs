using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.BusinessLogic.Interface;
using DentalLabConsoleApp.Dbcontext;
using DentalLabConsoleApp.Models;
using DentalLabConsoleApp.Repository.Inplementation;
using DentalLabConsoleApp.Repository.Interface;

namespace DentalLabConsoleApp.BusinessLogic.Implementation
{
    
    public class ConsultationTypeBusinessLogic : IConsultationTypeBusinessLogic
    {
        ConsultationTypeRepository _consultationTypeRepository = new ConsultationTypeRepository();
        public ConsultationType Get(string name)
        {
            var consultaionType = DentalLab.ConsultationTypeDb.SingleOrDefault(con => con.Name == name);
            if (consultaionType != null)
            {
                System.Console.WriteLine($"Consultation name:{consultaionType.Name}, Consultation price:{consultaionType.Price}, Location: {consultaionType.Location}");
                return consultaionType;
            }
            return null;

        }

        public ConsultationType GetAll()
        {
            var getAll = _consultationTypeRepository.GetAll();
            foreach (var item in getAll)
            {
                System.Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Location: {item.Location}\n");
            }
            return null;
        }
    }
}