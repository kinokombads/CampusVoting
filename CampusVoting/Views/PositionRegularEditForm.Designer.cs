namespace CampusVoting.Views
{
    partial class PositionRegularEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionRegularEditForm));
            this.DetailsColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PositionEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TitleColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.TypeLookUp = new DevExpress.XtraEditors.GridLookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.DetailMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.panel11 = new System.Windows.Forms.Panel();
            this.MainPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.MainScrollCon = new DevExpress.XtraEditors.XtraScrollableControl();
            this.ClearSimButton = new DevExpress.XtraEditors.SimpleButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.SaveSimButton = new DevExpress.XtraEditors.SimpleButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.PageLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeLookUp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailMemoEdit.Properties)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanelControl)).BeginInit();
            this.MainPanelControl.SuspendLayout();
            this.MainScrollCon.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailsColumn
            // 
            this.DetailsColumn.Caption = "Details";
            this.DetailsColumn.FieldName = "Details";
            this.DetailsColumn.Name = "DetailsColumn";
            this.DetailsColumn.OptionsColumn.AllowEdit = false;
            this.DetailsColumn.Visible = true;
            this.DetailsColumn.VisibleIndex = 1;
            // 
            // IdColumn
            // 
            this.IdColumn.AppearanceCell.Options.UseTextOptions = true;
            this.IdColumn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.IdColumn.Caption = "Id";
            this.IdColumn.FieldName = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.OptionsColumn.AllowEdit = false;
            this.IdColumn.OptionsColumn.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(0, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(448, 22);
            this.panel6.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(46, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // PositionEditView
            // 
            this.PositionEditView.Appearance.FocusedRow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionEditView.Appearance.FocusedRow.Options.UseFont = true;
            this.PositionEditView.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.PositionEditView.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PositionEditView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionEditView.Appearance.HeaderPanel.Options.UseFont = true;
            this.PositionEditView.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionEditView.Appearance.Row.Options.UseFont = true;
            this.PositionEditView.Appearance.Row.Options.UseTextOptions = true;
            this.PositionEditView.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PositionEditView.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.PositionEditView.AppearancePrint.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PositionEditView.AppearancePrint.Row.Options.UseTextOptions = true;
            this.PositionEditView.AppearancePrint.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PositionEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColumn,
            this.TitleColumn,
            this.DetailsColumn});
            this.PositionEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.PositionEditView.Name = "PositionEditView";
            this.PositionEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.PositionEditView.OptionsView.RowAutoHeight = true;
            this.PositionEditView.OptionsView.ShowGroupPanel = false;
            // 
            // TitleColumn
            // 
            this.TitleColumn.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleColumn.AppearanceCell.Options.UseFont = true;
            this.TitleColumn.AppearanceCell.Options.UseTextOptions = true;
            this.TitleColumn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TitleColumn.Caption = "Name";
            this.TitleColumn.FieldName = "Title";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.OptionsColumn.AllowEdit = false;
            this.TitleColumn.OptionsColumn.ReadOnly = true;
            this.TitleColumn.Visible = true;
            this.TitleColumn.VisibleIndex = 0;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 116);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(448, 5);
            this.panel12.TabIndex = 28;
            // 
            // TypeLookUp
            // 
            this.TypeLookUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.TypeLookUp.Location = new System.Drawing.Point(0, 90);
            this.TypeLookUp.Name = "TypeLookUp";
            this.TypeLookUp.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLookUp.Properties.Appearance.Options.UseFont = true;
            this.TypeLookUp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TypeLookUp.Properties.NullText = "";
            this.TypeLookUp.Properties.NullValuePrompt = "Select Position Type";
            this.TypeLookUp.Properties.NullValuePromptShowForEmptyValue = true;
            this.TypeLookUp.Properties.ReadOnly = true;
            this.TypeLookUp.Properties.View = this.PositionEditView;
            this.TypeLookUp.Size = new System.Drawing.Size(448, 26);
            this.TypeLookUp.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Details";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 243);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(448, 5);
            this.panel9.TabIndex = 31;
            // 
            // DetailMemoEdit
            // 
            this.DetailMemoEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetailMemoEdit.Location = new System.Drawing.Point(0, 143);
            this.DetailMemoEdit.Name = "DetailMemoEdit";
            this.DetailMemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailMemoEdit.Properties.Appearance.Options.UseFont = true;
            this.DetailMemoEdit.Properties.NullValuePrompt = "Some description";
            this.DetailMemoEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.DetailMemoEdit.Size = new System.Drawing.Size(448, 100);
            this.DetailMemoEdit.TabIndex = 30;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DimGray;
            this.panel11.Controls.Add(this.label5);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(0, 121);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(448, 22);
            this.panel11.TabIndex = 29;
            // 
            // MainPanelControl
            // 
            this.MainPanelControl.Controls.Add(this.MainScrollCon);
            this.MainPanelControl.Controls.Add(this.HeaderPanel);
            this.MainPanelControl.Controls.Add(this.panel4);
            this.MainPanelControl.Controls.Add(this.panel1);
            this.MainPanelControl.Controls.Add(this.panel2);
            this.MainPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelControl.Location = new System.Drawing.Point(0, 0);
            this.MainPanelControl.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.MainPanelControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MainPanelControl.Name = "MainPanelControl";
            this.MainPanelControl.Size = new System.Drawing.Size(462, 433);
            this.MainPanelControl.TabIndex = 2;
            // 
            // MainScrollCon
            // 
            this.MainScrollCon.Controls.Add(this.ClearSimButton);
            this.MainScrollCon.Controls.Add(this.panel10);
            this.MainScrollCon.Controls.Add(this.SaveSimButton);
            this.MainScrollCon.Controls.Add(this.panel9);
            this.MainScrollCon.Controls.Add(this.DetailMemoEdit);
            this.MainScrollCon.Controls.Add(this.panel11);
            this.MainScrollCon.Controls.Add(this.panel12);
            this.MainScrollCon.Controls.Add(this.TypeLookUp);
            this.MainScrollCon.Controls.Add(this.panel8);
            this.MainScrollCon.Controls.Add(this.panel7);
            this.MainScrollCon.Controls.Add(this.NameTextEdit);
            this.MainScrollCon.Controls.Add(this.panel6);
            this.MainScrollCon.Controls.Add(this.panel5);
            this.MainScrollCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainScrollCon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScrollCon.Location = new System.Drawing.Point(7, 47);
            this.MainScrollCon.Name = "MainScrollCon";
            this.MainScrollCon.Size = new System.Drawing.Size(448, 384);
            this.MainScrollCon.TabIndex = 10;
            // 
            // ClearSimButton
            // 
            this.ClearSimButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSimButton.Appearance.Options.UseFont = true;
            this.ClearSimButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearSimButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearSimButton.Image")));
            this.ClearSimButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ClearSimButton.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.ClearSimButton.Location = new System.Drawing.Point(0, 293);
            this.ClearSimButton.Name = "ClearSimButton";
            this.ClearSimButton.Size = new System.Drawing.Size(448, 40);
            this.ClearSimButton.TabIndex = 34;
            this.ClearSimButton.Text = "CLEAR  ";
            this.ClearSimButton.Click += new System.EventHandler(this.ClearSimButton_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 288);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(448, 5);
            this.panel10.TabIndex = 33;
            // 
            // SaveSimButton
            // 
            this.SaveSimButton.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSimButton.Appearance.Options.UseFont = true;
            this.SaveSimButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveSimButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveSimButton.Image")));
            this.SaveSimButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.SaveSimButton.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.SaveSimButton.Location = new System.Drawing.Point(0, 248);
            this.SaveSimButton.Name = "SaveSimButton";
            this.SaveSimButton.Size = new System.Drawing.Size(448, 40);
            this.SaveSimButton.TabIndex = 32;
            this.SaveSimButton.Text = "UPDATE";
            this.SaveSimButton.Click += new System.EventHandler(this.SaveSimButton_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(0, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(448, 22);
            this.panel8.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(91, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Position Type";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 63);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(448, 5);
            this.panel7.TabIndex = 21;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameTextEdit.Location = new System.Drawing.Point(0, 37);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.NameTextEdit.Properties.NullValuePrompt = "Position name";
            this.NameTextEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.NameTextEdit.Size = new System.Drawing.Size(448, 26);
            this.NameTextEdit.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(448, 15);
            this.panel5.TabIndex = 18;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.PageLabel);
            this.HeaderPanel.Controls.Add(this.panel3);
            this.HeaderPanel.Controls.Add(this.LogoPictureBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(7, 7);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(448, 40);
            this.HeaderPanel.TabIndex = 9;
            // 
            // PageLabel
            // 
            this.PageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageLabel.Location = new System.Drawing.Point(40, 0);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(368, 40);
            this.PageLabel.TabIndex = 3;
            this.PageLabel.Text = "Edit Regular Position";
            this.PageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(408, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 40);
            this.panel3.TabIndex = 2;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(40, 40);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.Click += new System.EventHandler(this.LogoPictureBox_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(455, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 424);
            this.panel4.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 424);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 5);
            this.panel2.TabIndex = 6;
            // 
            // PositionRegularEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(462, 433);
            this.Controls.Add(this.MainPanelControl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PositionRegularEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PositionRegularEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PositioniRegularEditForm_FormClosing);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeLookUp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailMemoEdit.Properties)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPanelControl)).EndInit();
            this.MainPanelControl.ResumeLayout(false);
            this.MainScrollCon.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn DetailsColumn;
        private DevExpress.XtraGrid.Columns.GridColumn IdColumn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.Grid.GridView PositionEditView;
        private DevExpress.XtraGrid.Columns.GridColumn TitleColumn;
        private System.Windows.Forms.Panel panel12;
        private DevExpress.XtraEditors.GridLookUpEdit TypeLookUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.MemoEdit DetailMemoEdit;
        private System.Windows.Forms.Panel panel11;
        private DevExpress.XtraEditors.PanelControl MainPanelControl;
        private DevExpress.XtraEditors.XtraScrollableControl MainScrollCon;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton ClearSimButton;
        private System.Windows.Forms.Panel panel10;
        private DevExpress.XtraEditors.SimpleButton SaveSimButton;
    }
}