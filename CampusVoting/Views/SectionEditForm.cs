using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.PageHelpers;

namespace CampusVoting.Views
{
    public partial class SectionEditForm : Form
    {
        public SectionEditForm()
        {
            InitializeComponent();
        }

        public SectionEditForm(SectionBl bl)
        {
            InitializeComponent();
            SectionBl = bl;
            DisplayInfo();
            NameTextEdit.Select();
        }

        private const string PageName = "Section Edition";
        private string id;
        private string previousName = "";

        public SectionBl SectionBl { get; set; }

        private void DisplayInfo()
        {
            id = SectionBl.VmParams.Id;
            previousName = SectionBl.VmParams.Title; //previous value

            NameTextEdit.Text = SectionBl.VmParams.Title;
            DetailMemoEdit.Text = SectionBl.VmParams.Details;
        }

        private void GetParams()
        {
            SectionBl.ResetVmParams();
            SectionBl.VmParams.Id = id;
            SectionBl.VmParams.Title = NameTextEdit.Text;
            SectionBl.VmParams.Details = DetailMemoEdit.Text;
            SectionBl.VmParams.ModifiedById = LoginDetail.UserId;
        }

        private void Save()
        {
            string msg = "";
            if (SectionBl.EditOne(SectionBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Section {0} is updated to Section {1}",
                    previousName, NameTextEdit.Text), PageName);

                SectionBl.ChangeOccured = true;
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
        
        private void SectionEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
