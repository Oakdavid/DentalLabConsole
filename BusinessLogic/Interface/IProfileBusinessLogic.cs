using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.BusinessLogic.Interface
{
    public interface IProfileBusinessLogic
    {
        Profile Create(Profile profile);
        Profile Get(string email);
        Profile GetAll();
        
    }
}