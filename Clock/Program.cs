using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Clock
{
    //This is the important part. It better run. Hi there!!! 
    internal static class Program
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DoStuff();
            var t = new Form1();
            t.Top = Screen.PrimaryScreen.Bounds.Bottom - 125;
            t.Left = Screen.PrimaryScreen.Bounds.Right - 250;
            Application.Run(t);
        }
        public static void DoStuff()
        {
            Console.WriteLine("Caution! Program is running!!!");
        }
    }
}
