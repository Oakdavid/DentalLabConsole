using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.BusinessLogic.Interface;
using DentalLabConsoleApp.Dbcontext;
using DentalLabConsoleApp.Menu;
using DentalLabConsoleApp.Models;
using DentalLabConsoleApp.Repository.Inplementation;
using DentalLabConsoleApp.Repository.Interface;

namespace DentalLabConsoleApp.BusinessLogic.Implementation
{

    public class UserBusinessLogic : IUserBusinessLogic
    {
        IUserRepository userRepository = new UserRepository();


        public User Get(string email)
        {
            var user = userRepository.Get(email);

            if (user == null)
            {
                System.Console.WriteLine($"{email} does not exist");
                return null;
            }
            return user;

        }

        public List<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public User Login(string email, string password)
        {
            var login = userRepository.GetByEmailAndPassword(email, password);
            if (login == null)
            {
                System.Console.WriteLine("wrong credentials");
                return null;
            }
            return login;
        }
    }
}