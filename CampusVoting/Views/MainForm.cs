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
        }

        private void Navigation_Click(object sender, EventArgs e)
        {
            AccordionControlElement navPressed = (AccordionControlElement)sender;
            MainContentPanel.Controls.Clear();

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
                case "Sections":
                    var sectionList = new SectionListCon { Dock = DockStyle.Fill };
                    MainContentPanel.Controls.Add(sectionList);
                    break;
                case "Grade And Sections":
                    var gradeSectionList = new GradeAndSectionListCon { Dock = DockStyle.Fill };
                    MainContentPanel.Controls.Add(gradeSectionList);
                    break;
                default:
                    break;
            }
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

     
    }
}
