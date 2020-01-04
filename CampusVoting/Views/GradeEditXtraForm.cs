using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.ViewModels;
using CampusVoting.Views.UserCons;
using DevExpress.XtraEditors;
using Vota.Helpers;

namespace CampusVoting.Views
{
    public partial class GradeEditXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public GradeEditXtraForm()
        {
            InitializeComponent();
        }

        public GradeEditXtraForm(GradeListXtraCon listCon, GradeVm item)
        {
            InitializeComponent();
            MainCon = listCon;
            NameTextEdit.Tag = item.Id.GetString();
            pageLabel = PageNameLabel.Text;
            bl.VmItem = item;
            DisplayData();
        }
        
        private GradeBl bl = new GradeBl();
        private string pageLabel = "";

        public GradeListXtraCon MainCon { get; set; }


        private void DisplayData()
        {
            NameTextEdit.Tag = bl.VmItem.Id.GetString();
            NameTextEdit.Text = bl.VmItem.Title;
            DetailsMemoEdit.Text = bl.VmItem.Details;
            CreatedByLabel.Text = bl.VmItem.CreatedBy;
            CreatedOnLabel.Text = bl.VmItem.CreatedOn;
            ModifiedByLabel.Text = bl.VmItem.ModifiedBy;
            ModifiedOnLabel.Text = bl.VmItem.ModifiedOn;
        }

        private void GetParams()
        {
            bl.ResetParams();
            bl.Params.Id = NameTextEdit.Tag.GetInt();
            bl.Params.Title = NameTextEdit.Text;
            bl.Params.Details = DetailsMemoEdit.Text;
            bl.Params.ModifiedById = 1; //todo temp
        }

        private void Save()
        {
            string msg = "";
            if (bl.EditOne(bl.Params, ref msg))
            {
                MessageBox.Show("Updated", pageLabel);
                MainCon.GetParams();
                MainCon.LoadList();
            }
            else if (msg != "")
            {
                MessageBox.Show(msg, pageLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}