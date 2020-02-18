using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.EnumsAndDictionaries;
using CampusVoting.Helpers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace CampusVoting.Views.UserCons
{
    public partial class StudentListCon : UserControl
    {
        public StudentListCon()
        {
            InitializeComponent();
            NameTextEdit.Select();
            LoadList();
        }

        private string msg = "";
        StudentBl studentBl = new StudentBl();


        public void GetParams()
        {
            //studentBl.ResetVmParams();
            //studentBl.VmParams.Title = NameTextEdit.Text;
        }

        public void LoadList()
        {
            //studentBl.ListVm = studentBl.GetList(studentBl.VmParams, ref msg);
            //if (msg == "")
            //{
            //    ListGridControl.DataSource = studentBl.ListVm;
            //    NoteLabel.Text = "Result: " + studentBl.ListVm.Count;
            //}
            //else
            //{
            //    MessageBox.Show(msg, DialogMessage.RetrieveFail, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
            //GridView gridView = ListGridControl.FocusedView as GridView;

            //if (gridView == null) return;

            //object item = gridView.GetRow(gridView.FocusedRowHandle);

            //studentBl.MapToViewModel(item);

            //if (process == ProcessMode.Update)
            //{
            //    StudentEditForm editForm = new StudentEditForm(studentBl);
            //    editForm.ShowDialog();
            //    RefreshWhenChanged();
            //}
            //else
            //{
            //    StudentDeleteForm deleteForm = new StudentDeleteForm(studentBl);
            //    deleteForm.ShowDialog();
            //    studentBl.ResetVmParams();
            //    RefreshWhenChanged();
            //}

        }

        private void RefreshWhenChanged()
        {
            //if (!studentBl.ChangeOccured) return;
            //LoadList();
            //studentBl.ChangeOccured = false;
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            GetParams();
            LoadList();
        }

        private void AddSimButton_Click(object sender, EventArgs e)
        {
            //StudentAddForm addForm = new StudentAddForm(studentBl);
            //addForm.ShowDialog();
            //RefreshWhenChanged();
        }

        private void EditRepoButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GetSelected(e.Button.Caption.Equals("Edit") ? ProcessMode.Update : ProcessMode.Delete);
        }

        private void ListGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GetSelected(ProcessMode.Update);
        }

        private void StudentListCon_VisibleChanged(object sender, EventArgs e)
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
