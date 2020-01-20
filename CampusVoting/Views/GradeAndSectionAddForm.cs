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
using CampusVoting.ViewModels;
using CampusVoting.Views.UserCons;
using DevExpress.XtraEditors.Repository;
using Vota.Helpers;

namespace CampusVoting.Views
{
    public partial class GradeAndSectionAddForm : Form
    {
        public GradeAndSectionAddForm()
        {
            InitializeComponent();
            GradeAndSectionBl = new GradeAndSectionBl();
            LoadCombo();

        }

        public GradeAndSectionAddForm(GradeAndSectionBl bl)
        {
            InitializeComponent();
            GradeAndSectionBl = new GradeAndSectionBl();
            LoadCombo();
            NameTextEdit.Select();
        }

        public GradeAndSectionBl GradeAndSectionBl { get; set; }
        private GradeBl gradebl = new GradeBl();
        private SectionBl sectionBl = new SectionBl();
        private const string PageName = "Grade And Section Addition";

        private void GetParams()
        {
            GradeAndSectionBl.ResetVmParams();
            GradeAndSectionBl.VmParams.Title = NameTextEdit.Text;
            GradeAndSectionBl.VmParams.GradeId = GradeLookUp.EditValue.GetString();
            GradeAndSectionBl.VmParams.SectionId = SectionLookUp.EditValue.GetString();
            GradeAndSectionBl.VmParams.CreatedById = "1"; //todo temp
        }

        private void Save()
        {
            string msg = "";
            if (GradeAndSectionBl.AddOne(GradeAndSectionBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Grade And Section {0} has been added.", NameTextEdit.Text), PageName);
                GradeAndSectionBl.ChangeOccured = true;
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
            GradeLookUp.EditValue = null;
            SectionLookUp.EditValue = null;
        }

        private void LoadCombo()
        {
            string msg = "";
            gradebl.ComboItems = gradebl.GetCombo(gradebl.VmParams, ref msg);

            if (msg != "")
            {
                MessageBox.Show(msg, "Grade & Section Addition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GradeLookUp.Properties.DataSource = gradebl.ComboItems;
            GradeLookUp.Properties.DisplayMember = "Title";
            GradeLookUp.Properties.ValueMember = "Id";
            

            sectionBl.ComboItems = sectionBl.GetCombo(sectionBl.VmParams, ref msg);

            if (msg != "")
            {
                MessageBox.Show(msg, "Grade & Section Addition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SectionLookUp.Properties.DataSource = sectionBl.ComboItems;
            SectionLookUp.Properties.DisplayMember = "Title";
            SectionLookUp.Properties.ValueMember = "Id";
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
            Clearer();
        }

        private void GradeAndSectionAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        
        private void GradeLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (GradeLookUp.Properties.View.Columns["Id"].Visible)
            {
                GradeLookUp.Properties.View.Columns["Id"].Visible = false;
            }
        }

        private void SectionLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (SectionLookUp.Properties.View.Columns["Id"].Visible)
            {
                SectionLookUp.Properties.View.Columns["Id"].Visible = false;
            }
        }


    }
}
