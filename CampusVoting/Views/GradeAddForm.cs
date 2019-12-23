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
            pageLabel = PageLabel.Text;

        }

        GradeBl bl = new GradeBl();
        private string pageLabel = "";
        private void GetParams()
        {
            bl.ResetParams();
            bl.Params.Title = TitleTextBox.Text;
            bl.Params.Details = DetailsTextBox.Text;
            bl.Params.CreatedById = 1;
        }

        private void Save()
        {
            string msg = "";
            if (bl.AddOne(bl.Params, ref msg))
            {
                MessageBox.Show("Saved", pageLabel);
            }
            else if (msg != "")
            {
                MessageBox.Show(msg, pageLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            GetParams();
            Save();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void GradeAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

    }
}
