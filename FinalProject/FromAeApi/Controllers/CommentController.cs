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
    public class CommentController : ControllerBase
    {
        private readonly FromaeDbContext _context;
        public CommentController(FromaeDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<Comment>> GetComment()
        {
            return await _context.Comments.ToListAsync();
        }
        [HttpPost]
        public async Task PostComment(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            _context.SaveChanges();
        }
        [HttpPut("{id}")]
        public async Task PutComments(Comment comment, int id)
        {
            var data = await _context.Comments.FindAsync(id);
            data.Message = comment.Message;
            data.UserName = comment.UserName;
            _context.SaveChanges();
        }
        [HttpDelete("{id}")]
        public async Task DeleteComment(int id)
        {
            var data = await _context.Comments.FindAsync(id);
            _context.Remove(data);
            _context.SaveChanges();
        }
    }
}