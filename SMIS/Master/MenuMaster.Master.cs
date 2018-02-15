using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Store;
using System.Text;

namespace SMIS.Master
{
    public partial class MenuMaster : System.Web.UI.MasterPage
    {

        Store.BusinessObject.Menu objMenu = new Store.BusinessObject.Menu();
        Store.BusinessLogic.Menu oblMenu = new Store.BusinessLogic.Menu();
        protected void Page_Load(object sender, EventArgs e)
        {
            bindMenu();
        }
        void bindMenu()
        {
            List<Store.BusinessObject.Menu> objMenuList = new List<Store.BusinessObject.Menu>();
            objMenuList = oblMenu.getMenu();
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul ");
            sb.Append("id=" + "'tabmenu'>");
            var menu = objMenuList.Where(x => x.PId == 0);
            int count = 0;
            foreach (var m in menu)
            {
                sb.Append("<li>");
                if (count == 0)
                    sb.Append(m.Name);
                else
                    sb.Append("<a href='"+m.URL+"'>" + m.Name + "</a>");
                count++;
                var submenu = objMenuList.Where(x => x.PId == m.Id);
                if (submenu != null)
                {
                    sb.Append("<ul>");
                    foreach (var sm in submenu)
                    {
                        sb.Append("<li>");
                        sb.Append("<a href='" + sm.URL + "'>" + sm.Name + "</a>");
                        var submenu1 = objMenuList.Where(x => x.PId == sm.Id);
                        if (submenu1 != null)
                        {
                            sb.Append("<ul>");
                            foreach (var sm1 in submenu1)
                            {
                                sb.Append("<li>");
                                sb.Append("<a href='" + sm1.URL + "'>" + sm1.Name + "</a>");
                                sb.Append("</li>");
                            }
                            sb.Append("</ul>");

                        }
                        sb.Append("</li>");
                    }
                    sb.Append("</ul>");
                }
                sb.Append("</li>");
            }
            sb.Append("</ul>");
            divMenu.InnerHtml = sb.ToString();
            //Response.Write(sb.ToString());
        }

    }
}