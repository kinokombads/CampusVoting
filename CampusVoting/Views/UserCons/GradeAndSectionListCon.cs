﻿using System;
using System.Linq;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.EnumsAndDictionaries;
using CampusVoting.Helpers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace CampusVoting.Views.UserCons
{
    public partial class GradeAndSectionListCon : UserControl
    {
        public GradeAndSectionListCon()
        {
            InitializeComponent();
            LoadCombo();
            //GetParams();
            LoadList();
        }

        private string msg = "";
        GradeAndSectionBl gradeAndSectionBl = new GradeAndSectionBl();
        GradeBl gradeBl = new GradeBl();
        SectionBl sectionBl = new SectionBl();

        private void ListGridControl_Layout(object sender, LayoutEventArgs e)
        {
            GridControl control = sender as GridControl;
            
            FindControl findControl = control.Controls.OfType<FindControl>().FirstOrDefault();
            if (findControl == null) return;
            findControl.FindButton.Click -= FindButton_Click;
            //findControl.ClearButton.Click -= ClearButton_Click;
            findControl.FindButton.Click += FindButton_Click;
            //findControl.ClearButton.Click += ClearButton_Click;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadCombo()
        {
            string msgs = "";
            gradeBl.ComboItems = gradeBl.GetCombo(ref msgs);
            GradeEdit.Properties.DataSource = gradeBl.ComboItems;
            GradeEdit.Properties.DisplayMember = "Title";
            GradeEdit.Properties.ValueMember = "Title";

            if (msg != "")
            {
                MessageBox.Show(msg, "Grade Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sectionBl.ComboItems = sectionBl.GetCombo(ref msgs);
            SectionEdit.Properties.DataSource = sectionBl.ComboItems;
            SectionEdit.Properties.DisplayMember = "Title";
            SectionEdit.Properties.ValueMember = "Title";

            if (msg != "")
            {
                MessageBox.Show(msg, "Section Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetParams()
        {
            gradeAndSectionBl.ResetVmParams();
            gradeAndSectionBl.VmParams.Title = NameTextEdit.Text;
            gradeAndSectionBl.VmParams.Grade = GradeEdit.EditValue.GetString();
            gradeAndSectionBl.VmParams.Section = SectionEdit.EditValue.GetString();
        }

        public void LoadList()
        {
            gradeAndSectionBl.ListVm = gradeAndSectionBl.GetList(gradeAndSectionBl.VmParams, ref msg);
            if (msg == "")
            {
                ListGridControl.DataSource = gradeAndSectionBl.ListVm;
                NoteLabel.Text = "Result: " + gradeAndSectionBl.ListVm.Count;
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

            gradeAndSectionBl.MapToViewModel(item);

            if (process == ProcessMode.Update)
            {
                GradeAndSectionEditForm editForm = new GradeAndSectionEditForm(gradeAndSectionBl);
                editForm.ShowDialog();
                RefreshWhenChanged();
            }
            else
            {
                GradeAndSectionDeleteForm deleteForm = new GradeAndSectionDeleteForm(gradeAndSectionBl);
                deleteForm.ShowDialog();
                gradeAndSectionBl.ResetVmParams();
                RefreshWhenChanged();
            }

        }

        private void RefreshWhenChanged()
        {
            if (!gradeAndSectionBl.ChangeOccured) return;
            LoadList();
            gradeAndSectionBl.ChangeOccured = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            GetParams();
            LoadList();
        }

        private void AddSimButton_Click(object sender, EventArgs e)
        {
            GradeAndSectionAddForm addForm = new GradeAndSectionAddForm(gradeAndSectionBl);
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

        private void GradeAndSectionListCon_VisibleChanged(object sender, EventArgs e)
        {
            Dispose();
        }

        private void NameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13 || ItemsGridView.IsFocusedView) return;
            GetParams();
            LoadList();
        }

        private void GradeEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (GradeEdit.Properties.View.Columns["Id"].Visible)
            {
                GradeEdit.Properties.View.Columns["Id"].Visible = false;
            }
        }

        private void SectionEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (SectionEdit.Properties.View.Columns["Id"].Visible)
            {
                SectionEdit.Properties.View.Columns["Id"].Visible = false;
            }
        }
    }
}
