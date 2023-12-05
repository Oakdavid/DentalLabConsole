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
    public class AppointmentRepository : IAppointmentRepository
    {
        public static string filePath = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\appointment.txt";
        public void Create(Appointment obj)
        {
            DentalLab.AppointmentDb.Add(obj);
            using (StreamWriter appointments = new StreamWriter(filePath, true))
            {
                var ToString = JsonSerializer.Serialize(obj);
                appointments.WriteLine(ToString);
            }
        }

        public Appointment Get(string refNumber)
        {
            return DentalLab.AppointmentDb.SingleOrDefault(ap => ap.RefNumber == refNumber);
        }

        public List<Appointment> GetAll()
        {
            return DentalLab.AppointmentDb;
        }

        public void RefreshFile()
        {
            using(StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var item in DentalLab.AppointmentDb)
                {
                    var refreshFile = JsonSerializer.Serialize(item);
                    writer.WriteLine(refreshFile);
                }
            }
        }
    }
}