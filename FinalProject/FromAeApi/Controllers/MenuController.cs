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
    public class MenuController : ControllerBase
    {
        private readonly FromaeDbContext _context;
        public MenuController(FromaeDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<Menu>> GetMenus()
        {
            return await _context.Menus.ToListAsync();
        }
        [HttpPost]
        public async Task PostMenus(Menu menu)
        {
           await _context.Menus.AddAsync(menu);
            _context.SaveChanges();
        }
        [HttpPut("{id}")]
        public async Task PutMenus(Menu menu, int id)
        {
            var data =await _context.Menus.FindAsync(id);
            data.Name = menu.Name;
            data.Url = menu.Url;
            _context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public async Task DeleteMenus(int id)
        {
            var data =await _context.Menus.FindAsync(id);
            _context.Remove(data);
            _context.SaveChanges();
        }
        
    }
}