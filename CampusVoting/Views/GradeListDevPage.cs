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

namespace CampusVoting.Views
{
    public partial class GradeListDevPage : DevExpress.XtraEditors.XtraUserControl
    {
        public GradeListDevPage()
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
            gridControl1.RefreshDataSource();
            gridControl1.DataSource = bl.GetList(bl.Parameters, ref msg);            
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
    }
}
