using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.BusinessLogic.Implementation;
using DentalLabConsoleApp.BusinessLogic.Interface;
using DentalLabConsoleApp.Models;
using DentalLabConsoleApp.Repository.Inplementation;

namespace DentalLabConsoleApp.Menu
{
    public class PatientMenu
    {
        ISpecializationBusinessLogic specializationBusinessLogic = new SpecializationBusinessLogic();
        IPatientBusinessLogic patientBusinessLogic = new PatientBusinessLogic();
        IUserBusinessLogic userBusinessLogic = new UserBusinessLogic();
        IAppointmentBusinessLogic appointmentBusinessLogic = new AppointmentBusinessLogic();
        ConsultationTypeBusinessLogic consultationTypeBusinessLogic = new ConsultationTypeBusinessLogic();
        public void Patients()
        {
            System.Console.WriteLine("Press 1 to view all services \nPress 2 to book an Appointment \nPress 3 to view consultation type \nPress 4 to view doctors report \nPress 0 to Logout");
            string options = Console.ReadLine();
            if (options == "1")
            {
                ViewAllDoctorService();
                Patients();
            }
            else if (options == "2")
            {
                BookAppointment();
                Patients();
            }
            else if (options == "3")
            {
                ConsultationType();
                Patients();
            }
            else if (options == "4")
            {
                System.Console.WriteLine("Work in Progress");
                System.Console.WriteLine();
                Patients();
            }
            else if (options == "0")
            {
                MainMenu mainMenu = new MainMenu();
                mainMenu.Main();
            }



        }
        public void ViewAllDoctorService()
        {
            specializationBusinessLogic.GetAll();
        }
        public void BookAppointment()
        {
            System.Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            System.Console.WriteLine("Explain how you are feeling");
            // string complainType = Console.ReadLine();
            // System.Console.WriteLine("Enter your Complain");
            string patientFeellings = Console.ReadLine();
            System.Console.WriteLine("Enter 1 For Physical Appointment \nEnter 2 For Virtual Appointment");
            string options = Console.ReadLine();

            if (options == "1")
            {
                string name = "Physical Consultation";
                consultationTypeBusinessLogic.Get(name);
                System.Console.WriteLine();
            }
            else if (options == "2")
            {
                string name = "Virtual Consultation";
                consultationTypeBusinessLogic.Get(name);
                System.Console.WriteLine();
            }
            else
            {
                System.Console.WriteLine("invalid input\nPlease select either option 1 or 2");
                Patients();
            }
            appointmentBusinessLogic.Create(email, 0, patientFeellings, DateTime.UtcNow);
        }
        public void ConsultationType()
        {
            consultationTypeBusinessLogic.GetAll();
            System.Console.WriteLine();
        }

        public void ViewDoctorsReport()
        {
            System.Console.WriteLine("Work in Progress");
            System.Console.WriteLine();
        }
    }
}