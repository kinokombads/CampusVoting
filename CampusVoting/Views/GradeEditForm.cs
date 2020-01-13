using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;

namespace CampusVoting.Views
{
    public partial class GradeEditForm : Form
    {
        public GradeEditForm()
        {
            InitializeComponent();
        }

        public GradeEditForm(GradeBl bl)
        {
            InitializeComponent();
            GradeBl = bl;
            DisplayInfo();
            NameTextEdit.Select();
        }

        private const string PageName = "Grade Edition";
        private string id;
        private string previousName = "";

        public GradeBl GradeBl { get; set; }
        
        private void DisplayInfo()
        {
            id = GradeBl.VmParams.Id;
            previousName = GradeBl.VmParams.Title; //previous value

            NameTextEdit.Text = GradeBl.VmParams.Title;
            DetailMemoEdit.Text = GradeBl.VmParams.Details;
        }

        private void GetParams()
        {
            GradeBl.ResetVmParams();
            GradeBl.VmParams.Id = id;
            GradeBl.VmParams.Title = NameTextEdit.Text;
            GradeBl.VmParams.Details = DetailMemoEdit.Text;
            GradeBl.VmParams.ModifiedById = "1"; //todo temp
        }

        private void Save()
        {
            string msg = "";
            if (GradeBl.EditOne(GradeBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Grade {0} is updated to Grade {1}",
                    previousName, NameTextEdit.Text), PageName);

                GradeBl.ChangeOccured = true;
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

        private void GradeEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
