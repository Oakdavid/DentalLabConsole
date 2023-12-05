using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.BusinessLogic.Interface
{
    public interface IUserBusinessLogic
    {
        User Login(string email, string password);
        User Get(string email);
        List<User> GetAll();
    }
}