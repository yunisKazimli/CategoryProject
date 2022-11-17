using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoryProject
{
    public static class TreeListManager
    {
        public static void Create(TreeList treeList, CreateMode createMode)
        {
            string[] names = new string[0];
            string[] ids = new string[0];
            try
            {
                switch (createMode)
                {
                    case CreateMode.NewBranch:
                        names = GetNewNames(createMode, new string[0]);
                        break;

                    case CreateMode.InMainCategory:
                        {
                            string[] textArray1 = new string[] { DataTableManipulator.GetParentName(treeList.GetFocusedRowCellValue("Id").ToString(), CategoryType.MainCategory) };
                            names = GetNewNames(createMode, textArray1);
                            ids = new string[] { treeList.GetFocusedRowCellValue("Id").ToString() };
                            break;
                        }
                    case CreateMode.InCategory:
                        {
                            string[] textArray3 = new string[] { DataTableManipulator.GetParentName(treeList.GetFocusedRowCellValue("Id").ToString(), CategoryType.MainCategory), DataTableManipulator.GetParentName(treeList.GetFocusedRowCellValue("Id").ToString(), CategoryType.Category) };
                            names = GetNewNames(createMode, textArray3);
                            ids = new string[] { treeList.GetFocusedRowCellValue("ParentId").ToString(), treeList.GetFocusedRowCellValue("Id").ToString() };
                            break;
                        }
                    default:
                        break;
                }
            }
            catch
            {
                return;
            }
            DataTableManipulator.CreateTable(names, ids, createMode);
            Refresh(treeList);
        }

        public static void Delete(TreeList treeList)
        {
            if (treeList.GetFocusedRow() != null)
            {
                DataTableManipulator.DeleteTable(int.Parse(treeList.GetFocusedRowCellValue("Id").ToString()));
                Refresh(treeList);
            }
        }

        public static string[] GetNewNames(CreateMode createMode, string[] names)
        {
            NewBranchDialogForm form = new NewBranchDialogForm(createMode, names);
            if (form.ShowDialog() != DialogResult.OK)
            {
                throw new Exception("Error When Try Get New Category Name");
            }
            return new string[] { form.mainCategoryNameTextEdit.Text, form.categoryNameTextEdit.Text, form.subCategoryNameTextEdit.Text };
        }

        public static void Refresh(TreeList treeList)
        {
            treeList.DataSource = DataTableManipulator.ConvertToTreeView();
        }

        public static void Update(TreeList treeList)
        {
            if (treeList.GetFocusedRow() != null)
            {
                DataTableManipulator.UpdateTable(int.Parse(treeList.GetFocusedRowCellValue("Id").ToString()), treeList.GetFocusedRowCellValue("Category Name").ToString());
                Refresh(treeList);
            }
        }
    }
}
