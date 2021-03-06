﻿using System;
using System.Windows.Forms;
using CampusVoting.BusinessLogics;
using CampusVoting.Helpers;
using CampusVoting.ViewModels;
using CampusVoting.Views.UserCons;

namespace CampusVoting.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(GradeVm item)
        {
            InitializeComponent();
            
            IdLabel.Text = item.Id.GetString();
            pageLabel = PageLabel.Text;
            GetParams();
            DisplayData();
        }

        
        GradeBl bl = new GradeBl();
        private readonly string pageLabel = "";

        private void GetParams()
        {
            //bl.ResetParams();
            //bl.Params.Id = IdLabel.Text.GetInt();
            //bl.Params.Title = TitleTextBox.Text;
            //bl.Params.Details = DetailsTextBox.Text;
            //bl.Params.ModifiedById = 1;
        }

        private void Save()
        {
            //string msg = "";
            //if (bl.EditOne(bl.Params, ref msg))
            //{
            //    MessageBox.Show("Updated", pageLabel);
            //    MainCon.GetParams();
            //    MainCon.LoadList();
            //}
            //else if (msg != "")
            //{
            //    MessageBox.Show(msg, pageLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void DisplayData()
        {
            //IdLabel.Text = bl.Item.Id.GetString();
            //TitleTextBox.Text = bl.Item.Title;
            //DetailsTextBox.Text = bl.Item.Details;
        }
        private void Exiter()
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            GetParams();
            Save();
            Exiter();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void GradeEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        
    }
}
