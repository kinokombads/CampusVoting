using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;

namespace CampusVoting.Views
{
    public partial class GradeAddForm : Form
    {
        public GradeAddForm()
        {
            InitializeComponent();
        }

        public GradeAddForm(GradeBl bl)
        {
            InitializeComponent();
            GradeBl = bl;
            NameTextEdit.Select();
        }

        public GradeBl GradeBl { get; set; }
        private const string PageName = "Grade Addition";

        private void GetParams()
        {
            GradeBl.ResetVmParams();
            GradeBl.VmParams.Title = NameTextEdit.Text;
            GradeBl.VmParams.Details = DetailMemoEdit.Text;
            GradeBl.VmParams.CreatedById = "1"; //todo temp
        }

        private void Save()
        {
            string msg = "";
            if (GradeBl.AddOne(GradeBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Grade {0} has been added.", NameTextEdit.Text), PageName);
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
        
        private void GradeAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
        private void GradeAddForm_Load(object sender, EventArgs e)
        {
            //NameTextEdit.Focus();
        }

    }
}
