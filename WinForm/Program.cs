using CustomerManager.Libraries.Interfaces;
using CustomerManager.Libraries.Services;

namespace CustomerManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ICustomerService customerService = new CustomerService(5);
            ApplicationConfiguration.Initialize();
            Application.Run(new Home(customerService));
        }
    }
}