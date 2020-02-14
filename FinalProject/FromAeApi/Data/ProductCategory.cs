﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeApi.Data
{
    public class ProductCategory
    {
        public Product Product { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}
