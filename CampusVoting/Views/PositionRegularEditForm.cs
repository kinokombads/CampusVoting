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
using CampusVoting.Helpers;
using CampusVoting.ViewModels;

namespace CampusVoting.Views
{
    public partial class PositionRegularEditForm : Form
    {
        public PositionRegularEditForm()
        {
            InitializeComponent();
        }

        public PositionRegularEditForm(PositionBl bl)
        {
            InitializeComponent();
            PositionBl = bl;
            LoadCombo();
            DisplayInfo();
            NameTextEdit.Select();
        }

        private const string PageName = "Regular Position Edition";
        private string id;
        private string previousName = "";

        public PositionBl PositionBl { get; set; }

        private void DisplayInfo()
        {
            id = PositionBl.VmParams.Id;
            previousName = PositionBl.VmParams.Title; //previous value

            NameTextEdit.Text = PositionBl.VmParams.Title;
            TypeLookUp.EditValue = PositionBl.VmParams.PositionType;
            DetailMemoEdit.Text = PositionBl.VmParams.Details;
        }

        private void GetParams()
        {
            PositionBl.ResetVmParams();
            PositionBl.VmParams.Id = id;
            PositionBl.VmParams.Title = NameTextEdit.Text;
            PositionBl.VmParams.PositionType = TypeLookUp.EditValue.GetString();
            PositionBl.VmParams.Details = DetailMemoEdit.Text;
            PositionBl.VmParams.ModifiedById = "1"; //todo temp
        }

        private void Save()
        {
            string msg = "";
            if (PositionBl.EditOne(PositionBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Position {0} is updated to Position {1}",
                    previousName, NameTextEdit.Text), PageName);

                PositionBl.ChangeOccured = true;
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

        private void LoadCombo()
        {

            TypeLookUp.Properties.DataSource = PositionBl.PositionTypes;
            TypeLookUp.Properties.DisplayMember = "Title";
            TypeLookUp.Properties.ValueMember = "Id";
        }



        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveSimButton_Click(object sender, EventArgs e)
        {
            GetParams();
            Save();
        }

        private void ClearSimButton_Click(object sender, EventArgs e)
        {
            this.Clearer();
        }

        private void PositioniRegularEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

    }
}
