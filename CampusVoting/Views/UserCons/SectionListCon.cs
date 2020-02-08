using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.EnumsAndDictionaries;
using CampusVoting.Helpers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace CampusVoting.Views.UserCons
{
    public partial class SectionListCon : UserControl
    {
        public SectionListCon()
        {
            InitializeComponent();
            NameTextEdit.Select();
        }

        private string msg = "";
        SectionBl sectionBl = new SectionBl();


        public void GetParams()
        {
            sectionBl.ResetVmParams();
            sectionBl.VmParams.Title = NameTextEdit.Text;
        }

        public void LoadList()
        {
            sectionBl.ListVm = sectionBl.GetList(sectionBl.VmParams, ref msg);
            if (msg == "")
            {
                ListGridControl.DataSource = sectionBl.ListVm;
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

            sectionBl.MapToViewModel(item);

            if (process == ProcessMode.Update)
            {
                SectionEditForm editForm = new SectionEditForm(sectionBl);
                editForm.ShowDialog();
                RefreshWhenChanged();
            }
            else
            {
                SectionDeleteForm deleteForm = new SectionDeleteForm(sectionBl);
                deleteForm.ShowDialog();
                sectionBl.ResetVmParams();
                RefreshWhenChanged();
            }

        }

        private void RefreshWhenChanged()
        {
            if (!sectionBl.ChangeOccured) return;
            LoadList();
            sectionBl.ChangeOccured = false;
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            GetParams();
            LoadList();
        }

        private void AddSimButton_Click(object sender, EventArgs e)
        {
            SectionAddForm addForm = new SectionAddForm(sectionBl);
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

        private void SectionListCon_VisibleChanged(object sender, EventArgs e)
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
