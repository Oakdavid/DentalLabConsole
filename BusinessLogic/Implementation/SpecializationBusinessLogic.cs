using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.BusinessLogic.Interface;
using DentalLabConsoleApp.Models;
using DentalLabConsoleApp.Repository.Inplementation;
using DentalLabConsoleApp.Repository.Interface;

namespace DentalLabConsoleApp.BusinessLogic.Implementation
{
    public class SpecializationBusinessLogic : ISpecializationBusinessLogic
    {
        ISpecializationRepository specializationRepository = new SpecializationRepository();
        public void Create(Specialization obj)
        {
            var specialization = specializationRepository.Get(obj.Name);
            if (specialization != null)
            {
                System.Console.WriteLine($"{specialization} already exist");
            }
            var specializations = new Specialization
            {
                Name = obj.Name,
                Description = obj.Description
            };
            specializationRepository.Create(specialization);

        }

        public Specialization Get(string name)
        {
            var specialization = specializationRepository.Get(name);
            if(specialization != null)
            {
                return specialization;
            }
            System.Console.WriteLine($"{name} does not exist");
            return null;
        }

        public Specialization GetAll()
        {
            var getAll = specializationRepository.GetAll();
            foreach (var item in getAll)
            {
                System.Console.WriteLine($"Specialization name : {item.Name}, Decription: {item.Description}\n");
            }
            return null;
            
        }
    }
}