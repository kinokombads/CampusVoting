using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusVoting.Views;

namespace CampusVoting
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>[STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PositionAddForm());
            Application.Run(new MainForm());
        }
    }
}
