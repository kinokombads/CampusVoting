using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;

namespace CampusVoting.Views
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public GradeAndSectionBl bl = new GradeAndSectionBl();

        
        private void LoadList()
        {
            string msg = "";
            bl.ResetVmParams();
            bl.ResetVmList();

            bl.ListVm = bl.GetList(bl.VmParams, ref msg);
            this.dataGridView1.DataSource = bl.ListVm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
