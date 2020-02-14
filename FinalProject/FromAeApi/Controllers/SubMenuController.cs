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
    public class SubMenuController : ControllerBase
    {
        private readonly FromaeDbContext _context;
        public SubMenuController(FromaeDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<SubMenu>> GetMenus()
        {
            return await _context.SubMenus.ToListAsync();
        }
        [HttpPost]
        public async Task PostSubMenus(SubMenu subMenu)
        {
            await _context.SubMenus.AddAsync(subMenu);
            _context.SaveChanges();
        }
        [HttpPut("{id}")]
        public async Task PutSubMenus(SubMenu menu, int id)
        {
            var data = await _context.SubMenus.FindAsync(id);
            data.Name = menu.Name;
            data.Url = menu.Url;
            
            _context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public async Task DeleteSubMenus(int id)
        {
            var data = await _context.SubMenus.FindAsync(id);
            _context.Remove(data);
            _context.SaveChanges();
        }
    }
}