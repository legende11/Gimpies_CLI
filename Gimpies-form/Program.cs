using static System.Windows.Forms.Application;
using static Gimpies_form.ApplicationConfiguration;

namespace Gimpies_form
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
            Initialize();
            Run(new Form1()); // open the login form, in the login.cs file.
        }
    }
}