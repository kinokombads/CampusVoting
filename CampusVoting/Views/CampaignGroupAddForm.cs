﻿using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.PageHelpers;

namespace CampusVoting.Views
{
    public partial class CampaignGroupAddForm : Form
    {
        public CampaignGroupAddForm()
        {
            InitializeComponent();
        }

        public CampaignGroupAddForm(CampaignGroupBl bl)
        {
            InitializeComponent();
            GetActiveSchoolYear();
            CampaignGroupBl = bl;
            SchoolYearTextEdit.Tag = schoolYearBl.VmParams.Id;
            SchoolYearTextEdit.Text = schoolYearBl.VmParams.Title;
            NameTextEdit.Select();
        }

        public CampaignGroupBl CampaignGroupBl { get; set; }
        private SchoolYearBl schoolYearBl = new SchoolYearBl();
        private const string PageName = "School Year Addition";

        private void GetParams()
        {
            CampaignGroupBl.ResetVmParams();
            CampaignGroupBl.VmParams.Title = NameTextEdit.Text;
            CampaignGroupBl.VmParams.SchoolYearId = schoolYearBl.VmParams.Id;
            CampaignGroupBl.VmParams.Details = DetailMemoEdit.Text;
            CampaignGroupBl.VmParams.CreatedById = LoginDetail.UserId;
        }

        private void Save()
        {
            string msg = "";
            if (CampaignGroupBl.AddOne(CampaignGroupBl.VmParams, ref msg))
            {
                MessageBox.Show(string.Format("Campaign Group {0} has been added.", NameTextEdit.Text), PageName);
                CampaignGroupBl.ChangeOccured = true;
                Close();

            }
            else if (msg != "")
            {
                MessageBox.Show(msg, PageName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clearer()
        {
            NameTextEdit.Text = "";
            DetailMemoEdit.Text = "";
        }

        private void GetActiveSchoolYear()
        {
            if (schoolYearBl.GetActive()) return;
            MessageBox.Show("There is no Active School Year.", "No Active School Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }


        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveSimButton_Click(object sender, EventArgs e)
        {
            GetParams();
            Save();
        }

        private void ClearSimButton_Click(object sender, EventArgs e)
        {
            Clearer();
        }

        private void CampaignGroupAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
