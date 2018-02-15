using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Store.Common;
using Store.DatabaseHelper.Database.Common;
using System.Data;
using Store.DatabaseHelper.Database.DatabaseHelper;

namespace Store.DataAccessLayer
{
    public class Menu
    {
        public List<Store.BusinessObject.Menu> getMenu()
        {
            Store.BusinessObject.Menu objMenu = new BusinessObject.Menu();
            List<Store.BusinessObject.Menu> objMenuList = new List<BusinessObject.Menu>();
            string SQL = string.Empty;
            DataTableReader dr;
            try
            {
                SQL = "proc_Menu";
                dr = ExecuteQuery.ExecuteReader(SQL);
                while (dr.Read())
                {
                    objMenu = new BusinessObject.Menu();
                    if (dr.IsDBNull(dr.GetOrdinal("Id")) == false)
                    {
                        objMenu.Id = dr.GetInt32(dr.GetOrdinal("Id"));
                    }
                    if (dr.IsDBNull(dr.GetOrdinal("Name")) == false)
                    {
                        objMenu.Name = dr.GetString(dr.GetOrdinal("Name"));
                    }

                    if (dr.IsDBNull(dr.GetOrdinal("URL")) == false)
                    {
                        objMenu.URL = dr.GetString(dr.GetOrdinal("URL"));
                    }

                    if (dr.IsDBNull(dr.GetOrdinal("PId")) == false)
                    {
                        objMenu.PId = dr.GetInt32(dr.GetOrdinal("PId"));
                    }

                    objMenuList.Add(objMenu);
                }
                dr.Close();
                
            }
            catch (Exception ex)
            {
                Store.Common.Utility.ExceptionLog.Exceptionlogs(ex.Message, Store.Common.Utility.ExceptionLog.LineNumber(ex), typeof(Menu).FullName, 1);
            }
            return objMenuList;
        }
    }
}