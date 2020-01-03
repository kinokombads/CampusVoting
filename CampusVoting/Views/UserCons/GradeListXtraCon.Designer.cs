namespace CampusVoting.Views.UserCons
{
    partial class GradeListXtraCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeListXtraCon));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new DevExpress.XtraEditors.SimpleButton();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.GridViewPanel = new System.Windows.Forms.Panel();
            this.ListGridControl = new DevExpress.XtraGrid.GridControl();
            this.ItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitleColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DetailsColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EditColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EditRepoButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            this.GridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRepoButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.NameTextEdit);
            this.SearchPanel.Controls.Add(this.label1);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(848, 125);
            this.SearchPanel.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Appearance.Options.UseFont = true;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.SearchButton.Location = new System.Drawing.Point(314, 36);
            this.SearchButton.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.SearchButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(40, 40);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.Location = new System.Drawing.Point(10, 42);
            this.NameTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.NameTextEdit.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.NameTextEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.NameTextEdit.Properties.NullValuePrompt = "Search Grade";
            this.NameTextEdit.Size = new System.Drawing.Size(300, 30);
            this.NameTextEdit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade List";
            // 
            // GridViewPanel
            // 
            this.GridViewPanel.Controls.Add(this.ListGridControl);
            this.GridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewPanel.Location = new System.Drawing.Point(0, 125);
            this.GridViewPanel.Margin = new System.Windows.Forms.Padding(2);
            this.GridViewPanel.Name = "GridViewPanel";
            this.GridViewPanel.Size = new System.Drawing.Size(848, 467);
            this.GridViewPanel.TabIndex = 1;
            // 
            // ListGridControl
            // 
            this.ListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGridControl.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListGridControl.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.ListGridControl.Location = new System.Drawing.Point(0, 0);
            this.ListGridControl.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.ListGridControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ListGridControl.MainView = this.ItemsGridView;
            this.ListGridControl.Name = "ListGridControl";
            this.ListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.EditRepoButton});
            this.ListGridControl.Size = new System.Drawing.Size(848, 467);
            this.ListGridControl.TabIndex = 0;
            this.ListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ItemsGridView});
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColumn,
            this.TitleColumn,
            this.DetailsColumn,
            this.EditColumn});
            this.ItemsGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.ItemsGridView.GridControl = this.ListGridControl;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.ItemsGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            // 
            // IdColumn
            // 
            this.IdColumn.Caption = "Id";
            this.IdColumn.FieldName = "Id";
            this.IdColumn.Name = "IdColumn";
            // 
            // TitleColumn
            // 
            this.TitleColumn.Caption = "Name";
            this.TitleColumn.FieldName = "Title";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.OptionsColumn.AllowEdit = false;
            this.TitleColumn.Visible = true;
            this.TitleColumn.VisibleIndex = 0;
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
            // EditColumn
            // 
            this.EditColumn.ColumnEdit = this.EditRepoButton;
            this.EditColumn.MaxWidth = 100;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.Visible = true;
            this.EditColumn.VisibleIndex = 2;
            // 
            // EditRepoButton
            // 
            this.EditRepoButton.AutoHeight = false;
            toolTipItem1.Text = "Edit";
            superToolTip1.Items.Add(toolTipItem1);
            toolTipItem2.Text = "Delete";
            superToolTip2.Items.Add(toolTipItem2);
            this.EditRepoButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Edit", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("EditRepoButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Edit Item", null, superToolTip1, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("EditRepoButton.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Delete Item", null, superToolTip2, true)});
            this.EditRepoButton.Name = "EditRepoButton";
            this.EditRepoButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.EditRepoButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.EditRepoButton_ButtonClick);
            this.EditRepoButton.Click += new System.EventHandler(this.EditRepoButton_Click);
            // 
            // GradeListXtraCon
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridViewPanel);
            this.Controls.Add(this.SearchPanel);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "GradeListXtraCon";
            this.Size = new System.Drawing.Size(848, 592);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            this.GridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRepoButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SearchPanel;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton SearchButton;
        private System.Windows.Forms.Panel GridViewPanel;
        private DevExpress.XtraGrid.GridControl ListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ItemsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn IdColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TitleColumn;
        private DevExpress.XtraGrid.Columns.GridColumn DetailsColumn;
        private DevExpress.XtraGrid.Columns.GridColumn EditColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit EditRepoButton;
    }
}
