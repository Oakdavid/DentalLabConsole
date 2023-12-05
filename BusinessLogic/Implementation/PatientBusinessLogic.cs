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

    public class PatientBusinessLogic : IPatientBusinessLogic
    {
        IPatientRepository patientRepository = new PatientRepository();
        IUserRepository userRepository = new UserRepository();
        IProfileRepository profileRepository = new ProfileRepository();

        public Patient Create(string firstName, string lastName, string address, string contact, string dateOfBirth, string gender, string email, string password)
        {
            var patient = patientRepository.Get(email);

            if (patient != null)
            {
                System.Console.WriteLine($"{patient}found");
            }

            var user = new User
            {
                Id = DentalLab.UserDb.Count + 1,
                Email = email,
                Password = password,
                Role = "Patient"
            };
            userRepository.Create(user);

            var patients = new Patient
            {
                Id = DentalLab.PatientDb.Count + 1,
                CardNo = $"RDT/DENTAL/00/{new Random().Next(001, 100)}",
                UserEmail = email,
                Password = password,
                IsDeleted = false
            };
            patientRepository.Create(patients);

            var profile = new Profile
            {
                Id = DentalLab.ProfileDb.Count + 1,
                FirstName = firstName,
                LastName = lastName,
                Address = address, 
                Contact = contact,
                DateOfBirth = dateOfBirth,
                Gender = gender,
                UserEmail = email,
            };
            profileRepository.Create(profile);
            return patients;
        }

        public bool Delete(string email)
        {
            var patient = patientRepository.Get(email);
            if (patient != null)
            {
                System.Console.WriteLine($"{email} already exist");
                return true;
            }
            patient.IsDeleted = true;
            System.Console.WriteLine($"{email}is deleted successfully");
            patientRepository.RefreshFile();
            return true;
        }

        public Patient Get(string email)
        {
            var patient = DentalLab.PatientDb.SingleOrDefault(patient => patient.UserEmail == email);
            if (patient != null)
            {
                System.Console.WriteLine($"{email} found");
                return patient;
            }
            return null;
        }

        public Patient GetAll()
        {
            var getAll = patientRepository.GetAll();
            foreach (var item in getAll)
            {
                System.Console.WriteLine($"Card no : {item.CardNo}, UserEmail: {item.UserEmail}\n");
               
            }
            return null;
        }
        public void PatientToothComplain(string email)
        {
            var patient = DentalLab.PatientDb.SingleOrDefault(patient => patient.UserEmail == email);
            if (patient != null)
            {
                System.Console.WriteLine($"{patient.UserEmail} : Please give a full details on how you are feeling");
                string toothComplain = Console.ReadLine();
            }
        }

        public void PhysicalConsultation(string email)
        {
            var patient = DentalLab.PatientDb.SingleOrDefault(patient => patient.UserEmail == email);
            if (patient != null)
            {
                System.Console.WriteLine($"{patient.UserEmail}. Your appointment schedule wil take place at the Head Office @ CLH HUB.\nIf you need any additional information, please contact us on 07031054058 \nor email doctor@gmail.com. Please note that online fee is #5000.\nThank you");
            }
        }
    }
}