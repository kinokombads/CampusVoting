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

namespace CampusVoting.Views
{
    public partial class PositionDeleteForm : Form
    {
        public PositionDeleteForm()
        {
            InitializeComponent();
        }

        public PositionDeleteForm(PositionBl bl)
        {
            InitializeComponent();
            PositionBl = bl;
            LoadCombo();
            DisplayInfo();
            NameTextEdit.Select();
        }

        private const string PageName = "Position Deletion";

        public PositionBl PositionBl { get; set; }
        CandidateClearanceBl cbl = new CandidateClearanceBl();
        VoterClearanceBl vbl = new VoterClearanceBl();
        

        private void DisplayInfo()
        {
            NameTextEdit.Text = PositionBl.VmParams.Title;
            TypeTextEdit.Text = PositionBl.VmParams.PositionType;
            DetailMemoEdit.Text = PositionBl.VmParams.Details;
        }

        private void Save()
        {
            string msg = "";
            if (PositionBl.DeleteOne(PositionBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Position {0} has been deleted.",
                    NameTextEdit.Text), PageName);

                PositionBl.ChangeOccured = true;
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

            cbl.ComboItems = cbl.GetCombo(ref msgs).Where(x => x.Active).ToList();

            CandidateClearanceListBoxControl.DataSource = cbl.ComboItems;
            CandidateClearanceListBoxControl.DisplayMember = "Grade";
            CandidateClearanceListBoxControl.ValueMember = "GradeId";

            //for (int i = 0; i < CandidateClearanceCheckListBoxCon.ItemCount; i++)
            //{
            //    CandidateClearanceCheckListBoxCon.SetItemChecked(i, cbl.ComboItems[i].Active);
            //}


            vbl.ComboItems = vbl.GetCombo(ref msgs);

            VoterClearanceCheckedListBoxCon.DataSource = vbl.ComboItems;
            VoterClearanceCheckedListBoxCon.DisplayMember = "Grade";
            VoterClearanceCheckedListBoxCon.ValueMember = "GradeId";

            for (int i = 0; i < VoterClearanceCheckedListBoxCon.ItemCount; i++)
            {
                VoterClearanceCheckedListBoxCon.SetItemChecked(i, cbl.ComboItems[i].Active);
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

        private void PositionDeleteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
