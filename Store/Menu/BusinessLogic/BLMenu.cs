using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Store.Common;

namespace Store.BusinessLogic
{
    public class Menu
    {
        Store.DataAccessLayer.Menu odlMenu = new DataAccessLayer.Menu();
        public List<Store.BusinessObject.Menu> getMenu()
        {
            return odlMenu.getMenu();
        }
    }
}