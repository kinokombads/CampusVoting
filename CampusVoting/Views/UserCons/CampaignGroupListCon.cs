using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.EnumsAndDictionaries;
using CampusVoting.Helpers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace CampusVoting.Views.UserCons
{
    public partial class CampaignGroupListCon : UserControl
    {
        public CampaignGroupListCon()
        {
            InitializeComponent();
            NameTextEdit.Select();
            LoadList();
        }

        private string msg = "";
        CampaignGroupBl campaignGroupBl = new CampaignGroupBl();
        SchoolYearBl schoolYearBl = new SchoolYearBl();


        public void GetParams()
        {
            campaignGroupBl.ResetVmParams();
            campaignGroupBl.VmParams.Title = NameTextEdit.Text;
        }

        public void LoadList()
        {
            campaignGroupBl.ListVm = campaignGroupBl.GetList(campaignGroupBl.VmParams, ref msg);
            if (msg == "")
            {
                ListGridControl.DataSource = campaignGroupBl.ListVm;
                NoteLabel.Text = "Result: " + campaignGroupBl.ListVm.Count;
            }
            else
            {
                MessageBox.Show(msg, DialogMessage.RetrieveFail, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
        {
            if (!ItemsGridView.IsFocusedView)
            {return false;
            }

            switch (keyData)
            {
                case Keys.Delete:
                    GetSelected(ProcessMode.Delete);
                    break;
                case Keys.Enter:
                    GetSelected(ProcessMode.Update); break;
            }

            return base.ProcessCmdKey(ref message, keyData);
        }

        private void GetSelected(ProcessMode process)
        {
            if (!GetActiveSchoolYear()) return;
            GridView gridView = ListGridControl.FocusedView as GridView;

            if (gridView == null) return;

            object item = gridView.GetRow(gridView.FocusedRowHandle);

            campaignGroupBl.MapToViewModel(item);

            if (process == ProcessMode.Update)
            {
                CampaignGroupEditForm editForm = new CampaignGroupEditForm(campaignGroupBl);
                editForm.ShowDialog();
                RefreshWhenChanged();
            }
            else if (process == ProcessMode.Delete)
            {
                CampaignGroupDeleteForm deleteForm = new CampaignGroupDeleteForm(campaignGroupBl);
                deleteForm.ShowDialog();
                campaignGroupBl.ResetVmParams();
                RefreshWhenChanged();
            }

            //todo create roster management con
            //todo close this
            //todo show roster management con
            
        }

        private void RefreshWhenChanged()
        {
            if (!campaignGroupBl.ChangeOccured) return;
            LoadList();
            campaignGroupBl.ChangeOccured = false;
        }

        private bool GetActiveSchoolYear()
        {
            if (schoolYearBl.GetActive()) return true;
            MessageBox.Show("There is no Active School Year.\nPlease set an active School Year in the School Years tab.", 
                "No Active School Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            GetParams();
            LoadList();
        }

        private void AddSimButton_Click(object sender, EventArgs e)
        {
            if (!GetActiveSchoolYear()) return;
            CampaignGroupAddForm addForm = new CampaignGroupAddForm(campaignGroupBl);
            addForm.ShowDialog();
            RefreshWhenChanged();
        }

        private void EditRepoButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Caption)
            {
                case "Edit":
                    GetSelected(ProcessMode.Update);
                    break;
                case "Delete":
                    GetSelected(ProcessMode.Delete);break;
                case "Roster Management":
                    GetSelected(ProcessMode.RosterManagement);
                    break;
            }
        }

        private void ListGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GetSelected(ProcessMode.Update);
        }

        private void CampaignGroupListCon_VisibleChanged(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13 || ItemsGridView.IsFocusedView) return;
            GetParams();
            LoadList();
        }


    }
}
