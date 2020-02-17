using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeMVC.Models
{
    public class SubMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Menu Menu { get; set; }
        public int MenuId { get; set; }

      //  public ICollection<Category> Categories { get; set; }
    }
}
