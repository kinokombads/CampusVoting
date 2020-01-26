using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.Helpers;

namespace CampusVoting.Views
{
    public partial class SchoolYearEditForm : Form
    {
        public SchoolYearEditForm()
        {
            InitializeComponent();
        }

        public SchoolYearEditForm(SchoolYearBl bl)
        {
            InitializeComponent();
            SchoolYearBl = bl;
            DisplayInfo();
            NameTextEdit.Select();
        }

        private const string PageName = "School Year Edition";
        private string id;
        private string previousName = "";

        public SchoolYearBl SchoolYearBl { get; set; }

        private void DisplayInfo()
        {
            id = SchoolYearBl.VmParams.Id;
            previousName = SchoolYearBl.VmParams.Title; //previous value

            NameTextEdit.Text = SchoolYearBl.VmParams.Title;
            ActiveSwitch.IsOn = SchoolYearBl.VmParams.Active.GetInt().GetBool();
            DetailMemoEdit.Text = SchoolYearBl.VmParams.Details;
        }

        private void GetParams()
        {
            SchoolYearBl.ResetVmParams();
            SchoolYearBl.VmParams.Id = id;
            SchoolYearBl.VmParams.Title = NameTextEdit.Text;
            SchoolYearBl.VmParams.Active = ActiveSwitch.EditValue.GetString();
            SchoolYearBl.VmParams.Details = DetailMemoEdit.Text;
            SchoolYearBl.VmParams.ModifiedById = "1"; //todo temp
        }

        private void Save()
        {
            string msg = "";
            if (SchoolYearBl.EditOne(SchoolYearBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("School Year {0} is updated to School Year {1}",
                    previousName, NameTextEdit.Text), PageName);

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
            DetailMemoEdit.Text = "";
            ActiveSwitch.EditValue = false;
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

        private void SchoolYearEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
