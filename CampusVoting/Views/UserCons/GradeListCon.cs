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
            ChangeOccured = false;
        }

        public bool ChangeOccured { get; set; }

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

            gradeBl.MapToViewModel(item);

            if (process == ProcessMode.Update)
            {
                //load edit form
                GradeEditForm editForm = new GradeEditForm(gradeBl);
                editForm.ShowDialog();

                if (!gradeBl.ChangeOccured) return;
                LoadList();
                gradeBl.ChangeOccured = false;
            }
            else
            {
                //load delete form
            }


        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            GetParams();
            LoadList();
        }

        private void EditRepoButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GetSelected(e.Button.Caption.Equals("Edit") ? ProcessMode.Update : ProcessMode.Delete);
        }

        private void ListGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GetSelected(ProcessMode.Update);
        }


    }
}
