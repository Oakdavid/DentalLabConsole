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
    public class AppointmentBusinessLogic : IAppointmentBusinessLogic
    {
        IAppointmentRepository appointmentRepository = new AppointmentRepository();
        IConsultationTypeBusinessLogic consultationTypeBusinessLogic = new ConsultationTypeBusinessLogic();

        public Appointment Create(string email, int patientCardNo, string patientComplain, DateTime dateOfAppoitment)
        {                           
            var appointments = new Appointment
            {
                Id = DentalLab.AppointmentDb.Count + 1,
                RefNumber = $"RDT/RefNo/00/{new Random().Next(01, 100)}",     // generate ref no
                PatientCardNo = DentalLab.AppointmentDb.Count + 1 ,
                DrNumber = $"RDT/Doctor/00/{new Random().Next(01, 02)}",       // generate dr no
              //  ComplainType = complainType,
                PatientComplain = patientComplain,
                DateOfAppoitment = DateTime.Now,
                ReportContent = null,
                appointmentStatus = AppointmentStatus.Active,
                IsDeleted = false
            };
            appointmentRepository.Create(appointments);

            var consultationType = new ConsultationType
            {
                Name = "Pysical",
                Price = 5000,
            };
            DentalLab.ConsultationTypeDb.Add(consultationType);         // more questions
            return appointments;
        }

        public bool Delete(string email)
        {
            var appointment = appointmentRepository.Get(email);
            if (appointment != null && !appointment.IsDeleted)
            {
                appointment.IsDeleted = true;
                return true;
            }
            System.Console.WriteLine($"{appointment} not found");
            return false;
        }


        public Appointment Get(string name)
        {
            var appointment = appointmentRepository.Get(name);
            if (appointment != null && !appointment.IsDeleted)
            {
                return appointment;
            }
            System.Console.WriteLine($"{appointment} not found");
            return null;
        }

        public void GetAll()
        {
            var getAll = appointmentRepository.GetAll();
            foreach (var item in getAll)
            {
                System.Console.WriteLine($"Ref no: {item.RefNumber}, Patient card no: {item.PatientCardNo}, Doctor no {item.DrNumber}, Patient complain: {item.PatientComplain}, Date of appointment: {DateTime.UtcNow}, Appointment Status: {item.appointmentStatus}");
            }
           
        }

        public bool Update(int patientCardNo)
        {
            var appointmentUpdate = DentalLab.AppointmentDb.SingleOrDefault(appointment => appointment.PatientCardNo == patientCardNo);
            if (appointmentUpdate != null)
            {
                appointmentUpdate.PatientCardNo = patientCardNo;
                System.Console.WriteLine($"{appointmentUpdate.DateOfAppoitment}");
                appointmentRepository.RefreshFile();
                return true;
            }
            return false;
        }
    }
}