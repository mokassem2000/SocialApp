using api.DAL.context;
using api.DAL.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController :ControllerBase
    {
        public UsersController(DataContext Context)
        {
            _context = Context;
        }
        public DataContext _context { get; }
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var users = await _context.users.ToArrayAsync();
            return Ok(users);
        }
        [HttpGet("users/{id}")]
        public async Task<IActionResult> GetUserByID(int id)
        {
            var user =await _context.users.FindAsync(id);
            return Ok(user);
        }
    }
}
