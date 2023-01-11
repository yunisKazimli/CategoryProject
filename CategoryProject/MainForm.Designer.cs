
namespace CategoryProject
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.treeListAddButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel = new System.Windows.Forms.Panel();
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCategoryName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListCreateButtonColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListAddRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.categoryResultTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataBaseDataSet = new CategoryProject.CategoryDataBaseDataSet();
            this.createButton = new DevExpress.XtraEditors.SimpleButton();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.refreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.categoryResultTableTableAdapter = new CategoryProject.CategoryDataBaseDataSetTableAdapters.CategoryResultTableTableAdapter();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeListAddButtonEdit)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListAddRepositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryResultTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListAddButtonEdit
            // 
            this.treeListAddButtonEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.treeListAddButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.treeListAddButtonEdit.Name = "treeListAddButtonEdit";
            this.treeListAddButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.treeList);
            this.panel.Controls.Add(this.createButton);
            this.panel.Controls.Add(this.deleteButton);
            this.panel.Controls.Add(this.refreshButton);
            this.panel.Location = new System.Drawing.Point(-9, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1124, 621);
            this.panel.TabIndex = 3;
            // 
            // treeList
            // 
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colCategoryName,
            this.colParentId,
            this.treeListCreateButtonColumn});
            this.treeList.DataSource = this.categoryResultTableBindingSource;
            this.treeList.Location = new System.Drawing.Point(0, 51);
            this.treeList.Name = "treeList";
            this.treeList.OptionsPrint.PrintFilledTreeIndent = true;
            this.treeList.OptionsPrint.PrintReportFooter = false;
            this.treeList.OptionsPrint.PrintTree = false;
            this.treeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.treeListAddRepositoryItemButtonEdit});
            this.treeList.Size = new System.Drawing.Size(1121, 567);
            this.treeList.TabIndex = 5;
            this.treeList.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeList_CellValueChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colCategoryName
            // 
            this.colCategoryName.FieldName = "Category Name";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            // 
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.OptionsColumn.ReadOnly = true;
            this.colParentId.Visible = true;
            this.colParentId.VisibleIndex = 2;
            // 
            // treeListCreateButtonColumn
            // 
            this.treeListCreateButtonColumn.Caption = "Add";
            this.treeListCreateButtonColumn.ColumnEdit = this.treeListAddRepositoryItemButtonEdit;
            this.treeListCreateButtonColumn.FieldName = "Add";
            this.treeListCreateButtonColumn.Name = "treeListCreateButtonColumn";
            this.treeListCreateButtonColumn.Visible = true;
            this.treeListCreateButtonColumn.VisibleIndex = 3;
            // 
            // treeListAddRepositoryItemButtonEdit
            // 
            this.treeListAddRepositoryItemButtonEdit.AutoHeight = false;
            this.treeListAddRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.treeListAddRepositoryItemButtonEdit.Name = "treeListAddRepositoryItemButtonEdit";
            this.treeListAddRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.treeListAddRepositoryItemButtonEdit.Click += new System.EventHandler(this.treeListAddButtonEdit_Click);
            // 
            // categoryResultTableBindingSource
            // 
            this.categoryResultTableBindingSource.DataMember = "CategoryResultTable";
            this.categoryResultTableBindingSource.DataSource = this.categoryDataBaseDataSet;
            // 
            // categoryDataBaseDataSet
            // 
            this.categoryDataBaseDataSet.DataSetName = "CategoryDataBaseDataSet";
            this.categoryDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // createButton
            // 
            this.createButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.createButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("createButton.ImageOptions.SvgImage")));
            this.createButton.Location = new System.Drawing.Point(0, 0);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(68, 54);
            this.createButton.TabIndex = 3;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.ImageOptions.Image")));
            this.deleteButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.deleteButton.Location = new System.Drawing.Point(65, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(71, 54);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.ImageOptions.Image")));
            this.refreshButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.refreshButton.Location = new System.Drawing.Point(131, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(67, 54);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // categoryResultTableTableAdapter
            // 
            this.categoryResultTableTableAdapter.ClearBeforeFill = true;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 605);
            this.Controls.Add(this.panel);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListAddButtonEdit)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListAddRepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryResultTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private DevExpress.XtraEditors.SimpleButton refreshButton;
        private DevExpress.XtraTreeList.TreeList treeList;
        private CategoryDataBaseDataSet categoryDataBaseDataSet;
        private System.Windows.Forms.BindingSource categoryResultTableBindingSource;
        private CategoryDataBaseDataSetTableAdapters.CategoryResultTableTableAdapter categoryResultTableTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCategoryName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentId;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton createButton;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit treeListAddButtonEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListCreateButtonColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit treeListAddRepositoryItemButtonEdit;
    }
}

