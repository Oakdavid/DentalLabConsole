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
    public class DoctorBusinessLogic : IDoctorBusinessLogic
    {
        IDoctorRepository doctorRepository = new DoctorRepository();
        IUserRepository userRepository = new UserRepository();
        IProfileRepository profileRepository = new ProfileRepository();
        public Doctor Create(string email, string password, string firstName, string lastName, string address, string contact, string dateOfBirth, string gender, string lisenceNumber, string education, int yearsOfExperience, List<string> Specializations)
        {
            var doctor = doctorRepository.Get(email);
            if (doctor != null)
            {
                System.Console.WriteLine($"{doctor} already exist");
                return null;
            }

            var user = new User
            {
                Email = email,
                Password = password,
                Role = "Doctor"
            };
            userRepository.Create(user);

            var profile = new Profile
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Contact = contact,
                DateOfBirth = dateOfBirth,
                Gender = gender,
            };
            profileRepository.Create(profile);

            var doctors = new Doctor
            {
                Id = DentalLab.DoctorDb.Count + 1,
                LicenseNumber = lisenceNumber,
                YearsOfExperience = yearsOfExperience,
                Specializations = Specializations,
            };
            doctorRepository.Create(doctors);
            return doctor;

            
        }

        public bool DoctorsUpdate(string email, string education, int yearsOfExperience, List<string> Specializations)
        {

            var doctorsUpdate = DentalLab.DoctorDb.SingleOrDefault(d => d.UserEmail == email);
            if (doctorsUpdate != null)
            {
                doctorsUpdate.Education = education;
                doctorsUpdate.YearsOfExperience = yearsOfExperience;
                doctorsUpdate.Specializations = Specializations;
                System.Console.WriteLine($"Education: {doctorsUpdate.Education}, Years of Experience: {doctorsUpdate.YearsOfExperience}, Specialization: {doctorsUpdate.Specializations}");
                System.Console.WriteLine("Update successful");
                doctorRepository.RefreshFile();
                return true;
            }
            return false;
        }

        public Doctor Get(string email)
        {
            var doctor = DentalLab.DoctorDb.SingleOrDefault(d => d.UserEmail == email);
            var doctor1 = doctorRepository.Get(email);
            if (doctor != null)
            {
                System.Console.WriteLine($"Doctor {doctor} exist");
                return doctor;
            }
            System.Console.WriteLine("Email not found");
            return null;
        }

        public List<Doctor> GetAll()
        {
            var getAll = doctorRepository.GetAll();
            foreach (var item in getAll)
            {
                System.Console.WriteLine($"Education: {item.Education}, Years Of Experience: {item.YearsOfExperience}, List of Specialization: {item.Specializations}\n");
            
            }
            return null;
        }
    }
}