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
    public class CategoryController : ControllerBase
    {
        private readonly FromaeDbContext _context;
        public CategoryController(FromaeDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategory()
        {
            return await _context.Categories.ToListAsync();
        }
        [HttpPost]
        public async Task PostCategory(Category category)
        {
            await _context.Categories.AddAsync(category);
            _context.SaveChanges();
        }
        [HttpPut("{id}")]
        public async Task PutCategories(Category category, int id)
        {
            var data = await _context.Categories.FindAsync(id);
            data.Name = category.Name;
            data.Url = category.Url;
            data.Image = category.Image;
            _context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public async Task DeleteCategory(int id)
        {
            var data = await _context.Categories.FindAsync(id);
            _context.Remove(data);
            _context.SaveChanges();
        }
    }
}