using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.Helpers;
using CampusVoting.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace CampusVoting.Views
{
    public partial class PositionAddForm : Form
    {
        public PositionAddForm()
        {
            InitializeComponent();
            PositionBl = new PositionBl();
            NameTextEdit.Select();
            LoadCombo();
            TypeLookUp_SizeChanged(TypeLookUp, EventArgs.Empty);
        }

        public PositionAddForm(PositionBl bl)
        {
            InitializeComponent();
            PositionBl = bl;
            NameTextEdit.Select();
            LoadCombo();
            TypeLookUp_SizeChanged(TypeLookUp, EventArgs.Empty);
        }


        public PositionBl PositionBl { get; set; }
        private const string PageName = "Position Addition";
        readonly GradeBl gbl1 = new GradeBl();
        readonly GradeBl gbl2 = new GradeBl();
        readonly CandidateClearanceBl cbl = new CandidateClearanceBl();
        readonly VoterClearanceBl vbl = new VoterClearanceBl();
        
        private int newId;

        private void GetParams()
        {
            PositionBl.ResetVmParams();
            PositionBl.VmParams.Title = NameTextEdit.Text;
            PositionBl.VmParams.PositionType = TypeLookUp.EditValue.GetString();
            PositionBl.VmParams.Details = DetailMemoEdit.EditValue.GetString();
            PositionBl.VmParams.CreatedById = "1"; //todo temp
        }

        private void Save()
        {
            string msg = "";
            if (PositionBl.AddOne(PositionBl.VmParams, ref msg, ref newId))
            {
                MessageBox.Show(string.Format("Position {0} has been added.", NameTextEdit.Text), PageName);
                PositionBl.ChangeOccured = true;
                SaveCands();
                SaveVoters();
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
            TypeLookUp.EditValue = null;
            DetailMemoEdit.EditValue = "";
            CandidateClearanceCheckListBoxCon.UnCheckAll();
            VoterClearanceCheckedListBoxCon.UnCheckAll();
        }

        private void LoadCombo()
        {
            string msgs = "";
            gbl1.ComboItems = gbl1.GetCombo(ref msgs);
            gbl2.ComboItems = gbl2.GetCombo(ref msgs);

            TypeLookUp.Properties.DataSource = PositionBl.PositionTypes; 
            TypeLookUp.Properties.DisplayMember = "Title";
            TypeLookUp.Properties.ValueMember = "Id";

            CandidateClearanceCheckListBoxCon.DataSource = gbl1.ComboItems;
            CandidateClearanceCheckListBoxCon.DisplayMember = "Title";
            CandidateClearanceCheckListBoxCon.ValueMember = "Id";
            
            VoterClearanceCheckedListBoxCon.DataSource = gbl2.ComboItems;
            VoterClearanceCheckedListBoxCon.DisplayMember = "Title";
            VoterClearanceCheckedListBoxCon.ValueMember = "Id";
        }

        private void SaveCands()
        {
            string newMsg = "";
            cbl.ResetVmList();

            List<GradeComboVm> checkCands = CandidateClearanceCheckListBoxCon.CheckedItems.Cast<GradeComboVm>().ToList();
            
            foreach (GradeComboVm grade in gbl1.ComboItems)
            {
                CandidateClearanceVm newItem = new CandidateClearanceVm();
                newItem.PositionId = newId.GetString();
                newItem.GradeId = grade.Id;
                newItem.Active = checkCands.Exists(i => i.Id == grade.Id).GetBool();

                if (cbl.AddOne(newItem, ref newMsg)) continue;
                MessageBox.Show(newMsg, "Candidate Clearance Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            }
            
        }

        private void SaveVoters()
        {
            string newMsg = "";
            vbl.ResetVmList();

            List<GradeComboVm> checkVoters = VoterClearanceCheckedListBoxCon.CheckedItems.Cast<GradeComboVm>().ToList();

            foreach (GradeComboVm grade in gbl2.ComboItems)
            {
                VoterClearanceVm newItem = new VoterClearanceVm();
                newItem.PositionId = newId.GetString();
                newItem.GradeId = grade.Id;
                newItem.Active = checkVoters.Exists(i => i.Id == grade.Id).ToString();

                if (vbl.AddOne(newItem, ref newMsg)) continue;
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

        private void TypeLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (TypeLookUp.Properties.View.Columns["Id"].Visible)
            {
                TypeLookUp.Properties.View.Columns["Id"].Visible = false;
            }
        }

        private void PositionAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void TypeLookUp_SizeChanged(object sender, EventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            RepositoryItemGridLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width, properties.PopupFormSize.Height);
        }

        
        
    }
}
