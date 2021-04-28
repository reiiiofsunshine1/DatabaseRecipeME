using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabasePersonalPBO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcomepg());

            Console.WriteLine("-------- Hello there! --------");
            customer userinput = new customer();
            Console.WriteLine("What do you want to do today?");
        }
    }
}
