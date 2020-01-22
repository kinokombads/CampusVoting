using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using Vota.Helpers;

namespace CampusVoting.Views
{
    public partial class GradeAndSectionEditForm : Form
    {
        public GradeAndSectionEditForm()
        {
            InitializeComponent();
        }

        public GradeAndSectionEditForm(GradeAndSectionBl bl)
        {
            InitializeComponent();
            GradeAndSectionBl = bl;
            LoadCombo();
            DisplayInfo();
            NameTextEdit.Select();
        }

        private GradeBl gradebl = new GradeBl();
        private SectionBl sectionBl = new SectionBl();

        private const string PageName = "Grade & Section Edition";
        private string id;
        private string previousName = "";

        public GradeAndSectionBl GradeAndSectionBl { get; set; }

        private void DisplayInfo()
        {
            id = GradeAndSectionBl.VmParams.Id;
            previousName = GradeAndSectionBl.VmParams.Title; //previous value

            NameTextEdit.Text = GradeAndSectionBl.VmParams.Title;
            GradeLookUp.EditValue = GradeAndSectionBl.VmParams.GradeId.GetInt();
            SectionLookUp.EditValue = GradeAndSectionBl.VmParams.SectionId.GetInt();
        }

        private void GetParams()
        {
            GradeAndSectionBl.ResetVmParams();
            GradeAndSectionBl.VmParams.Id = id;
            GradeAndSectionBl.VmParams.Title = NameTextEdit.Text;
            GradeAndSectionBl.VmParams.GradeId = GradeLookUp.EditValue.GetString();
            GradeAndSectionBl.VmParams.Grade = GradeLookUp.Properties.GetDisplayValueByKeyValue(GradeLookUp.EditValue).GetString();
            GradeAndSectionBl.VmParams.SectionId = SectionLookUp.EditValue.GetString();
            GradeAndSectionBl.VmParams.Section = SectionLookUp.Properties.GetDisplayValueByKeyValue(SectionLookUp.EditValue).GetString();
            GradeAndSectionBl.VmParams.ModifiedById = "1"; //todo temp
        }

        private void Save()
        {
            string msg = "";
            if (GradeAndSectionBl.EditOne(GradeAndSectionBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Grade & Section {0} is updated to Grade {1}",
                    previousName, NameTextEdit.Text), PageName);

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
                MessageBox.Show(msg, PageName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GradeLookUp.Properties.DataSource = gradebl.ComboItems;
            GradeLookUp.Properties.DisplayMember = "Title";
            GradeLookUp.Properties.ValueMember = "Id";


            sectionBl.ComboItems = sectionBl.GetCombo(sectionBl.VmParams, ref msg);

            if (msg != "")
            {
                MessageBox.Show(msg, PageName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SectionLookUp.Properties.DataSource = sectionBl.ComboItems;
            SectionLookUp.Properties.DisplayMember = "Title";
            SectionLookUp.Properties.ValueMember = "Id";
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

        private void GradeAndSectionEditForm_FormClosing(object sender, FormClosingEventArgs e)
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
