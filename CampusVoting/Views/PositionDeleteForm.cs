using System;
using System.Linq;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.ViewModels;

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
        GradeBl gbl1 = new GradeBl();
        GradeBl gbl2 = new GradeBl();
        

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

            //gbl1.ComboItems = gbl1.GetCombo(ref msgs);
            ////attempt to add all 
            ////will fail if dupplicate
            //foreach (var item in gbl1.ComboItems)
            //{
            //    CandidateClearanceVm obj = new CandidateClearanceVm();
            //    obj.GradeId = item.Id;
            //    obj.PositionId = PositionBl.VmParams.Id;

            //    cbl.AddOne(obj, ref msgs);
            //}

            //retieve the candidate clearances
            msgs = "";
            cbl.VmParams.PositionId = PositionBl.VmParams.Id;
            cbl.ListVm = cbl.GetList(cbl.VmParams, ref msgs).Where(x => x.Active).ToList();

            //make the candidate clearances as the datasource
            CandidateClearanceListBoxCon.DataSource = cbl.ListVm;
            CandidateClearanceListBoxCon.DisplayMember = "Grade";
            CandidateClearanceListBoxCon.ValueMember = "Id";




            //gbl2.ComboItems = gbl2.GetCombo(ref msgs);
            ////attempt to add all 
            ////will fail if duplicate
            //foreach (var item in gbl2.ComboItems)
            //{
            //    VoterClearanceVm obj = new VoterClearanceVm();
            //    obj.GradeId = item.Id;
            //    obj.PositionId = PositionBl.VmParams.Id;

            //    vbl.AddOne(obj, ref msgs);
            //}

            //retieve the voter clearances
            msgs = "";
            vbl.VmParams.PositionId = PositionBl.VmParams.Id;
            vbl.ListVm = vbl.GetList(vbl.VmParams, ref msgs).Where(x => x.Active).ToList();

            //make the voter clearances as the datasource
            VoterClearanceListBoxCon.DataSource = vbl.ListVm;
            VoterClearanceListBoxCon.DisplayMember = "Grade";
            VoterClearanceListBoxCon.ValueMember = "Id";

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
