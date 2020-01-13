using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.Enums;
using CampusVoting.Helpers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace CampusVoting.Views.UserCons
{
    public partial class GradeListCon : UserControl
    {
        public GradeListCon()
        {
            InitializeComponent();
            NameTextEdit.Select();
        }
        
        private string msg = "";
        GradeBl gradeBl = new GradeBl();


        public void GetParams()
        {
            gradeBl.ResetVmParams();
            gradeBl.VmParams.Title = NameTextEdit.Text;
        }

        public void LoadList()
        {
            gradeBl.ListVm = gradeBl.GetList(gradeBl.VmParams, ref msg);
            if (msg == "")
            {
                ListGridControl.DataSource = gradeBl.ListVm;
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

            switch (keyData){
                case Keys.Delete:
                    GetSelected(ProcessMode.Delete);
                    break;
                case Keys.Enter:
                    GetSelected(ProcessMode.Update);
                    break;
            }

            return base.ProcessCmdKey(ref message, keyData);
        }

        private void GetSelected(ProcessMode process)
        {
            GridView gridView = ListGridControl.FocusedView as GridView;

            if (gridView == null) return;

            object item = gridView.GetRow(gridView.FocusedRowHandle);

            gradeBl.MapToViewModel(item);

            if (process == ProcessMode.Update)
            {
                GradeEditForm editForm = new GradeEditForm(gradeBl);
                editForm.ShowDialog();
                RefreshWhenChanged();
            }
            else
            {
                GradeDeleteForm deleteForm = new GradeDeleteForm(gradeBl);
                deleteForm.ShowDialog();
                RefreshWhenChanged();
            }

        }

        private void RefreshWhenChanged()
        {
            if (!gradeBl.ChangeOccured) return;
            LoadList();
            gradeBl.ChangeOccured = false;
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            GetParams();
            LoadList();
        }

        private void AddSimButton_Click(object sender, EventArgs e)
        {
            GradeAddForm addForm = new GradeAddForm(gradeBl);
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

        private void GradeListCon_VisibleChanged(object sender, EventArgs e)
        {
            Dispose();
        }

        private void NameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13 || ItemsGridView.IsFocusedView) return;
            GetParams();
            LoadList();
        }


    }
}
