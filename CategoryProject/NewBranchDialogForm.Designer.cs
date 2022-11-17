
namespace CategoryProject
{
    partial class NewBranchDialogForm
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
            this.mainCategoryNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.categoryNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.subCategoryNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mainCategoryNamelabelControl = new DevExpress.XtraEditors.LabelControl();
            this.categoryName = new DevExpress.XtraEditors.LabelControl();
            this.subCategoryName = new DevExpress.XtraEditors.LabelControl();
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryNameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCategoryNameTextEdit
            // 
            this.mainCategoryNameTextEdit.Location = new System.Drawing.Point(157, 33);
            this.mainCategoryNameTextEdit.Name = "mainCategoryNameTextEdit";
            this.mainCategoryNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mainCategoryNameTextEdit.TabIndex = 0;
            // 
            // categoryNameTextEdit
            // 
            this.categoryNameTextEdit.Location = new System.Drawing.Point(157, 59);
            this.categoryNameTextEdit.Name = "categoryNameTextEdit";
            this.categoryNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.categoryNameTextEdit.TabIndex = 1;
            // 
            // subCategoryNameTextEdit
            // 
            this.subCategoryNameTextEdit.Location = new System.Drawing.Point(157, 85);
            this.subCategoryNameTextEdit.Name = "subCategoryNameTextEdit";
            this.subCategoryNameTextEdit.Size = new System.Drawing.Size(100, 20);
            this.subCategoryNameTextEdit.TabIndex = 2;
            // 
            // mainCategoryNamelabelControl
            // 
            this.mainCategoryNamelabelControl.Location = new System.Drawing.Point(36, 36);
            this.mainCategoryNamelabelControl.Name = "mainCategoryNamelabelControl";
            this.mainCategoryNamelabelControl.Size = new System.Drawing.Size(100, 13);
            this.mainCategoryNamelabelControl.TabIndex = 3;
            this.mainCategoryNamelabelControl.Text = "Main Category Name";
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(36, 62);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(75, 13);
            this.categoryName.TabIndex = 4;
            this.categoryName.Text = "Category Name";
            // 
            // subCategoryName
            // 
            this.subCategoryName.Location = new System.Drawing.Point(36, 88);
            this.subCategoryName.Name = "subCategoryName";
            this.subCategoryName.Size = new System.Drawing.Size(96, 13);
            this.subCategoryName.TabIndex = 5;
            this.subCategoryName.Text = "Sub Category Name";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(211, 120);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 120);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewBranchDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 155);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.subCategoryName);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.mainCategoryNamelabelControl);
            this.Controls.Add(this.subCategoryNameTextEdit);
            this.Controls.Add(this.categoryNameTextEdit);
            this.Controls.Add(this.mainCategoryNameTextEdit);
            this.Name = "NewBranchDialogForm";
            this.Text = "NewBranchDialogForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainCategoryNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryNameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.TextEdit mainCategoryNameTextEdit;
        public DevExpress.XtraEditors.TextEdit categoryNameTextEdit;
        public DevExpress.XtraEditors.TextEdit subCategoryNameTextEdit;
        private DevExpress.XtraEditors.LabelControl mainCategoryNamelabelControl;
        private DevExpress.XtraEditors.LabelControl categoryName;
        private DevExpress.XtraEditors.LabelControl subCategoryName;
        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
    }
}