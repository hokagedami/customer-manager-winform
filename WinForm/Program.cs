using Libraries.Entities;
using Libraries.Services;

namespace WinForm
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
            ApplicationConfiguration.Initialize();
            Application.Run(new Home(new CustomerService()));
            var cq = new CircularMyQueue<string>(5);
            cq.Peek();
        }
    }
}