using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.Enums;
using CampusVoting.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace CampusVoting.Views.UserCons
{
    public partial class GradeListXtraCon : XtraUserControl
    {
        public GradeListXtraCon()
        {
            InitializeComponent();
        }

        private string msg = "";
        GradeBl bl = new GradeBl();

        private void GetParams()
        {
            bl.ResetVmParams();
            bl.Params.Title = NameTextEdit.Text;
        }

        private void LoadList()
        {
            bl.ListVm = bl.GetList(bl.VmParams, ref msg);
            if (msg == "")
            {
                ListGridControl.DataSource = bl.ListVm;
            }
            else
            {
                MessageBox.Show(msg, DialogMessage.RetrieveFail, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetSelected(ProcessMode process)
        {
            GridView gridView = ListGridControl.FocusedView as GridView;

            if (gridView == null) return;

            var item = gridView.GetRow(gridView.FocusedRowHandle);

            bl.MapToViewModel(item);

            string sdfsda = "";
        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            GetParams();
            LoadList();
        }

        private void EditRepoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void EditRepoButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var koko = e.Button.Caption;
            //var meme = (ButtonEdit)sender;
            //string msg = "";
            //MessageBox.Show(koko);

            GetSelected(ProcessMode.Update);
        }


    }
}