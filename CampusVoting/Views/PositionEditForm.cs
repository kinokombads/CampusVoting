using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.Helpers;
using CampusVoting.Models;
using CampusVoting.PageHelpers;
using CampusVoting.ViewModels;
using DevExpress.XtraGrid.Views.Layout.Drawing;

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
        GradeBl gbl1 = new GradeBl();
        GradeBl gbl2 = new GradeBl();

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
            PositionBl.VmParams.ModifiedById = LoginDetail.UserId;
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
            
            gbl1.ComboItems = gbl1.GetCombo(ref msgs);
            //attempt to add all 
            //will fail if dupplicate
            foreach (var item in gbl1.ComboItems)
            {
                CandidateClearanceVm obj = new CandidateClearanceVm();
                obj.GradeId = item.Id;
                obj.PositionId = id;

                cbl.AddOne(obj, ref msgs);
            }

            //retieve the candidate clearances
            msgs = "";
            cbl.VmParams.PositionId = id;
            cbl.ListVm = cbl.GetList(cbl.VmParams, ref msgs);
            
            //make the candidate clearances as the datasource
            CandidateClearanceCheckListBoxCon.DataSource = cbl.ListVm;
            CandidateClearanceCheckListBoxCon.DisplayMember = "Grade";
            CandidateClearanceCheckListBoxCon.ValueMember = "Id";


            //set each items checked if active
            for (int i = 0; i < cbl.ListVm.Count; i++)
            {
                CandidateClearanceCheckListBoxCon.SetItemChecked(i, cbl.ListVm[i].Active);
            }



            gbl2.ComboItems = gbl2.GetCombo(ref msgs);
            //attempt to add all 
            //will fail if dupplicate
            foreach (var item in gbl2.ComboItems)
            {
                VoterClearanceVm obj = new VoterClearanceVm();
                obj.GradeId = item.Id;
                obj.PositionId = id;

                vbl.AddOne(obj, ref msgs);
            }

            //retieve the voter clearances
            msgs = "";
            vbl.VmParams.PositionId = id;
            vbl.ListVm = vbl.GetList(vbl.VmParams, ref msgs);

            //make the voter clearances as the datasource
            VoterClearanceCheckedListBoxCon.DataSource = vbl.ListVm;
            VoterClearanceCheckedListBoxCon.DisplayMember = "Grade";
            VoterClearanceCheckedListBoxCon.ValueMember = "Id";

            //set each items checked if active
            for (int i = 0; i < vbl.ListVm.Count; i++)
            {
                VoterClearanceCheckedListBoxCon.SetItemChecked(i, vbl.ListVm[i].Active);
            }
        }

        private void SaveCands()
        {
            string msgs = "";

            //get all checked items
            List<CandidateClearanceVm> checkedCands = CandidateClearanceCheckListBoxCon.CheckedItems.Cast<CandidateClearanceVm>().ToList();
            
            foreach (CandidateClearanceVm item in (IEnumerable)CandidateClearanceCheckListBoxCon.DataSource)
            {
                //if the element exists in checkedCands, set the [item].active to true
                item.Active = checkedCands.Exists(x => x.GradeId == item.GradeId && x.PositionId == item.PositionId);
                cbl.EditOne(item, ref msgs);
            }

        }

        private void SaveVoters()
        {
            string msgs = "";

            //get all checked items
            List<VoterClearanceVm> checkVoters = VoterClearanceCheckedListBoxCon.CheckedItems.Cast<VoterClearanceVm>().ToList();

            foreach (VoterClearanceVm item in (IEnumerable)VoterClearanceCheckedListBoxCon.DataSource)
            {
                //if the element exists in checkVoters, set the [item].active to true
                item.Active = checkVoters.Exists(x => x.GradeId == item.GradeId && x.PositionId == item.PositionId);
                vbl.EditOne(item, ref msgs);
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
