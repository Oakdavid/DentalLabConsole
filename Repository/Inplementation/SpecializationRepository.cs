using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using DentalLabConsoleApp.Dbcontext;
using DentalLabConsoleApp.Models;
using DentalLabConsoleApp.Repository.Interface;

namespace DentalLabConsoleApp.Repository.Inplementation
{
    public class SpecializationRepository : ISpecializationRepository
    {
        public static string filePath = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\specialization.txt";
        public void Create(Specialization obj)
        {
            DentalLab.SpecializationDb.Add(obj);
            using (StreamWriter specialization = new StreamWriter(filePath, true))
            {
                var ToString = JsonSerializer.Serialize(obj);
                specialization.WriteLine(ToString);
            }
        }

        public Specialization Get(string name)
        {
            return DentalLab.SpecializationDb.SingleOrDefault(s => s.Name == name && s.IsDeleted == false);
        }

        public List<Specialization> GetAll()
        {
            return DentalLab.SpecializationDb;
        }

    }
}