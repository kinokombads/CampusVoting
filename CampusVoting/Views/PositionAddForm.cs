using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.Helpers;
using CampusVoting.Models;
using CampusVoting.ViewModels;
using DevExpress.Data.Helpers;
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
        GradeBl bl1 = new GradeBl();
        GradeBl bl2 = new GradeBl();

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
            if (PositionBl.AddOne(PositionBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Position {0} has been added.", NameTextEdit.Text), PageName);
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
            TypeLookUp.EditValue = null;
            DetailMemoEdit.EditValue = "";
        }

        private void LoadCombo()
        {
            TypeLookUp.Properties.DataSource = PositionBl.PositionTypes; 
            TypeLookUp.Properties.DisplayMember = "Title";
            TypeLookUp.Properties.ValueMember = "Id";
            
            string msgs = "";
            

            CandidateClearanceCheckedListBoxCon.DataSource = bl1.GetCombo(ref msgs);
            CandidateClearanceCheckedListBoxCon.DisplayMember = "Title";
            CandidateClearanceCheckedListBoxCon.ValueMember = "Id";

            VoterClearanceCheckedListBoxCon.DataSource = bl2.GetCombo(ref msgs);
            VoterClearanceCheckedListBoxCon.DisplayMember = "Title";
            VoterClearanceCheckedListBoxCon.ValueMember = "Id";
        }

        private void SaveClearances()
        {
            //foreach (var grade in bl1.ComboItems)
            //{
            //    foreach (GradeComboVm item in CandidateClearanceCheckedListBoxCon.CheckedItems)
            //    {
            //        if (VScroll)
            //        {
                        
            //        }
            //    }
            //}
            
        }

        
        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveSimButton_Click(object sender, EventArgs e)
        {
            //GetParams();
            //Save();
            SaveClearances();
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
