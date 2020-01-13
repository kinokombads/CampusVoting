using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusVoting.PageHelpers;
using CampusVoting.Views.UserCons;
using DevExpress.XtraBars.Navigation;

namespace CampusVoting.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //MainContentPanel.Controls.Add(new SampleListPage() { Dock = DockStyle.Fill });
            //MainContentPanel.Controls.Add(new GradeListXtraCon());
            MainContentPanel.Controls.Add(new GradeListCon{ Dock = DockStyle.Fill });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            //GridControlOption.CustomDrawRowIndicator(ListGridControl, ItemsGridView);
            //ItemsGridView.OptionsBehavior.AutoPopulateColumns = false;
        }

        private void Navigation_Click(object sender, EventArgs e)
        {
            AccordionControlElement navPressed = (AccordionControlElement)sender;

            switch (navPressed.Text)
            {
                case "Voting Session":
                    break;
                case "School Years":
                    break;
                case "Students":
                    break;
                case "Candidates":
                    break;
                case "Grades":
                    var gradeList = new GradeListCon { Dock = DockStyle.Fill };
                    MainContentPanel.Controls.Add(gradeList);

                    break;
                default:
                    break;
            }
        }

     
    }
}
