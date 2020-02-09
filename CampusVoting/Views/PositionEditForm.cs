using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.Helpers;
using CampusVoting.ViewModels;

namespace CampusVoting.Views
{
    public partial class PositionEditForm : Form
    {
        public PositionEditForm()
        {
            InitializeComponent();
        }

        public PositionEditForm(PositionBl bl)
        {
            InitializeComponent();
            PositionBl = bl;
            //TempItem();//todo erase
            DisplayInfo();
            LoadCombo();
            NameTextEdit.Select();
        }

        private const string PageName = "Regular Position Edition";
        private string id;
        private string previousName = "";

        public PositionBl PositionBl { get; set; }
        CandidateClearanceBl cbl = new CandidateClearanceBl();
        VoterClearanceBl vbl = new VoterClearanceBl();

        private void TempItem()
        {
            string msg = "";
            PositionBl.VmParams.Id = "7";

            PositionBl.VmParams = PositionBl.GetOne(PositionBl.VmParams, ref msg);

        }

        private void DisplayInfo()
        {
            id = PositionBl.VmParams.Id;
            previousName = PositionBl.VmParams.Title; //previous value

            NameTextEdit.Text = PositionBl.VmParams.Title;
            TypeTextEdit.Text = PositionBl.VmParams.PositionType;
            DetailMemoEdit.Text = PositionBl.VmParams.Details;
        }

        private void GetParams()
        {
            PositionBl.ResetVmParams();
            PositionBl.VmParams.Id = id;
            PositionBl.VmParams.Title = NameTextEdit.Text;
            PositionBl.VmParams.PositionType = TypeTextEdit.Text;
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
                SaveCands();
                SaveVoters();
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
            TypeTextEdit.Text = null;
            DetailMemoEdit.EditValue = "";
            CandidateClearanceCheckListBoxCon.UnCheckAll();
            VoterClearanceCheckedListBoxCon.UnCheckAll();
        }

        private void LoadCombo()
        {
            string msgs = "";

            cbl.ComboItems = cbl.GetCombo(id, ref msgs);
            
            CandidateClearanceCheckListBoxCon.DataSource = cbl.ComboItems;
            CandidateClearanceCheckListBoxCon.DisplayMember = "Grade";
            CandidateClearanceCheckListBoxCon.ValueMember = "GradeId";

            for (int i = 0; i < CandidateClearanceCheckListBoxCon.ItemCount; i++)
            {
                CandidateClearanceCheckListBoxCon.SetItemChecked(i, cbl.ComboItems[i].Active);
            }


            vbl.ComboItems = vbl.GetCombo(PositionBl.VmParams.Id, ref msgs);

            VoterClearanceCheckedListBoxCon.DataSource = vbl.ComboItems;
            VoterClearanceCheckedListBoxCon.DisplayMember = "Grade";
            VoterClearanceCheckedListBoxCon.ValueMember = "GradeId";

            for (int i = 0; i < VoterClearanceCheckedListBoxCon.ItemCount; i++)
            {
                VoterClearanceCheckedListBoxCon.SetItemChecked(i, vbl.ComboItems[i].Active);
            }
        }

        private void SaveCands()
        {
            string newMsg = "";
            cbl.ResetVmList();

            List<CandidateClearanceComboVm> checkCands = CandidateClearanceCheckListBoxCon.CheckedItems.Cast<CandidateClearanceComboVm>().ToList();

            foreach (var clearance in cbl.ComboItems)
            {
                CandidateClearanceVm newItem = new CandidateClearanceVm();
                newItem.Id = clearance.Id;
                newItem.PositionId = clearance.PositionId;
                newItem.GradeId = clearance.GradeId;
                newItem.Active = checkCands.Exists(i => i.Id == clearance.Id).GetBool();

                if (cbl.EditOne(newItem, ref newMsg)) continue;
                MessageBox.Show(newMsg, "Candidate Clearance Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            }

        }

        private void SaveVoters()
        {
            string newMsg = "";
            vbl.ResetVmList();

            List<VoterClearanceComboVm> checkVoters = VoterClearanceCheckedListBoxCon.CheckedItems.Cast<VoterClearanceComboVm>().ToList();

            foreach (var clearance in vbl.ComboItems)
            {
                VoterClearanceVm newItem = new VoterClearanceVm();
                newItem.Id = clearance.Id;
                newItem.PositionId = clearance.PositionId;
                newItem.GradeId = clearance.GradeId;
                newItem.Active = checkVoters.Exists(i => i.Id == clearance.Id).ToString();

                if (vbl.EditOne(newItem, ref newMsg)) continue;
                MessageBox.Show(newMsg, "Voter Clearance Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            }
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
