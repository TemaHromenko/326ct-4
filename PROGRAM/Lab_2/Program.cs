using System;
using System.Windows.Forms;

namespace Lab_2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StaticData.Init();
            Application.Run(new Form1());
        }
    }
}
