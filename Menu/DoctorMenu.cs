using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.BusinessLogic.Implementation;
using DentalLabConsoleApp.BusinessLogic.Interface;

namespace DentalLabConsoleApp.Menu
{
    public class DoctorMenu
    {
        IDoctorBusinessLogic doctorBusinessLogic = new DoctorBusinessLogic();
        IPatientBusinessLogic patientBusinessLogic = new PatientBusinessLogic();
        IUserBusinessLogic userBusinessLogic = new UserBusinessLogic();
        IAppointmentBusinessLogic appointmentBusinessLogic = new AppointmentBusinessLogic();
        public void Doctor()
        {
            System.Console.WriteLine("Press 1 to view all Patient \nPress 2 to view all Appointment \nPress 3 to send report\nPress 0 to go back to Main Menu");
            string options = Console.ReadLine();
            if (options == "1")
            {
                ViewAllPatient();
                System.Console.WriteLine();
                Doctor();
            }
            else if (options == "2")
            {
                ViewAllAppointment();
                System.Console.WriteLine();
                Doctor();
            }
            else if (options == "3")
            {
                Report();
                System.Console.WriteLine();
                Doctor();
                System.Console.WriteLine();
            }
            else if (options == "0")
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Main();
                System.Console.WriteLine();
            }

        }

        public void ViewAllPatient()
        {
            patientBusinessLogic.GetAll();

        }
        public void ViewAllAppointment()
        {
            appointmentBusinessLogic.GetAll();
        }

        public void Report()
        {
            System.Console.WriteLine("Work in Progress");
        }


    }
}