using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.ViewModels;
using CampusVoting.Views.UserCons;
using DevExpress.XtraEditors;
using Vota.Helpers;

namespace CampusVoting.Views
{
    public partial class GradeEditXtraForm : XtraForm
    {
        public GradeEditXtraForm()
        {
            InitializeComponent();

            bl.VmParams.Id = 2.GetString();
            bl.VmItem = bl.GetOne(bl.VmParams, ref msg);

            //List User Control
            //MainCon = listCon;
            /*
            //Page Label
            pageLabel = PageNameLabel.Text;
            DisplayData();
             */
        }

        public GradeEditXtraForm(GradeListXtraCon listCon, GradeVm item)
        {
            InitializeComponent();
            /*
            //Item to be edited
            bl.VmItem = item;

            //List User Control
            MainCon = listCon;
            
            //Page Label
            pageLabel = PageNameLabel.Text;
            
            DisplayData();
             */
        }
        
        private GradeBl bl = new GradeBl();
        private string pageLabel;
        private string msg = "";

        public GradeListXtraCon MainCon { get; set; }

        /*
        //Display the item to be edited
        private void DisplayData()
        {
            
            //id of the item to be edited
            PageNameLabel.Tag = bl.VmItem.Id.GetString();

            //title of item to be edited
            NameTextEdit.Tag = bl.VmItem.Title;
            
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
            bl.Params.Id = PageNameLabel.Tag.GetInt();
            bl.Params.Title = NameTextEdit.Text;
            bl.Params.Details = DetailsMemoEdit.Text;
            bl.Params.ModifiedById = 1; //todo temp
             
        }

        private void Save()
        {
            string msg = "";
            if (bl.EditOne(bl.Params, ref msg))
            {
                MessageBox.Show(string.Format("Grade {0} is updated to Grade {1}",
                    NameTextEdit.Tag, NameTextEdit.Text), pageLabel);
                MainCon.GetParams();
                MainCon.LoadList();
                Close();
            }
            else if (msg != "")
            {
                MessageBox.Show(msg, pageLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clearer()
        {
            NameTextEdit.Text = "";
            DetailsMemoEdit.Text = "";
        }
        */

        private void SaveButton_Click(object sender, EventArgs e)
        {
            /*
            GetParams();
            Save();
             */
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            /*
            Clearer();
             */
        }

        private void GradeEditXtraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}