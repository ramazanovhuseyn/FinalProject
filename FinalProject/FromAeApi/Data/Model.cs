using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeApi.Data
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Marka Marka { get; set; }
        public int MarkaId { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
