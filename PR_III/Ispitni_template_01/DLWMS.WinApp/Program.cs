using DLWMS.WinApp._2367;

namespace DLWMS.WinApp
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
            var startnaForma = new frmKakoHoces();
            Application.Run(startnaForma);
        }
    }
}