using System;

using System.Windows.Forms;

namespace AdoNet
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application.
            Application.EnableVisualStyles();

            // Set the default text rendering for the application.
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form (Form1) of the application.
            Application.Run(new Form1());
        }
    }
}
