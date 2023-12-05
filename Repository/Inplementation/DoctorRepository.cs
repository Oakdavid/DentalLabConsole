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
   
    public class DoctorRepository : IDoctorRepository
    {
        public static string  filePath = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\doctor.txt";
        public void Create(Doctor obj)
        {
            DentalLab.DoctorDb.Add(obj);
            using (StreamWriter doctors = new StreamWriter(filePath, true))
            {
                var ToString = JsonSerializer.Serialize(obj);
                doctors.WriteLine(ToString);
            }
        }

        public Doctor Get(string email)
        {
            return DentalLab.DoctorDb.SingleOrDefault( dot => dot.UserEmail == email && dot.IsDeleted == false);
        }

        public List<Doctor> GetAll()
        {
            return DentalLab.DoctorDb;
        }
        public void RefreshFile()
        {
            using(StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var item in DentalLab.DoctorDb)
                {
                    var refreshFile = JsonSerializer.Serialize(item);
                    writer.WriteLine(refreshFile);
                }
            }
        }
    }
}