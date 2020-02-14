using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeApi.Data
{
    public class Rating
    {
        public int Id { get; set; }
        public byte Count { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
