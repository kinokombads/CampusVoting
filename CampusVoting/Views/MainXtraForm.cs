using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace CampusVoting.Views
{
    public partial class MainXtraForm : XtraForm
    {
        public MainXtraForm()
        {
            InitializeComponent();
        }

        private void NavigationElement_Click(object sender, EventArgs e)
        {
            AccordionControlElement navPressed = (AccordionControlElement)sender;

            switch (navPressed.Text)
            {
                case "Voting Session":
                    break;
                case "School Years":
                    break;
                case "Students":
                    break;
                case "Candidates":
                    break;
                default:
                    break;
            }



        }
    }
}