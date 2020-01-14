using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;

namespace CampusVoting.Views
{
    public partial class SectionDeleteForm : Form
    {
        public SectionDeleteForm()
        {
            InitializeComponent();
        }

        public SectionDeleteForm(SectionBl bl)
        {
            InitializeComponent();
            SectionBl = bl;
            DisplayInfo();
        }

        private const string PageName = "Section Deletion";
        private string id;

        public SectionBl SectionBl { get; set; }


        private void DisplayInfo()
        {
            id = SectionBl.VmParams.Id;
            NameTextEdit.Text = SectionBl.VmParams.Title;
            DetailMemoEdit.Text = SectionBl.VmParams.Details;
        }

        private void Save()
        {
            string msg = "";
            if (SectionBl.DeleteOne(SectionBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Section {0} has been deleted.",
                    NameTextEdit.Text), PageName);

                SectionBl.ChangeOccured = true;
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

        private void SectionDeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
