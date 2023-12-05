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
    public class ProfileRepository : IProfileRepository
    {
        public static string profilePath = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\profile.txt";
        public void Create(Profile obj)
        {
            DentalLab.ProfileDb.Add(obj);
            using (StreamWriter profiles = new StreamWriter(profilePath, true))
            {
                var ToString = JsonSerializer.Serialize(obj);
                profiles.WriteLine(ToString);

            }
        }

        public Profile Get(string userEmail)
        {
            return DentalLab.ProfileDb.SingleOrDefault(pr => pr.UserEmail == userEmail && pr.IsDeleted == false);
        }

        public List<Profile> GetAll()
        {
            return DentalLab.ProfileDb;
        }
    }
}