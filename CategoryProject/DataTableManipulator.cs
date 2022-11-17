using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryProject
{
    public static class DataTableManipulator
    {
        public static DataTable ConvertToTreeView()
        {
            DataTable sqlResult = SqlConnector.ExQuery("SELECT MainCategoryID, MainCategoryName, CategoryID, CategoryName, SubCategoryID, SubCategoryName FROM CategoryTable", new string[] { }, new string[] { }, new SqlDbType[] { });

            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Category Name", typeof(string));
            dt.Columns.Add("ParentId", typeof(int));

            for (int i = 0; i < sqlResult.Rows.Count; i++)
            {
                if (dt.AsEnumerable().Where(el => el.Field<int>("Id") == int.Parse(sqlResult.Rows[i][0].ToString())).Count() == 0)
                {
                    dt.Rows.Add(int.Parse(sqlResult.Rows[i][0].ToString()), sqlResult.Rows[i][1].ToString(), DBNull.Value);
                    dt.Rows.Add(int.Parse(sqlResult.Rows[i][2].ToString()), sqlResult.Rows[i][3].ToString(), int.Parse(sqlResult.Rows[i][0].ToString()));
                    dt.Rows.Add(int.Parse(sqlResult.Rows[i][4].ToString()), sqlResult.Rows[i][5].ToString(), int.Parse(sqlResult.Rows[i][2].ToString()));
                }

                else
                {
                    if (dt.AsEnumerable().Where(el => el.Field<int>("Id") == int.Parse(sqlResult.Rows[i][2].ToString())).Count() == 0)
                    {
                        dt.Rows.Add(int.Parse(sqlResult.Rows[i][2].ToString()), sqlResult.Rows[i][3].ToString(), int.Parse(sqlResult.Rows[i][0].ToString()));
                        dt.Rows.Add(int.Parse(sqlResult.Rows[i][4].ToString()), sqlResult.Rows[i][5].ToString(), int.Parse(sqlResult.Rows[i][2].ToString()));
                    }
                    else dt.Rows.Add(int.Parse(sqlResult.Rows[i][4].ToString()), sqlResult.Rows[i][5].ToString(), int.Parse(sqlResult.Rows[i][2].ToString()));
                }
            }
            return dt;
        }

        public static void UpdateTable(int id, string newValue)
        {
            string updatingParamCategory = "";

            if (!IsNameNew(id, newValue)) return;

            //determine column name that must update
            switch (id.ToString().Length)
            {
                case 3:
                    updatingParamCategory = "MainCategory";
                    break;
                case 6:
                    updatingParamCategory = "Category";
                    break;
                case 9:
                    updatingParamCategory = "SubCategory";
                    break;
            }

            SqlConnector.ExNonQuery($"UPDATE CategoryTable SET {updatingParamCategory}Name = @newName WHERE {updatingParamCategory}ID = @Id", 
                new string[] 
                {
                    "@newName",
                    "@Id"
                }, 
                new string[] 
                {
                    newValue,
                    id.ToString()
                }, 
                new SqlDbType[] 
                { 
                    SqlDbType.VarChar,
                    SqlDbType.Int
                }
                );
        }

        public static void DeleteTable(int id)
        {
            string updatingParamCategory = "";

            //determine column name that must delete
            switch (id.ToString().Length)
            {
                case 3:
                    updatingParamCategory = "MainCategory";
                    break;
                case 6:
                    updatingParamCategory = "Category";
                    break;
                case 9:
                    updatingParamCategory = "SubCategory";
                    break;
            }

            SqlConnector.ExNonQuery($"DELETE FROM CategoryTable WHERE {updatingParamCategory}ID = @Id",
                new string[]
                {
                    "@Id"
                },
                new string[]
                {
                    id.ToString()
                },
                new SqlDbType[]
                {
                    SqlDbType.Int
                }
                );
        }

        public static void CreateTable(string[] names, string[] ids, CreateMode createMode)
        {
            ids = GetNewIds(ids, createMode);

            SqlConnector.ExNonQuery($"INSERT INTO CategoryTable VALUES(-1, @MainCategoryID, @MainCategoryName, @CategoryID, @CategoryName, @SubCategoryID, @SubCategoryName)",
                new string[]
                {
                    "@MainCategoryID",
                    "@MainCategoryName",
                    "@CategoryID",
                    "@CategoryName",
                    "@SubCategoryID",
                    "@SubCategoryName"
                },
                new string[]
                {
                    ids[0],
                    names[0],
                    ids[1],
                    names[1],
                    ids[2],
                    names[2],
                },
                new SqlDbType[]
                {
                    SqlDbType.Int,
                    SqlDbType.VarChar,
                    SqlDbType.Int,
                    SqlDbType.VarChar,
                    SqlDbType.Int,
                    SqlDbType.VarChar
                }
                );
        }

        public static string[] GetNewIds(string[] ids, CreateMode createMode)
        {
            switch (createMode)
            {
                case CreateMode.NewBranch:

                    string newMainCategoryID = SqlConnector.ExQuery("SELECT MAX(MainCategoryID) FROM CategoryTable", new string[] { }, new string[] { }, new SqlDbType[] { }).Rows[0][0].ToString();

                    if (newMainCategoryID == "") newMainCategoryID = "100";
                    else newMainCategoryID = (int.Parse(newMainCategoryID) + 1).ToString();

                    return new string[] { newMainCategoryID, newMainCategoryID + "100", newMainCategoryID + "100100" };

                case CreateMode.InMainCategory:

                    string newCategoryID = SqlConnector.ExQuery("SELECT MAX(CategoryID) FROM CategoryTable WHERE MainCategoryID = @MainCategoryID", 
                        new string[] 
                        {
                            "@MainCategoryID"
                        }, 
                        new string[] 
                        {
                            ids[0]
                        }, 
                        new SqlDbType[] 
                        { 
                            SqlDbType.Int
                        }
                        ).Rows[0][0].ToString();
                    
                    newCategoryID = (int.Parse(newCategoryID) + 1).ToString();

                    return new string[] { ids[0], newCategoryID, newCategoryID + "100" };

                case CreateMode.InCategory:

                    string newSubCategoryID = SqlConnector.ExQuery("SELECT MAX(SubCategoryID) FROM CategoryTable WHERE CategoryID = @CategoryID",
                        new string[]
                        {
                            "@CategoryID"
                        },
                        new string[]
                        {
                            ids[1]
                        },
                        new SqlDbType[]
                        {
                            SqlDbType.Int
                        }
                        ).Rows[0][0].ToString();

                    newSubCategoryID = (int.Parse(newSubCategoryID) + 1).ToString();

                    return new string[] { ids[0], ids[1], newSubCategoryID };
            }

            return new string[] { };
        }

        public static bool IsNameNew(CreateMode createMode, string[] names)
        {
            switch(createMode)
            {
                case CreateMode.NewBranch:

                    return SqlConnector.ExQuery("SELECT MainCategoryID, MainCategoryName, CategoryID, CategoryName, SubCategoryID, SubCategoryName FROM CategoryTable WHERE MainCategoryName = @MainCategoryName",
                        new string[]
                        {
                            "@MainCategoryName"
                        },
                        new string[]
                        {
                            names[0]
                        },
                        new SqlDbType[]
                        {
                            SqlDbType.VarChar
                        }
                        ).Rows.Count == 0;

                case CreateMode.InMainCategory:

                    return SqlConnector.ExQuery("SELECT MainCategoryID, MainCategoryName, CategoryID, CategoryName, SubCategoryID, SubCategoryName FROM CategoryTable WHERE MainCategoryName = @MainCategoryName AND CategoryName = @CategoryName",
                        new string[]
                        {
                            "@MainCategoryName",
                            "@CategoryName"
                        },
                        new string[]
                        {
                            names[0],
                            names[1]
                        },
                        new SqlDbType[]
                        {
                            SqlDbType.VarChar,
                            SqlDbType.VarChar
                        }
                        ).Rows.Count == 0;
                case CreateMode.InCategory:

                    return SqlConnector.ExQuery("SELECT MainCategoryID, MainCategoryName, CategoryID, CategoryName, SubCategoryID, SubCategoryName FROM CategoryTable WHERE MainCategoryName = @MainCategoryName AND CategoryName = @CategoryName AND SubCategoryName = @SubCategoryName",
                        new string[]
                        {
                            "@MainCategoryName",
                            "@CategoryName",
                            "@SubCategoryName"
                        },
                        new string[]
                        {
                            names[0],
                            names[1],
                            names[2]
                        },
                        new SqlDbType[]
                        {
                            SqlDbType.VarChar,
                            SqlDbType.VarChar,
                            SqlDbType.VarChar
                        }
                        ).Rows.Count == 0;
            }

            return false;
        }

        public static bool IsNameNew(int id, string name)
        {
            if (id < 1000) return IsNameNew(CreateMode.NewBranch, new string[] { name });

            id /= 1000;

            return SqlConnector.ExQuery("SELECT MainCategoryID, MainCategoryName, CategoryID, CategoryName, SubCategoryID, SubCategoryName FROM CategoryTable WHERE (MainCategoryId = @Id AND CategoryName = @Name) OR (CategoryId = @Id AND SubCategoryName = @Name)",
                new string[]
                {
                    "@Id",
                    "@Name"
                },
                new string[]
                {
                    id.ToString(),
                    name
                },
                new SqlDbType[]
                {
                    SqlDbType.Int,
                    SqlDbType.VarChar
                }
                ).Rows.Count == 0;
        }

        public static string GetParentName(string id, CategoryType parentType)
        {
            string parentName = "";

            switch(parentType)
            {
                case CategoryType.MainCategory:
                    parentName = SqlConnector.ExQuery("SELECT MainCategoryName FROM CategoryTable WHERE MainCategoryId = @Id OR CategoryId = @Id OR SubCategoryId = @Id",
                        new string[]
                        {
                            "@Id"
                        },
                        new string[]
                        {
                            id
                        },
                        new SqlDbType[]
                        {
                            SqlDbType.Int
                        }
                        ).Rows[0][0].ToString();
                    break;
                case CategoryType.Category:
                    parentName = SqlConnector.ExQuery("SELECT CategoryName FROM CategoryTable WHERE MainCategoryId = @Id OR CategoryId = @Id OR SubCategoryId = @Id",
                        new string[]
                        {
                            "@Id"
                        },
                        new string[]
                        {
                            id
                        },
                        new SqlDbType[]
                        {
                            SqlDbType.Int
                        }
                        ).Rows[0][0].ToString();
                    break;
            }

            return parentName;
        }
    }
}
