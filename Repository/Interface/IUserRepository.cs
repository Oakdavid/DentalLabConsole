using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.Repository.Interface
{
    public interface IUserRepository
    {
        void Create(User user);
        User Get(string email);
        User GetByEmailAndPassword(string userEmail, string password);
        List<User> GetAll();
        void RefreshFile();
        
    }
}