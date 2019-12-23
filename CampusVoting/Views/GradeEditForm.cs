using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using Vota.Helpers;

namespace CampusVoting.Views
{
    public partial class GradeEditForm : Form
    {
        public GradeEditForm()
        {
            InitializeComponent();
        }

        public GradeEditForm(int id)
        {
            InitializeComponent();
            IdLabel.Text = id.GetString();
            pageLabel = PageLabel.Text;
            GetParams();
            DisplayData();
        }

        GradeBl bl = new GradeBl();
        private string pageLabel = "";

        private void GetParams()
        {
            bl.ResetParams();
            bl.Params.Id = IdLabel.Text.GetInt();
            bl.Params.Title = TitleTextBox.Text;
            bl.Params.Details = DetailsTextBox.Text;
            bl.Params.ModifiedById = 1;
        }

        private void Save()
        {
            string msg = "";
            if (bl.EditOne(bl.Params, ref msg))
            {
                MessageBox.Show("Updated", pageLabel);
            }
            else if (msg != "")
            {
                MessageBox.Show(msg, pageLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayData()
        {
            GetParams();
            bl.ResetOne();

            string msg = "";
            bl.Item = bl.GetOne(bl.Params, ref msg);

            if (msg != "")
            {
                MessageBox.Show(msg, "Retrieving Grade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IdLabel.Text = bl.Item.Id.GetString();
            TitleTextBox.Text = bl.Item.Title;
            DetailsTextBox.Text = bl.Item.Details;
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

        private void GradeEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

    }
}
