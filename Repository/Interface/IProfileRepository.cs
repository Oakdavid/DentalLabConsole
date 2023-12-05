using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.Repository.Interface
{
    public interface IProfileRepository
    {
        void Create(Profile obj);
        Profile Get(string userEmail);
        List<Profile> GetAll();
        //void RefreshFile();
        
    }
}