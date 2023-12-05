using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.Dbcontext
{
    public class DentalLab
    {

        public static List<Appointment> AppointmentDb = new List<Appointment>()
        {

        };

        public static List<ConsultationType> ConsultationTypeDb = new List<ConsultationType>()
        {
            new ConsultationType
            {
                Name = "Physical Consultation",
                Price = 5000,
                Location = "Code learners Hub @ Gbonogun Obantoko."
            },
            new ConsultationType
            {
                Name = "Virtual Consultation",
                Price = 7500,
                Location = "Googles meet."
            }
        };

        public static List<Doctor> DoctorDb = new List<Doctor>()
        {
           new Doctor
           {
                Id = 1,
                Education = "Dental Technician",
                YearsOfExperience = 5,
                Specializations = new List<string>(),
                UserEmail = "doctor@gmail.com",
                Password = "doctor",
                Role = "Doctor",        // you can remove it later
               // TextReport = " ",
                IsDeleted = false
           }
        };
        public static List<Patient> PatientDb = new List<Patient>()
        {


        };

        public static List<Profile> ProfileDb = new List<Profile>()
        {
            // new Profile
            // {
            //    Id = 1,
            //    FirstName =  "david",
            //    LastName = "oduntan",
            //    Address =  "abk",
            //    Contact =  "07031054058",
            //    DateOfBirth = "12",
            //    Gender = "male",
            //    UserEmail = "doctor@gmail.com",
            //    IsDeleted = false
            // }
        };

        public static List<Specialization> SpecializationDb = new List<Specialization>()
        {
            new Specialization{Name = "Aritificial Denture", Description = "Dentures (artificial teeth) are synthetic \nreplacements for missing natural teeth."}, 
            new Specialization{Name = "Auto Appliances", Description = " Appliances include. Fixed bridges. \nRemovable partial dentures. Removable complete dentures."}, 
            new Specialization{Name = "Conservative", Description = "Conservative dentistry refers to a dentistry branch \nwhose goal is to conserve the teeth in the mouth."}, 
            new Specialization{Name = "Postodontics", Description = "Prosthodontics dentistry is a dental specialty \nthat deals witht the replacement of teeth and\nother parts of the mouth by artificial prostheses."}, 
            new Specialization{Name = "Scalling And Polishing", Description = "is a procedure that removes dental plaque, \ntartar, and extrinsic stains that are present on the outer surface of the teeth."}
        };
        

        public static List<User> UserDb = new List<User>()
        {
           new User
           {
                Id = 1,
                Email = "doctor@gmail.com",
                Password = "doctor",
                Role = "Doctor",
                IsDeleted = false
           }
        };
    }
}