using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
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
            //var bl = new CampaignGroupBl();
            //bl.VmParams.Id = "1";
            //string msg = "";
            //bl.VmParams = bl.GetOne(bl.VmParams, ref msg);
            //Application.Run(new CampaignGroupEditForm(bl));
            Application.Run(new MainForm());
        }
    }}
