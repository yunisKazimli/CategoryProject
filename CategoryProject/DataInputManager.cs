using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryProject
{
    /// <summary>
    /// Class for entering some data 
    /// </summary>
    public static class DataInputManager
    {
        public static string GetCategoryName()
        {
            return XtraInputBox.Show("prompt", "title", "defalutresponse", System.Windows.Forms.MessageBoxButtons.OK);
        }
    }
}
