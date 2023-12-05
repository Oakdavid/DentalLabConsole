// See https://aka.ms/new-console-template for more information
using DentalLabConsoleApp.BusinessLogic.Implementation;
using DentalLabConsoleApp.Dbcontext;
using DentalLabConsoleApp.Menu;
using DentalLabConsoleApp.Models;
using DentalLabConsoleApp.Repository.Inplementation;


// MainMenu mainMenu = new MainMenu();
// mainMenu.Main();

// AppointmentBusinessLogic appointmentBusinessLogic = new AppointmentBusinessLogic();
// appointmentBusinessLogic.Create("luna@gmail.com", 23, "I'm having gum issue", DateTime.UtcNow);
FileDb.CreateFile();


ProfileBusinessLogic profileBusinessLogic = new ProfileBusinessLogic();
profileBusinessLogic.GetAll();