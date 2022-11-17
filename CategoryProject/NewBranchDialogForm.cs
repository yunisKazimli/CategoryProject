using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoryProject
{
    public partial class NewBranchDialogForm : DevExpress.XtraEditors.XtraForm
    {
        private CreateMode createMode;

        public NewBranchDialogForm(CreateMode _createMode, string[] names)
        {
            createMode = _createMode;

            InitializeComponent();

            SetInputField(createMode, names);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (InputFieldTest()) DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool InputFieldTest()
        {
            if (mainCategoryNameTextEdit.Text == "")
            {
                XtraMessageBox.Show("Fill \"Main Category Name\" Field");

                return false;
            }

            if (createMode == CreateMode.NewBranch && !mainCategoryNameTextEdit.ReadOnly && !DataTableManipulator.IsNameNew(createMode, new string[] { mainCategoryNameTextEdit.Text}))
            {
                XtraMessageBox.Show("That \"Main Category Name\" Already Exist");

                return false;
            }

            if (categoryNameTextEdit.Text == "")
            {
                XtraMessageBox.Show("Fill \"Category Name\" Field");

                return false;
            }

            if (createMode == CreateMode.InMainCategory && !categoryNameTextEdit.ReadOnly && !DataTableManipulator.IsNameNew(createMode, new string[] { mainCategoryNameTextEdit.Text, categoryNameTextEdit.Text }))
            {
                XtraMessageBox.Show("That \"Category Name\" Already Exist");

                return false;
            }

            if (subCategoryNameTextEdit.Text == "")
            {
                XtraMessageBox.Show("Fill \"Sub Category Name\" Field");

                return false;
            }

            if (createMode == CreateMode.InCategory && !subCategoryNameTextEdit.ReadOnly && !DataTableManipulator.IsNameNew(createMode, new string[] { mainCategoryNameTextEdit.Text, categoryNameTextEdit.Text, subCategoryNameTextEdit.Text }))
            {
                XtraMessageBox.Show("That \"Sub Category Name\" Already Exist");

                return false;
            }

            return true;
        }

        private void SetInputField(CreateMode createMode, params string[] names)
        {
            switch(createMode)
            {
                case CreateMode.InMainCategory:
                    mainCategoryNameTextEdit.Text = names[0];

                    mainCategoryNameTextEdit.ReadOnly = true;
                    break;
                case CreateMode.InCategory:
                    mainCategoryNameTextEdit.Text = names[0];
                    categoryNameTextEdit.Text = names[1];

                    mainCategoryNameTextEdit.ReadOnly = true;
                    categoryNameTextEdit.ReadOnly = true;
                    break;
            }
        }
    }
}