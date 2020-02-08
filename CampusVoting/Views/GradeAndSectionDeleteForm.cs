using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.Helpers;

namespace CampusVoting.Views
{
    public partial class GradeAndSectionDeleteForm : Form
    {
        public GradeAndSectionDeleteForm()
        {
            InitializeComponent();
        }

        public GradeAndSectionDeleteForm(GradeAndSectionBl bl)
        {
            InitializeComponent();
            GradeAndSectionBl = bl;
            LoadCombo();
            DisplayInfo();
        }

        private const string PageName = "Grade And Section Deletion";
        private GradeBl gradebl = new GradeBl();
        private SectionBl sectionBl = new SectionBl();

        public GradeAndSectionBl GradeAndSectionBl { get; set; }


        private void DisplayInfo()
        {
            NameTextEdit.Text = GradeAndSectionBl.VmParams.Title;
            GradeLookUp.EditValue = GradeAndSectionBl.VmParams.GradeId.GetInt();
            SectionLookUp.EditValue = GradeAndSectionBl.VmParams.SectionId.GetInt();
        }

        private void Save()
        {
            string msg = "";
            if (GradeAndSectionBl.DeleteOne(GradeAndSectionBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Grade And Section {0} has been deleted.",
                    NameTextEdit.Text), PageName);

                GradeAndSectionBl.ChangeOccured = true;
                Close();
            }
            else if (msg != "")
            {
                MessageBox.Show(msg, PageName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCombo()
        {
            string msgs = "";
            gradebl.ComboItems = gradebl.GetCombo(ref msgs);

            if (msgs != "")
            {
                MessageBox.Show(msgs, PageName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GradeLookUp.Properties.DataSource = gradebl.ComboItems;
            GradeLookUp.Properties.DisplayMember = "Title";
            GradeLookUp.Properties.ValueMember = "Id";


            sectionBl.ComboItems = sectionBl.GetCombo(ref msgs);

            if (msgs != "")
            {
                MessageBox.Show(msgs, PageName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DialogResult result = MessageBox.Show(string.Format("Are you sure to delete {0}?", NameTextEdit.Text), PageName, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (result == DialogResult.Yes) Save();
        }

        private void CancelSimButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GradeAndSectionDeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
