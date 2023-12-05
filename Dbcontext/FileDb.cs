using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.Dbcontext
{
    public class FileDb
    {
        static string basePath = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles";


        public static void CreateFile()
        {
            if (!Directory.Exists(basePath)) Directory.CreateDirectory(basePath);



            var appointment = Path.Combine(basePath, "appointment.txt");
            if (!File.Exists(appointment))
            {
                File.Create(appointment);
                System.Console.WriteLine("File created successfully");
            }
            else
            {
                string appointmentfile = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\appointment.txt";
                using (StreamReader reader = new StreamReader(appointmentfile))
                {
                    var readAppointment = File.ReadAllLines(appointmentfile);
                    foreach (var item in readAppointment)
                    {
                        var listOfAppointment = JsonSerializer.Deserialize<Appointment>(item);
                        DentalLab.AppointmentDb.Add(listOfAppointment);
                    }
                }
            }

            // var appointmentStatus = Path.Combine(basePath, "appointmentStatus.txt");  /// I MIGHT NEED TO REMOVE IT
            // if (!File.Exists(appointmentStatus))
            // {
            //     File.Create(appointmentStatus);
            //     System.Console.WriteLine("File created successfully");
            // }
            // else
            // {
            //     string appointmentStatusfile = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\appointmentStatus.txt";
            //     using (StreamReader reader = new StreamReader(appointmentStatusfile))
            //     {
            //         var readAppointment = File.ReadAllLines(appointmentStatusfile);
            //         foreach (var item in readAppointment)
            //         {
            //             var listOfStatusAppointment = JsonSerializer.Deserialize<Appointment>(item);
            //             DentalLab.AppointmentDb.Add(listOfStatusAppointment);
            //         }
            //     }
            // }

            
            var doctor = Path.Combine(basePath, "doctor.txt");
            if (!File.Exists(doctor))
            {
                File.Create(doctor);
                System.Console.WriteLine("Doctor File created successfully");
            }
            else
            {
                string doctorfile = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\doctor.txt";
                using (StreamReader reader = new StreamReader(doctorfile))
                {
                    var readDoctorFile = File.ReadAllLines(doctorfile);
                    foreach (var item in readDoctorFile)
                    {
                        var listOfDoctor = JsonSerializer.Deserialize<Doctor>(item);
                        DentalLab.DoctorDb.Add(listOfDoctor);
                    }
                }
            }



            var patient = Path.Combine(basePath, "patient.txt");
            if (!File.Exists(patient))
            {
                File.Create(patient);
                System.Console.WriteLine("Patient File created successfully");
            }
            else
            {
                string patientfile = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\patient.txt";
                using (StreamReader reader = new StreamReader(patientfile))
                {
                    var readAllFromFile = File.ReadAllLines(patientfile);
                    foreach (var item in readAllFromFile)
                    {
                        var listOfPatient = JsonSerializer.Deserialize<Patient>(item);
                        DentalLab.PatientDb.Add(listOfPatient);
                    }

                }

            }




            var profile = Path.Combine(basePath, "profile.txt");
            if (!File.Exists(profile))
            {
                File.Create(profile);
                System.Console.WriteLine("Profile File created successfully");
            }
            else
            {
                string profilePath = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\profile.txt";
                using (StreamReader reader = new StreamReader(profilePath))
                {
                    var readAllFromFile = File.ReadAllLines(profilePath);
                    foreach (var item in readAllFromFile)
                    {
                        var listOfProfile = JsonSerializer.Deserialize<Profile>(item);
                        DentalLab.ProfileDb.Add(listOfProfile);
                    }
                }
            }




            var specialization = Path.Combine(basePath, "specialization.txt");  //i corrected a letter
            if (!File.Exists(specialization))
            {
                File.Create(specialization);
                System.Console.WriteLine("Specialization File created successfully");
            }
            else
            {
                string specializationPath = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\specialization.txt";
                using (StreamReader reader = new StreamReader(specializationPath))
                {
                    var readAllFromFile = File.ReadAllLines(specializationPath);
                    foreach (var item in readAllFromFile)
                    {
                        var listOfSpecialization = JsonSerializer.Deserialize<Specialization>(item);
                        DentalLab.SpecializationDb.Add(listOfSpecialization);
                    }
                }
            }


            var user = Path.Combine(basePath, "user.txt");
            if (!File.Exists(user))
            {
                File.Create(user);
                System.Console.WriteLine("User File created successfully");
            }
            else
            {
                string userPath = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\user.txt";
                using (StreamReader reader = new StreamReader(userPath))
                {
                    var readAllFromFile = File.ReadAllLines(userPath);
                    foreach (var item in readAllFromFile)
                    {
                        var listOfUser = JsonSerializer.Deserialize<User>(item);
                        DentalLab.UserDb.Add(listOfUser);
                    }
                }
            }
        }

    }
}