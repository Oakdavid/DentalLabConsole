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
    public class PatientRepository : IPatientRepository
    {
        public static string patientfile = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\patient.txt";
        public void Create(Patient obj)
        {
            DentalLab.PatientDb.Add(obj);
            using (StreamWriter patients = new StreamWriter(patientfile, true))
            {
                var ToString = JsonSerializer.Serialize(obj);
                patients.WriteLine(ToString);
            }
        }

        public Patient Get(string cardNo)
        {
            return DentalLab.PatientDb.SingleOrDefault(pa => pa.CardNo == cardNo && pa.IsDeleted == false);
        }

        public List<Patient> GetAll()
        {
            return DentalLab.PatientDb;
        }

        public Patient GetByEmail(string email)
        {
            return DentalLab.PatientDb.SingleOrDefault(pa => pa.UserEmail == email);
        }
        public void RefreshFile()
        {
            using (StreamWriter writer = new StreamWriter(patientfile, false))
            {
                foreach (var item in DentalLab.PatientDb)
                {
                    var refreshFile = JsonSerializer.Serialize(item);
                    writer.WriteLine(refreshFile);
                }
            }
        }
    }
}