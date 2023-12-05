using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalLabConsoleApp.BusinessLogic.Implementation;
using DentalLabConsoleApp.BusinessLogic.Interface;
using DentalLabConsoleApp.Dbcontext;
using DentalLabConsoleApp.Models;

namespace DentalLabConsoleApp.Menu
{
    public class MainMenu
    {
        IUserBusinessLogic userBusinessLogic = new UserBusinessLogic();
        IAppointmentBusinessLogic appointmentBusinessLogic = new AppointmentBusinessLogic();
        IPatientBusinessLogic patientBusinessLogic = new PatientBusinessLogic();
        IDoctorBusinessLogic doctorBusinessLogic = new DoctorBusinessLogic();
        IProfileBusinessLogic profileBusinessLogic = new ProfileBusinessLogic();

        public MainMenu()
        {
            FileDb.CreateFile();
        }

        public void Main()
        {
            try
            {
                System.Console.WriteLine("========WELCOME TO RDT DENTAL SERVICE=========");
                System.Console.WriteLine("Enter 1 to Register \nEnter 2 to Login");
                int options = int.Parse(Console.ReadLine());
                if (options == 1)
                {
                    RegistrationMenu();
                    System.Console.WriteLine("Registration successful");
                    System.Console.WriteLine();
                    System.Console.WriteLine("Enter your login details");
                    LoginMenu();
                }
                else if (options == 2)
                {
                    LoginMenu();
                    System.Console.WriteLine();
                }
                else
                {
                    System.Console.WriteLine("Invalid input");
                    Main();
                }
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Invalid input");
                System.Console.WriteLine();
                Main();
            }

        }

        public void RegistrationMenu()
        {
            System.Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            System.Console.WriteLine("Enter your Last Name");
            string lastName = Console.ReadLine();
            System.Console.WriteLine("Enter your Address");
            string address = Console.ReadLine();
            System.Console.WriteLine("Enter your Contact");
            string contact = Console.ReadLine();
            System.Console.WriteLine("Enter your Date of Birth");
            string dateOfBirth = Console.ReadLine();
            System.Console.WriteLine("Enter your Gender");
            string gender = Console.ReadLine();
            System.Console.WriteLine("Enter your User Email");
            string userEmail = Console.ReadLine();
            System.Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            patientBusinessLogic.Create(firstName, lastName, address, contact, dateOfBirth, gender, userEmail, password);

            System.Console.WriteLine("Enter detials to login");
            System.Console.WriteLine();
            LoginMenu();
            System.Console.WriteLine();

        }

        public void LoginMenu()
        {
            try
            {

                System.Console.WriteLine("Enter your Useremail");
                string email = Console.ReadLine();
                System.Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                var login = userBusinessLogic.Login(email, password);
                if (login != null)
                {

                    if (login.Role == "Patient")
                    {
                        PatientMenu patientMenu = new PatientMenu();
                        patientMenu.Patients();
                    }
                    else if (login.Role == "Doctor")
                    {
                        DoctorMenu doctorMenu = new DoctorMenu();
                        doctorMenu.Doctor();
                    }
                    else
                    {
                        Main();
                    }
                    Main();
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Invalid input");
                System.Console.WriteLine();
                Main();
            }
        }
    }
}