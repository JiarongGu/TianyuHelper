using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TianyuHelper.Module;
namespace TianyuHelper
{
    static class Program
    {
        public static FormHelper main;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            main = new FormHelper();
            Application.Run(main);
        }
    }
}
