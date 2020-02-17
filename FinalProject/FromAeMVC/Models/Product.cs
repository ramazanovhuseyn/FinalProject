using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public string Discount { get; set; }
    //    public ICollection<ProductProperty> ProductProperties { get; set; }
    //    public ICollection<ProductCategory> ProductCategories { get; set; }
    //  public Model Model { get; set; }
        public int ModelId { get; set; }
    //  public ICollection<Rating> Ratings { get; set; }
    //  public ICollection<Comment> Comments { get; set; }
    }
}
