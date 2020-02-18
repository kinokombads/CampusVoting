using System;
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
            LoginDetail.UserId = "1";
        }

        private void Navigation_Click(object sender, EventArgs e)
        {
            AccordionControlElement navPressed = (AccordionControlElement)sender;
            MainContentPanel.Controls.Clear();

            dynamic listCon = null;


            switch (navPressed.Text)
            {
                case "Voting Session":
                    break;
                case "School Years":
                    listCon = new SchoolYearListCon { Dock = DockStyle.Fill };
                    //MainContentPanel.Controls.Add(schoolYearList);
                    break;case "Students":
                    break;
                case "Candidates":
                    break;
                case "Grades":listCon = new GradeListCon { Dock = DockStyle.Fill };
                    break;
                case "Campaign Groups":
                    listCon = new CampaignGroupListCon { Dock = DockStyle.Fill };
                    break;
                case "Sections":
                    listCon = new SectionListCon { Dock = DockStyle.Fill };
                    break;
                case "Grade And Sections":
                    listCon = new GradeAndSectionListCon { Dock = DockStyle.Fill };
                    break;
                case "Positions":
                    listCon = new PositionListCon { Dock = DockStyle.Fill };
                    break;
                default:
                    break;
            }

            if (listCon != null) MainContentPanel.Controls.Add(listCon);
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
