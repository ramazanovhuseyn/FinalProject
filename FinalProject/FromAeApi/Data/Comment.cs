using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeApi.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
