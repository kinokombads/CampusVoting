using System;
using System.ComponentModel;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.EnumsAndDictionaries;
using CampusVoting.Helpers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace CampusVoting.Views.UserCons
{
    public partial class PositionListCon : UserControl
    {
        public PositionListCon()
        {
            InitializeComponent();
            NameTextEdit.Select();
            LoadCombo();
        }


        private string msg = "";
        PositionBl positionBl = new PositionBl();



        public void GetParams()
        {
            positionBl.ResetVmParams();
            positionBl.VmParams.Title = NameTextEdit.Text;
        }

        public void LoadList()
        {
            msg = "";
            positionBl.ListVm = positionBl.GetList(positionBl.VmParams, ref msg);
            if (msg == "")
            {
                ListGridControl.DataSource = positionBl.ListVm;
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

            positionBl.MapToViewModel(item);

            if (process == ProcessMode.Update)
            {
                if (positionBl.VmParams.PositionType == "Regular")
                {
                    PositionEditForm form = new PositionEditForm(positionBl);
                    form.ShowDialog();
                    RefreshWhenChanged();
                }
                else
                {
                    
                }
                
            }
            else
            {
                //PositionDeleteForm deleteForm = new PositionDeleteForm(positionBl);
                //deleteForm.ShowDialog();
                positionBl.ResetVmParams();
                //RefreshWhenChanged();
            }

        }

        private void RefreshWhenChanged()
        {
            if (!positionBl.ChangeOccured) return;
            LoadList();
            positionBl.ChangeOccured = false;
        }

        private void LoadCombo()
        {
            msg = "";
            TypeEdit.Properties.DataSource = positionBl.PositionTypes;
            TypeEdit.Properties.DisplayMember = "Title";
            TypeEdit.Properties.ValueMember = "Title";

            if (msg != "")
            {
                MessageBox.Show(msg, "Position Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            GetParams();
            LoadList();
        }

        private void AddSimButton_Click(object sender, EventArgs e)
        {
            PositionAddForm addForm = new PositionAddForm(positionBl);
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

        private void PositionListCon_VisibleChanged(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void NameTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13 || ItemsGridView.IsFocusedView) return;
            GetParams();
            LoadList();
        }

        private void TypeEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (TypeEdit.Properties.View.Columns["Id"].Visible)
            {
                TypeEdit.Properties.View.Columns["Id"].Visible = false;
            }
        }
    }
}
