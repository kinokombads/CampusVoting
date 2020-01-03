using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CampusVoting.BusinessLogics;
using CampusVoting.Helpers;
using CampusVoting.PageHelpers;

namespace CampusVoting.Views
{
    public partial class SampleListPage : DevExpress.XtraEditors.XtraUserControl
    {
        public SampleListPage()
        {
            InitializeComponent();
        }

        string msg = "";
        StudentBl bl = new StudentBl();

        private void GetParams()
        {
            bl.ResetParameters();
            bl.Parameters.Lrn = TitleTextEdit.Text;
        }

        private void LoadList()
        {   
            bl.ResetViewModels();
            bl.ViewModels = bl.GetList(bl.Parameters, ref msg);

            if (msg == "")
            {
                ListGridControl.DataSource = bl.ViewModels;
            }
            else
            {
                MessageBox.Show(msg, DialogMessage.RetrieveFail, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchControl1_QueryIsSearchColumn(object sender, QueryIsSearchColumnEventArgs args)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GetParams();
            LoadList();
        }

        private void GradeListDevPage_Load(object sender, EventArgs e)
        {
            GridControlOption.CustomDrawRowIndicator(ListGridControl, ItemsGridView);
            ItemsGridView.OptionsBehavior.AutoPopulateColumns = false;
        }
    }
}
