using static System.Windows.Forms.Application;

namespace Gimpies_form
{
    internal static class Program
    {
        /// <Docs>
        ///  The main entry point for the application.
        /// </Docs>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Run(new Form1()); // open the login form, in the login.cs file.
        }
    }
}