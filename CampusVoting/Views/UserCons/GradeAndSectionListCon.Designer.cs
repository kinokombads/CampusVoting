namespace CampusVoting.Views.UserCons
{
    partial class GradeAndSectionListCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeAndSectionListCon));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SectionEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AddSimButton = new DevExpress.XtraEditors.SimpleButton();
            this.SearchButton = new DevExpress.XtraEditors.SimpleButton();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ListNameLabel = new System.Windows.Forms.Label();
            this.GradeEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ListGridControl = new DevExpress.XtraGrid.GridControl();
            this.ItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TitleColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GradeIdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GradeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SectionIdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SectionColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedByColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedOnColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifiedByColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifiedOnColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EditColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EditRepoButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRepoButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.NoteLabel);
            this.SearchPanel.Controls.Add(this.SectionEdit);
            this.SearchPanel.Controls.Add(this.AddSimButton);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.NameTextEdit);
            this.SearchPanel.Controls.Add(this.ListNameLabel);
            this.SearchPanel.Controls.Add(this.GradeEdit);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(848, 125);
            this.SearchPanel.TabIndex = 0;
            // 
            // SectionEdit
            // 
            this.SectionEdit.Location = new System.Drawing.Point(488, 39);
            this.SectionEdit.Margin = new System.Windows.Forms.Padding(2);
            this.SectionEdit.Name = "SectionEdit";
            this.SectionEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionEdit.Properties.Appearance.Options.UseFont = true;
            this.SectionEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SectionEdit.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.SectionEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.SectionEdit.Properties.NullText = "";
            this.SectionEdit.Properties.NullValuePrompt = "Search By Section";
            this.SectionEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.SectionEdit.Properties.View = this.gridView1;
            this.SectionEdit.Size = new System.Drawing.Size(171, 26);
            this.SectionEdit.TabIndex = 7;
            this.SectionEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.SectionEdit_QueryPopUp);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // AddSimButton
            // 
            this.AddSimButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSimButton.Appearance.Options.UseFont = true;
            this.AddSimButton.Image = ((System.Drawing.Image)(resources.GetObject("AddSimButton.Image")));
            this.AddSimButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.AddSimButton.Location = new System.Drawing.Point(9, 80);
            this.AddSimButton.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.AddSimButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.AddSimButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddSimButton.Name = "AddSimButton";
            this.AddSimButton.Size = new System.Drawing.Size(40, 40);
            this.AddSimButton.TabIndex = 5;
            this.AddSimButton.ToolTip = "Add";
            this.AddSimButton.Click += new System.EventHandler(this.AddSimButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Appearance.Options.UseFont = true;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.SearchButton.Location = new System.Drawing.Point(663, 33);
            this.SearchButton.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.SearchButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(40, 40);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.ToolTip = "Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.Location = new System.Drawing.Point(9, 39);
            this.NameTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.NameTextEdit.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.NameTextEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.NameTextEdit.Properties.NullValuePrompt = "Search By Section Name";
            this.NameTextEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.NameTextEdit.Size = new System.Drawing.Size(300, 26);
            this.NameTextEdit.TabIndex = 3;
            this.NameTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextEdit_KeyPress);
            // 
            // ListNameLabel
            // 
            this.ListNameLabel.AutoSize = true;
            this.ListNameLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNameLabel.Location = new System.Drawing.Point(2, 0);
            this.ListNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListNameLabel.Name = "ListNameLabel";
            this.ListNameLabel.Size = new System.Drawing.Size(245, 31);
            this.ListNameLabel.TabIndex = 1;
            this.ListNameLabel.Text = "Grade && Section List";
            // 
            // GradeEdit
            // 
            this.GradeEdit.Location = new System.Drawing.Point(313, 39);
            this.GradeEdit.Margin = new System.Windows.Forms.Padding(2);
            this.GradeEdit.Name = "GradeEdit";
            this.GradeEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeEdit.Properties.Appearance.Options.UseFont = true;
            this.GradeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GradeEdit.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.GradeEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.GradeEdit.Properties.NullText = "";
            this.GradeEdit.Properties.NullValuePrompt = "Search By Grade";
            this.GradeEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.GradeEdit.Properties.View = this.searchLookUpEdit1View;
            this.GradeEdit.Size = new System.Drawing.Size(171, 26);
            this.GradeEdit.TabIndex = 6;
            this.GradeEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.GradeEdit_QueryPopUp);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ListGridControl
            // 
            this.ListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGridControl.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListGridControl.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.ListGridControl.Location = new System.Drawing.Point(0, 125);
            this.ListGridControl.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.ListGridControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ListGridControl.MainView = this.ItemsGridView;
            this.ListGridControl.Name = "ListGridControl";
            this.ListGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.EditRepoButton});
            this.ListGridControl.Size = new System.Drawing.Size(848, 467);
            this.ListGridControl.TabIndex = 1;
            this.ListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ItemsGridView});
            this.ListGridControl.Layout += new System.Windows.Forms.LayoutEventHandler(this.ListGridControl_Layout);
            this.ListGridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListGridControl_MouseDoubleClick);
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.ItemsGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.ItemsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdColumn,
            this.TitleColumn,
            this.GradeIdColumn,
            this.GradeColumn,
            this.SectionIdColumn,
            this.SectionColumn,
            this.CreatedByColumn,
            this.CreatedOnColumn,
            this.ModifiedByColumn,
            this.ModifiedOnColumn,
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
            // GradeIdColumn
            // 
            this.GradeIdColumn.Caption = "Grade Id";
            this.GradeIdColumn.FieldName = "GradeId";
            this.GradeIdColumn.Name = "GradeIdColumn";
            // 
            // GradeColumn
            // 
            this.GradeColumn.Caption = "Grade";
            this.GradeColumn.FieldName = "Grade";
            this.GradeColumn.Name = "GradeColumn";
            this.GradeColumn.OptionsColumn.AllowEdit = false;
            this.GradeColumn.Visible = true;
            this.GradeColumn.VisibleIndex = 1;
            // 
            // SectionIdColumn
            // 
            this.SectionIdColumn.Caption = "Section Id";
            this.SectionIdColumn.FieldName = "SectionId";
            this.SectionIdColumn.Name = "SectionIdColumn";
            // 
            // SectionColumn
            // 
            this.SectionColumn.Caption = "Section";
            this.SectionColumn.FieldName = "Section";
            this.SectionColumn.Name = "SectionColumn";
            this.SectionColumn.OptionsColumn.AllowEdit = false;
            this.SectionColumn.Visible = true;
            this.SectionColumn.VisibleIndex = 2;
            // 
            // CreatedByColumn
            // 
            this.CreatedByColumn.Caption = "Creator";
            this.CreatedByColumn.FieldName = "CreatedBy";
            this.CreatedByColumn.Name = "CreatedByColumn";
            this.CreatedByColumn.OptionsColumn.AllowEdit = false;
            this.CreatedByColumn.Visible = true;
            this.CreatedByColumn.VisibleIndex = 3;
            // 
            // CreatedOnColumn
            // 
            this.CreatedOnColumn.Caption = "Created On";
            this.CreatedOnColumn.FieldName = "CreatedOn";
            this.CreatedOnColumn.Name = "CreatedOnColumn";
            this.CreatedOnColumn.OptionsColumn.AllowEdit = false;
            this.CreatedOnColumn.Visible = true;
            this.CreatedOnColumn.VisibleIndex = 4;
            // 
            // ModifiedByColumn
            // 
            this.ModifiedByColumn.Caption = "Modifier";
            this.ModifiedByColumn.FieldName = "ModifiedBy";
            this.ModifiedByColumn.Name = "ModifiedByColumn";
            this.ModifiedByColumn.OptionsColumn.AllowEdit = false;
            this.ModifiedByColumn.Visible = true;
            this.ModifiedByColumn.VisibleIndex = 5;
            // 
            // ModifiedOnColumn
            // 
            this.ModifiedOnColumn.Caption = "Modified On";
            this.ModifiedOnColumn.FieldName = "ModifiedOn";
            this.ModifiedOnColumn.Name = "ModifiedOnColumn";
            this.ModifiedOnColumn.OptionsColumn.AllowEdit = false;
            this.ModifiedOnColumn.Visible = true;
            this.ModifiedOnColumn.VisibleIndex = 6;
            // 
            // EditColumn
            // 
            this.EditColumn.ColumnEdit = this.EditRepoButton;
            this.EditColumn.MaxWidth = 100;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.Visible = true;
            this.EditColumn.VisibleIndex = 7;
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
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.NoteLabel.Location = new System.Drawing.Point(54, 101);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(61, 19);
            this.NoteLabel.TabIndex = 8;
            this.NoteLabel.Text = "Result: 0";
            // 
            // GradeAndSectionListCon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.ListGridControl);
            this.Controls.Add(this.SearchPanel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "GradeAndSectionListCon";
            this.Size = new System.Drawing.Size(848, 592);
            this.VisibleChanged += new System.EventHandler(this.GradeAndSectionListCon_VisibleChanged);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditRepoButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label ListNameLabel;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraGrid.GridControl ListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ItemsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn IdColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TitleColumn;
        private DevExpress.XtraGrid.Columns.GridColumn EditColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit EditRepoButton;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedByColumn;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedOnColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ModifiedByColumn;
        private DevExpress.XtraGrid.Columns.GridColumn ModifiedOnColumn;
        private DevExpress.XtraEditors.SimpleButton AddSimButton;
        private DevExpress.XtraEditors.SimpleButton SearchButton;
        private DevExpress.XtraEditors.SearchLookUpEdit GradeEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit SectionEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn GradeIdColumn;
        private DevExpress.XtraGrid.Columns.GridColumn GradeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SectionIdColumn;
        private DevExpress.XtraGrid.Columns.GridColumn SectionColumn;
        private System.Windows.Forms.Label NoteLabel;
    }
}
