using DevExpress.XtraEditors;

namespace CategoryProject
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            GridRefresh();
        }

        private void refreshButton_Click(object sender, System.EventArgs e)
        {
            GridRefresh();
        }

        private void GridRefresh()
        {
            TreeListManager.Refresh(treeList);
        }

        private void treeList_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            TreeListManager.Update(treeList);
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            TreeListManager.Delete(treeList);
        }

        private void createButton_Click(object sender, System.EventArgs e)
        {
            TreeListManager.Create(treeList, CreateMode.NewBranch);
        }

        private void treeListAddButtonEdit_Click(object sender, System.EventArgs e)
        {
            if (treeList.GetFocusedRowCellValue("Id").ToString().Length == 9) return;

            TreeListManager.Create(treeList, treeList.GetFocusedRowCellValue("Id").ToString().Length == 3 ? CreateMode.InMainCategory : CreateMode.InCategory);
        }
    }
}
