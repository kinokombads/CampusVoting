using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;

namespace CampusVoting.Views
{
    partial class SampleListPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleListPage));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.GridPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.ListGridControl = new DevExpress.XtraGrid.GridControl();
            this.ItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LrnColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EditColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.DeleteColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPanelControl)).BeginInit();
            this.GridPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.simpleButton4);
            this.SearchPanel.Controls.Add(this.simpleButton3);
            this.SearchPanel.Controls.Add(this.simpleButton2);
            this.SearchPanel.Controls.Add(this.simpleButton1);
            this.SearchPanel.Controls.Add(this.TitleTextEdit);
            this.SearchPanel.Controls.Add(this.label1);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(848, 127);
            this.SearchPanel.TabIndex = 0;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton4.Location = new System.Drawing.Point(78, 88);
            this.simpleButton4.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.simpleButton4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(28, 28);
            this.simpleButton4.TabIndex = 5;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.Location = new System.Drawing.Point(9, 88);
            this.simpleButton3.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.simpleButton3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(28, 28);
            this.simpleButton3.TabIndex = 4;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.AutoWidthInLayoutControl = true;
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(9, 43);
            this.simpleButton2.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.simpleButton2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(28, 28);
            this.simpleButton2.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(299, 43);
            this.simpleButton1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(28, 28);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TitleTextEdit
            // 
            this.TitleTextEdit.EditValue = "";
            this.TitleTextEdit.Location = new System.Drawing.Point(43, 43);
            this.TitleTextEdit.Name = "TitleTextEdit";
            this.TitleTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextEdit.Properties.Appearance.Options.UseFont = true;
            this.TitleTextEdit.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.TitleTextEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.TitleTextEdit.Properties.NullValuePrompt = "Search Grade";
            this.TitleTextEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.TitleTextEdit.Size = new System.Drawing.Size(250, 28);
            this.TitleTextEdit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade List";
            // 
            // GridPanelControl
            // 
            this.GridPanelControl.Controls.Add(this.ListGridControl);
            this.GridPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanelControl.FireScrollEventOnMouseWheel = true;
            this.GridPanelControl.Location = new System.Drawing.Point(0, 127);
            this.GridPanelControl.Name = "GridPanelControl";
            this.GridPanelControl.Size = new System.Drawing.Size(848, 465);
            this.GridPanelControl.TabIndex = 2;
            // 
            // ListGridControl
            // 
            this.ListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGridControl.Location = new System.Drawing.Point(2, 2);
            this.ListGridControl.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.ListGridControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ListGridControl.MainView = this.ItemsGridView;
            this.ListGridControl.Name = "ListGridControl";
            this.ListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2});
            this.ListGridControl.Size = new System.Drawing.Size(844, 461);
            this.ListGridControl.TabIndex = 0;
            this.ListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ItemsGridView});
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColumn,
            this.LrnColumn,
            this.LastNameColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.ItemsGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ItemsGridView.GridControl = this.ListGridControl;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.ItemsGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.ItemsGridView.OptionsBehavior.Editable = false;
            // 
            // IdColumn
            // 
            this.IdColumn.Caption = "Id";
            this.IdColumn.FieldName = "Id";
            this.IdColumn.Name = "IdColumn";
            // 
            // LrnColumn
            // 
            this.LrnColumn.Caption = "LRN";
            this.LrnColumn.FieldName = "LRN";
            this.LrnColumn.Name = "LrnColumn";
            this.LrnColumn.Visible = true;
            this.LrnColumn.VisibleIndex = 0;
            // 
            // LastNameColumn
            // 
            this.LastNameColumn.Caption = "Last Name";
            this.LastNameColumn.FieldName = "LastName";
            this.LastNameColumn.Name = "LastNameColumn";
            this.LastNameColumn.Visible = true;
            this.LastNameColumn.VisibleIndex = 1;
            // 
            // EditColumn
            // 
            this.EditColumn.Caption = "Edit";
            this.EditColumn.ColumnEdit = this.repositoryItemButtonEdit2;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.Visible = true;
            this.EditColumn.VisibleIndex = 3;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit2.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.Caption = "Delete";
            this.DeleteColumn.ColumnEdit = this.repositoryItemButtonEdit1;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.DeleteColumn.Visible = true;
            this.DeleteColumn.VisibleIndex = 2;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // SampleListPage
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.GridPanelControl);
            this.Controls.Add(this.SearchPanel);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SampleListPage";
            this.Size = new System.Drawing.Size(848, 592);
            this.Load += new System.EventHandler(this.GradeListDevPage_Load);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPanelControl)).EndInit();
            this.GridPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SearchPanel;
        private TextEdit TitleTextEdit;
        private Label label1;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton2;
        private PanelControl GridPanelControl;
        private GridControl ListGridControl;
        private GridView ItemsGridView;
        private SimpleButton simpleButton3;
        private SimpleButton simpleButton4;
        private GridColumn IdColumn;
        private GridColumn LrnColumn;
        private GridColumn LastNameColumn;
        private GridColumn EditColumn;
        private RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private GridColumn DeleteColumn;
        private RepositoryItemButtonEdit repositoryItemButtonEdit1;
        
        
    }
}
