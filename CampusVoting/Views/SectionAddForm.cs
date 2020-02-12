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
using CampusVoting.PageHelpers;

namespace CampusVoting.Views
{
    public partial class SectionAddForm : Form
    {
        public SectionAddForm()
        {
            InitializeComponent();
        }

        public SectionAddForm(SectionBl bl)
        {
            InitializeComponent();
            SectionBl = bl;
            NameTextEdit.Select();
        }

        public SectionBl SectionBl { get; set; }
        private const string PageName = "Section Addition";

        private void GetParams()
        {
            SectionBl.ResetVmParams();
            SectionBl.VmParams.Title = NameTextEdit.Text;
            SectionBl.VmParams.Details = DetailMemoEdit.Text;
            SectionBl.VmParams.CreatedById = LoginDetail.UserId;
        }

        private void Save()
        {
            string msg = "";
            if (SectionBl.AddOne(SectionBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Section {0} has been added.", NameTextEdit.Text), PageName);
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

        private void SectionAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
