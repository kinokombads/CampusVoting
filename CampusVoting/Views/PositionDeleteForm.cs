using System;
using System.Linq;
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


            //this will load the checked candidate clearances
            cbl.ComboItems = cbl.GetCombo(PositionBl.VmParams.Id, ref msgs).Where(x => x.Active).ToList();

            CandidateClearanceListBoxControl.DataSource = cbl.ComboItems;
            CandidateClearanceListBoxControl.DisplayMember = "Grade";
            CandidateClearanceListBoxControl.ValueMember = "GradeId";


            //this will load the checked voter clearances
            vbl.ComboItems = vbl.GetCombo(PositionBl.VmParams.Id, ref msgs);

            VoterClearanceListBoxControl.DataSource = vbl.ComboItems;
            VoterClearanceListBoxControl.DisplayMember = "Grade";
            VoterClearanceListBoxControl.ValueMember = "GradeId";
            
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
