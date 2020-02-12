using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.Helpers;
using CampusVoting.PageHelpers;

namespace CampusVoting.Views
{
    public partial class SchoolYearAddForm : Form
    {
        public SchoolYearAddForm()
        {
            InitializeComponent();
        }

        public SchoolYearAddForm(SchoolYearBl bl)
        {
            InitializeComponent();
            SchoolYearBl = bl;
            NameTextEdit.Select();
        }

        public SchoolYearBl SchoolYearBl { get; set; }
        private const string PageName = "School Year Addition";

        private void GetParams()
        {
            SchoolYearBl.ResetVmParams();
            SchoolYearBl.VmParams.Title = NameTextEdit.Text;
            SchoolYearBl.VmParams.Active = ActiveSwitch.EditValue.GetString();
            SchoolYearBl.VmParams.Details = DetailMemoEdit.Text;
            SchoolYearBl.VmParams.CreatedById = LoginDetail.UserId;
        }

        private void Save()
        {
            string msg = "";
            if (SchoolYearBl.AddOne(SchoolYearBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("School Year {0} has been added.", NameTextEdit.Text), PageName);
                SchoolYearBl.ChangeOccured = true;
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
            ActiveSwitch.EditValue = false;
            DetailMemoEdit.Text = "";
        }


        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void SchoolYearAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

    }
}
