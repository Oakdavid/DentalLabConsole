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
    public class ProfileBusinessLogic : IProfileBusinessLogic
    {
        IProfileRepository profileRepository = new ProfileRepository();
        public Profile Create(Profile profile)
        {
            var profiles = profileRepository.Get(profile.UserEmail);
            if(profiles != null)
            {
                System.Console.WriteLine($"{profiles} already exist");
            }
            var profileProfile = new Profile
            {
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                Contact = profile.Contact,
                Address = profile.Address,
                DateOfBirth = profile.DateOfBirth,
                Gender = profile.Gender,
                UserEmail = profile.UserEmail,
                IsDeleted = false,
                Id = DentalLab.ProfileDb.Count + 1,
            };
            profileRepository.Create(profile);
            return profile;
        }

        public Profile Get(string email)
        {
            var profile = profileRepository.Get(email);
            if(profile == null)
            {
                System.Console.WriteLine($"{email} does not exist");
                return null;
            }
            return profile;
        }

        public Profile GetAll()
        {
           var getAll = profileRepository.GetAll();
           foreach (var item in getAll)
           {
                System.Console.WriteLine($"FirstName: {item.FirstName},LastName: {item.LastName},Address: {item.Address}, Contact: {item.Contact}, DateOfBirth: {item.DateOfBirth}, Gender: {item.Gender}, UserEmail: {item.UserEmail}\n");
           }
           return null;
        }
    }
}