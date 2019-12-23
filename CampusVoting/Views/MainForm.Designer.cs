namespace CampusVoting.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BannerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.MainNavAccordion = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.SessionHeader = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.VotingSessionsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SchoolYearsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.StudentsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CandidatesElements = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PositionsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CampaignGroupsElements = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.GradesElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.BannerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainNavAccordion)).BeginInit();
            this.SuspendLayout();
            // 
            // BannerPanel
            // 
            this.BannerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BannerPanel.ColumnCount = 3;
            this.BannerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.BannerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.BannerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BannerPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.BannerPanel.Controls.Add(this.label1, 1, 0);
            this.BannerPanel.Controls.Add(this.linkLabel1, 2, 0);
            this.BannerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BannerPanel.Location = new System.Drawing.Point(0, 0);
            this.BannerPanel.Name = "BannerPanel";
            this.BannerPanel.RowCount = 2;
            this.BannerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BannerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BannerPanel.Size = new System.Drawing.Size(1008, 70);
            this.BannerPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CampusVoting.Properties.Resources.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.BannerPanel.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(145, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ravie", 22F);
            this.label1.Location = new System.Drawing.Point(154, 0);
            this.label1.Name = "label1";
            this.BannerPanel.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(649, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voice Of The Asistians";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(809, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.BannerPanel.SetRowSpan(this.linkLabel1, 2);
            this.linkLabel1.Size = new System.Drawing.Size(196, 70);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Welcome, Admin User ";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SidePanel
            // 
            this.SidePanel.Controls.Add(this.MainNavAccordion);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 70);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(160, 592);
            this.SidePanel.TabIndex = 1;
            this.SidePanel.MouseHover += new System.EventHandler(this.SidePanel_MouseHover);
            // 
            // MainNavAccordion
            // 
            this.MainNavAccordion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainNavAccordion.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.SessionHeader,
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3});
            this.MainNavAccordion.Location = new System.Drawing.Point(0, 0);
            this.MainNavAccordion.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.MainNavAccordion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MainNavAccordion.Name = "MainNavAccordion";
            this.MainNavAccordion.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.MainNavAccordion.Size = new System.Drawing.Size(160, 592);
            this.MainNavAccordion.TabIndex = 1;
            this.MainNavAccordion.Text = "accordionControl1";
            // 
            // SessionHeader
            // 
            this.SessionHeader.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.VotingSessionsElement,
            this.SchoolYearsElement});
            this.SessionHeader.Expanded = true;
            this.SessionHeader.Name = "SessionHeader";
            this.SessionHeader.Text = "Session";
            // 
            // VotingSessionsElement
            // 
            this.VotingSessionsElement.Name = "VotingSessionsElement";
            this.VotingSessionsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.VotingSessionsElement.Text = "Voting Session";
            // 
            // SchoolYearsElement
            // 
            this.SchoolYearsElement.Name = "SchoolYearsElement";
            this.SchoolYearsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SchoolYearsElement.Text = "School Years";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.StudentsElement,
            this.CandidatesElements});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Participants";
            // 
            // StudentsElement
            // 
            this.StudentsElement.Name = "StudentsElement";
            this.StudentsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.StudentsElement.Text = "Students";
            // 
            // CandidatesElements
            // 
            this.CandidatesElements.Name = "CandidatesElements";
            this.CandidatesElements.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.CandidatesElements.Text = "Candidates";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.PositionsElement,
            this.CampaignGroupsElements,
            this.GradesElement,
            this.accordionControlElement9,
            this.accordionControlElement10});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Others";
            // 
            // PositionsElement
            // 
            this.PositionsElement.Name = "PositionsElement";
            this.PositionsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.PositionsElement.Text = "Positions";
            // 
            // CampaignGroupsElements
            // 
            this.CampaignGroupsElements.Name = "CampaignGroupsElements";
            this.CampaignGroupsElements.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.CampaignGroupsElements.Text = "Campaign Groups";
            // 
            // GradesElement
            // 
            this.GradesElement.Name = "GradesElement";
            this.GradesElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.GradesElement.Text = "Grades";
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement9.Text = "Sections";
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Grade And Sections";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Reports";
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(160, 70);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(848, 592);
            this.MainContentPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.BannerPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.BannerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainNavAccordion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BannerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel SidePanel;
        private DevExpress.XtraBars.Navigation.AccordionControl MainNavAccordion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SessionHeader;
        private DevExpress.XtraBars.Navigation.AccordionControlElement VotingSessionsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SchoolYearsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement StudentsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement CandidatesElements;
        private DevExpress.XtraBars.Navigation.AccordionControlElement PositionsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement CampaignGroupsElements;
        private DevExpress.XtraBars.Navigation.AccordionControlElement GradesElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private System.Windows.Forms.Panel MainContentPanel;

    }
}