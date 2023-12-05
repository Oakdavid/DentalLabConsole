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
    public class UserRepository : IUserRepository
    {
        public static string filePath = @"C:\Users\HP\Documents\Applications projects\DentalLabConsoleApp\DentalLabFiles\user.txt";
        public void Create(User user)
        {
            DentalLab.UserDb.Add(user);
            using (StreamWriter obj = new StreamWriter(filePath, true))
            {
                var ToString = JsonSerializer.Serialize(user);
                obj.WriteLine(ToString);
            }
        }

        public User Get(string email)
        {
            return DentalLab.UserDb.SingleOrDefault(u => u.Email == email);
        }

        public List<User> GetAll()
        {
            return DentalLab.UserDb;
        }

        public User GetByEmailAndPassword(string userEmail, string password)
        {
            return DentalLab.UserDb.SingleOrDefault(get => get.Email == userEmail && get.Password == password);
        }
        public void RefreshFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (var item in DentalLab.UserDb)
                {
                    var refreshFile = JsonSerializer.Serialize(item);
                    writer.WriteLine(refreshFile);
                }
            }
        }
    }
}