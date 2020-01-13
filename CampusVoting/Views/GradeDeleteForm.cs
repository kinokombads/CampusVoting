using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;

namespace CampusVoting.Views
{
    public partial class GradeDeleteForm : Form
    {
        public GradeDeleteForm()
        {
            InitializeComponent();
        }

        public GradeDeleteForm(GradeBl bl)
        {
            InitializeComponent();
            GradeBl = bl;
            DisplayInfo();
        }

        private const string PageName = "Grade Deletion";
        private string id;

        public GradeBl GradeBl { get; set; }
        

        private void DisplayInfo()
        {
            id = GradeBl.VmParams.Id;
            NameTextEdit.Text = GradeBl.VmParams.Title;
            DetailMemoEdit.Text = GradeBl.VmParams.Details;
        }

        private void Save()
        {
            string msg = "";
            if (GradeBl.EditOne(GradeBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Grade {0} has been deleted.",
                    NameTextEdit.Text), PageName);

                GradeBl.ChangeOccured = true;
                Close();
            }
            else if (msg != "")
            {
                MessageBox.Show(msg, PageName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveSimButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("Are you sure to delete {0}?", NameTextEdit.Text), PageName, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes) Save();
        }

        private void CancelSimButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GradeDeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        
    }
}
