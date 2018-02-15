using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.BusinessObject
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public int PId { get; set; }
    }
    class MenuList:List<Menu>
    { }
}
 