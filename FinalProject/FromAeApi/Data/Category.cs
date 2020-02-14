using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeApi.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public SubMenu SubMenu { get; set; }
        public int SubMenuId { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
