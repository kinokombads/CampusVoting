namespace CampusVoting.Views
{
    partial class MainXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainXtraForm));
            this.HeaderPanel = new DevExpress.XtraEditors.PanelControl();
            this.BannerTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.LogoutLink = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoggedLink = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.MainNavAccordion = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.SessionHeader = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.VotingSessionsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SchoolYearsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ParticipantHeader = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.StudentsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CandidatesElements = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.OthersHeader = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.PositionsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.CampaignGroupsElements = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.GradesElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.SectionsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.GradeAndSectionsElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ReportsHeader = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ContentXtraPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPanel)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.BannerTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainNavAccordion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentXtraPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.HeaderPanel.Controls.Add(this.BannerTablePanel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.LookAndFeel.SkinName = "Office 2016 Dark";
            this.HeaderPanel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1008, 70);
            this.HeaderPanel.TabIndex = 0;
            // 
            // BannerTablePanel
            // 
            this.BannerTablePanel.ColumnCount = 3;
            this.BannerTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.BannerTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.BannerTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BannerTablePanel.Controls.Add(this.LogoutLink, 2, 1);
            this.BannerTablePanel.Controls.Add(this.LogoPictureBox, 0, 0);
            this.BannerTablePanel.Controls.Add(this.TitleLabel, 1, 0);
            this.BannerTablePanel.Controls.Add(this.LoggedLink, 2, 0);
            this.BannerTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BannerTablePanel.Location = new System.Drawing.Point(2, 2);
            this.BannerTablePanel.Name = "BannerTablePanel";
            this.BannerTablePanel.RowCount = 2;
            this.BannerTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BannerTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BannerTablePanel.Size = new System.Drawing.Size(1004, 66);
            this.BannerTablePanel.TabIndex = 0;
            // 
            // LogoutLink
            // 
            this.LogoutLink.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogoutLink.LineColor = System.Drawing.Color.Transparent;
            this.LogoutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LogoutLink.Location = new System.Drawing.Point(952, 36);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(49, 19);
            this.LogoutLink.TabIndex = 4;
            this.LogoutLink.Text = "Logout";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.InitialImage")));
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.BannerTablePanel.SetRowSpan(this.LogoPictureBox, 2);
            this.LogoPictureBox.Size = new System.Drawing.Size(150, 66);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Ravie", 22F);
            this.TitleLabel.Location = new System.Drawing.Point(153, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.BannerTablePanel.SetRowSpan(this.TitleLabel, 2);
            this.TitleLabel.Size = new System.Drawing.Size(596, 66);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Voice Of The Asistians";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoggedLink
            // 
            this.LoggedLink.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoggedLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoggedLink.LineColor = System.Drawing.Color.Transparent;
            this.LoggedLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LoggedLink.Location = new System.Drawing.Point(878, 3);
            this.LoggedLink.Name = "LoggedLink";
            this.LoggedLink.Size = new System.Drawing.Size(123, 19);
            this.LoggedLink.TabIndex = 3;
            this.LoggedLink.Text = "Logged as: Admin";
            // 
            // SidePanel
            // 
            this.SidePanel.Controls.Add(this.MainNavAccordion);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 70);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(200, 592);
            this.SidePanel.TabIndex = 1;
            // 
            // MainNavAccordion
            // 
            this.MainNavAccordion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainNavAccordion.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.SessionHeader,
            this.ParticipantHeader,
            this.OthersHeader,
            this.ReportsHeader});
            this.MainNavAccordion.Location = new System.Drawing.Point(0, 0);
            this.MainNavAccordion.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.MainNavAccordion.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MainNavAccordion.Name = "MainNavAccordion";
            this.MainNavAccordion.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.MainNavAccordion.Size = new System.Drawing.Size(200, 592);
            this.MainNavAccordion.TabIndex = 2;
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
            this.VotingSessionsElement.Click += new System.EventHandler(this.NavigationElement_Click);
            // 
            // SchoolYearsElement
            // 
            this.SchoolYearsElement.Name = "SchoolYearsElement";
            this.SchoolYearsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SchoolYearsElement.Text = "School Years";
            // 
            // ParticipantHeader
            // 
            this.ParticipantHeader.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.StudentsElement,
            this.CandidatesElements});
            this.ParticipantHeader.Expanded = true;
            this.ParticipantHeader.Name = "ParticipantHeader";
            this.ParticipantHeader.Text = "Participants";
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
            // OthersHeader
            // 
            this.OthersHeader.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.PositionsElement,
            this.CampaignGroupsElements,
            this.GradesElement,
            this.SectionsElement,
            this.GradeAndSectionsElement});
            this.OthersHeader.Expanded = true;
            this.OthersHeader.Name = "OthersHeader";
            this.OthersHeader.Text = "Others";
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
            // SectionsElement
            // 
            this.SectionsElement.Name = "SectionsElement";
            this.SectionsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.SectionsElement.Text = "Sections";
            // 
            // GradeAndSectionsElement
            // 
            this.GradeAndSectionsElement.Name = "GradeAndSectionsElement";
            this.GradeAndSectionsElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.GradeAndSectionsElement.Text = "Grade And Sections";
            // 
            // ReportsHeader
            // 
            this.ReportsHeader.Name = "ReportsHeader";
            this.ReportsHeader.Text = "Reports";
            // 
            // ContentXtraPanel
            // 
            this.ContentXtraPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentXtraPanel.Location = new System.Drawing.Point(200, 70);
            this.ContentXtraPanel.Name = "ContentXtraPanel";
            this.ContentXtraPanel.Size = new System.Drawing.Size(808, 592);
            this.ContentXtraPanel.TabIndex = 2;
            // 
            // MainXtraForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.ContentXtraPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MainXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPanel)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.BannerTablePanel.ResumeLayout(false);
            this.BannerTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainNavAccordion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContentXtraPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl HeaderPanel;
        private System.Windows.Forms.TableLayoutPanel BannerTablePanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label TitleLabel;
        private DevExpress.XtraEditors.HyperlinkLabelControl LogoutLink;
        private DevExpress.XtraEditors.HyperlinkLabelControl LoggedLink;
        private System.Windows.Forms.Panel SidePanel;
        private DevExpress.XtraBars.Navigation.AccordionControl MainNavAccordion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SessionHeader;
        private DevExpress.XtraBars.Navigation.AccordionControlElement VotingSessionsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SchoolYearsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ParticipantHeader;
        private DevExpress.XtraBars.Navigation.AccordionControlElement StudentsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement CandidatesElements;
        private DevExpress.XtraBars.Navigation.AccordionControlElement OthersHeader;
        private DevExpress.XtraBars.Navigation.AccordionControlElement PositionsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement CampaignGroupsElements;
        private DevExpress.XtraBars.Navigation.AccordionControlElement GradesElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement SectionsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement GradeAndSectionsElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ReportsHeader;
        private DevExpress.XtraEditors.PanelControl ContentXtraPanel;

    }
}