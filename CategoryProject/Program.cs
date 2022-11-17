using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CategoryProject
{
    public enum CreateMode
    {
        NewBranch,
        InMainCategory,
        InCategory
    }

    public enum CategoryType
    { 
        MainCategory,
        Category,
        SubCategory
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlConnector.Init(@"Server = DESKTOP-IAADCGV\SQLSERVER; Database = CategoryDataBase; Trusted_Connection = True; TrustServerCertificate = True; ");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
