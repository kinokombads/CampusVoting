using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.Helpers;
using CampusVoting.PageHelpers;

namespace CampusVoting.Views
{
    public partial class CampaignGroupEditForm : Form
    {
        public CampaignGroupEditForm()
        {
            InitializeComponent();
        }

        public CampaignGroupEditForm(CampaignGroupBl bl)
        {
            InitializeComponent();
            GetActiveSchoolYear();
            CampaignGroupBl = bl;
            DisplayInfo();
            SchoolYearTextEdit.Tag = schoolYearBl.VmParams.Id;
            SchoolYearTextEdit.Text = schoolYearBl.VmParams.Title;
            NameTextEdit.Select();
        }

        private const string PageName = "School Year Edition";
        private string id;
        private string previousName = "";

        public CampaignGroupBl CampaignGroupBl { get; set; }
        private SchoolYearBl schoolYearBl = new SchoolYearBl();

        private void DisplayInfo()
        {
            id = CampaignGroupBl.VmParams.Id;
            previousName = CampaignGroupBl.VmParams.Title; //previous value

            NameTextEdit.Text = CampaignGroupBl.VmParams.Title;
            SchoolYearTextEdit.Tag = schoolYearBl.VmParams.Id;
            SchoolYearTextEdit.Text = schoolYearBl.VmParams.Title;
            DetailMemoEdit.Text = CampaignGroupBl.VmParams.Details;
        }

        private void GetParams()
        {
            CampaignGroupBl.ResetVmParams();
            CampaignGroupBl.VmParams.Id = id;
            CampaignGroupBl.VmParams.Title = NameTextEdit.Text;
            CampaignGroupBl.VmParams.SchoolYearId = schoolYearBl.VmParams.Id;
            CampaignGroupBl.VmParams.Details = DetailMemoEdit.Text;
            CampaignGroupBl.VmParams.ModifiedById = LoginDetail.UserId;
        }

        private void Save()
        {
            string msg = "";
            if (CampaignGroupBl.EditOne(CampaignGroupBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("School Year {0} is updated to School Year {1}",
                    previousName, NameTextEdit.Text), PageName);

                CampaignGroupBl.ChangeOccured = true;
                Close();
            }
            else if (msg != "")
            {
                MessageBox.Show(msg, PageName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clearer()
        {
            NameTextEdit.Text = "";
            DetailMemoEdit.Text = "";
        }

        private void GetActiveSchoolYear()
        {
            if (schoolYearBl.GetActive()) return;
            MessageBox.Show("There is no Active School Year.", "No Active School Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }


        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveSimButton_Click(object sender, EventArgs e)
        {
            GetParams();
            Save();
        }

        private void ClearSimButton_Click(object sender, EventArgs e)
        {
            Clearer();
        }

        private void CampaignGroupEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
