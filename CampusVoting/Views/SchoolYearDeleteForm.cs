using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;

namespace CampusVoting.Views
{
    public partial class SchoolYearDeleteForm : Form
    {
        public SchoolYearDeleteForm()
        {
            InitializeComponent();
        }

        public SchoolYearDeleteForm(SchoolYearBl bl)
        {
            InitializeComponent(); 
            SchoolYearBl = bl;
            DisplayInfo();
            NameTextEdit.Select();
        }

        private const string PageName = "School Year Deletion";

        public SchoolYearBl SchoolYearBl { get; set; }

        private void DisplayInfo()
        {
            NameTextEdit.Text = SchoolYearBl.VmParams.Title;
            ActiveSwitch.EditValue = SchoolYearBl.VmParams.Active;
            DetailMemoEdit.Text = SchoolYearBl.VmParams.Details;
        }
        
        private void Save()
        {
            string msg = "";
            if (SchoolYearBl.DeleteOne(SchoolYearBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("School Year {0} has been deleted.",
                    NameTextEdit.Text), PageName);

                SchoolYearBl.ChangeOccured = true;
                Close();
            }
            else if (msg != "")
            {
                MessageBox.Show(msg, PageName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void SchoolYearDeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
