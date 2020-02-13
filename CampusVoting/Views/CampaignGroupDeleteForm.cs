using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;

namespace CampusVoting.Views
{
    public partial class CampaignGroupDeleteForm : Form
    {
        public CampaignGroupDeleteForm()
        {
            InitializeComponent();
        }

        public CampaignGroupDeleteForm(CampaignGroupBl bl)
        {
            InitializeComponent();
            GetActiveSchoolYear();
            CampaignGroupBl = bl;
            DisplayInfo();
            NameTextEdit.Select();
        }

        private const string PageName = "Campaign Group Deletion";

        public CampaignGroupBl CampaignGroupBl { get; set; }
        SchoolYearBl schoolYearBl = new SchoolYearBl();

        private void DisplayInfo()
        {
            NameTextEdit.Text = CampaignGroupBl.VmParams.Title;
            SchoolYearTextEdit.Tag = schoolYearBl.VmParams.Id;
            SchoolYearTextEdit.Text = CampaignGroupBl.VmParams.SchoolYear;
            DetailMemoEdit.Text = CampaignGroupBl.VmParams.Details;
        }

        private void Save()
        {
            string msg = "";
            if (CampaignGroupBl.DeleteOne(CampaignGroupBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Campaign Group {0} has been deleted.",
                    NameTextEdit.Text), PageName);

                CampaignGroupBl.ChangeOccured = true;
                Close();
            }
            else if (msg != "")
            {
                MessageBox.Show(msg, PageName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetActiveSchoolYear()
        {
            if (schoolYearBl.GetActive()) return;
            MessageBox.Show("There is no Active School Year.", "No Active School Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }


        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveSimButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("Are you sure to delete {0}?", NameTextEdit.Text), PageName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) Save();
        }

        private void CancelSimButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CampaignGroupDeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
