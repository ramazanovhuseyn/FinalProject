using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromAeApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FromAeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly FromaeDbContext _context;
        public ProductController(FromaeDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProduct()
        {
            return await _context.Products.ToListAsync();
        }
        [HttpPost]
        public async Task PostProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            _context.SaveChanges();
        }
        [HttpPut("{id}")]
        public async Task PutProduct(Product product, int id)
        {
            var data = await _context.Products.FindAsync(id);
            data.Name = product.Name;
            data.OldPrice = product.OldPrice;
            data.Discount = product.Discount;

            data.Price = product.Price;
            _context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public async Task DeleteProduct(int id)
        {
            var data = await _context.Products.FindAsync(id);
            _context.Remove(data);
            _context.SaveChanges();
        }
    }
}