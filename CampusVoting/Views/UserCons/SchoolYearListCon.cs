using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.EnumsAndDictionaries;
using CampusVoting.Helpers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace CampusVoting.Views.UserCons
{
    public partial class SchoolYearListCon : UserControl
    {
        public SchoolYearListCon()
        {
            InitializeComponent(); NameTextEdit.Select();
        }

        private string msg = "";
        SchoolYearBl schoolYearBl = new SchoolYearBl();


        public void GetParams()
        {
            schoolYearBl.ResetVmParams();
            schoolYearBl.VmParams.Title = NameTextEdit.Text;
        }

        public void LoadList()
        {
            schoolYearBl.ListVm = schoolYearBl.GetList(schoolYearBl.VmParams, ref msg);
            if (msg == "")
            {
                ListGridControl.DataSource = schoolYearBl.ListVm;
            }
            else
            {
                MessageBox.Show(msg, DialogMessage.RetrieveFail, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
        {
            if (!ItemsGridView.IsFocusedView)
            {
                return false;
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
            GridView gridView = ListGridControl.FocusedView as GridView;

            if (gridView == null) return;

            object item = gridView.GetRow(gridView.FocusedRowHandle);

            schoolYearBl.MapToViewModel(item);

            if (process == ProcessMode.Update)
            {
                SchoolYearEditForm editForm = new SchoolYearEditForm(schoolYearBl);
                editForm.ShowDialog();
                RefreshWhenChanged();
            }
            else
            {
                SchoolYearDeleteForm deleteForm = new SchoolYearDeleteForm(schoolYearBl);
                deleteForm.ShowDialog();
                schoolYearBl.ResetVmParams();
                RefreshWhenChanged();
            }

        }

        private void RefreshWhenChanged()
        {
            if (!schoolYearBl.ChangeOccured) return;
            LoadList();
            schoolYearBl.ChangeOccured = false;
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            GetParams();
            LoadList();
        }

        private void AddSimButton_Click(object sender, EventArgs e)
        {
            SchoolYearAddForm addForm = new SchoolYearAddForm(schoolYearBl);
            addForm.ShowDialog();
            RefreshWhenChanged();
        }

        private void EditRepoButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GetSelected(e.Button.Caption.Equals("Edit") ? ProcessMode.Update : ProcessMode.Delete);
        }

        private void ListGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GetSelected(ProcessMode.Update);
        }
        
        
        private void NameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13 || ItemsGridView.IsFocusedView) return;
            GetParams();
            LoadList();
        }
    }
}
