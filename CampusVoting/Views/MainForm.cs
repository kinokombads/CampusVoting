using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusVoting.Views.UserCons;

namespace CampusVoting.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //MainContentPanel.Controls.Add(new SampleListPage() { Dock = DockStyle.Fill });
            //MainContentPanel.Controls.Add(new GradeListXtraCon());
            MainContentPanel.Controls.Add(new GradeListXtraCon{ Dock = DockStyle.Fill });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void SidePanel_MouseHover(object sender, EventArgs e)
        {SidePanel.Width = 148;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
