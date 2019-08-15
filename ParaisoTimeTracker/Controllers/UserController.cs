using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParaisoTimeTracker.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParaisoTimeTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserContext _userContext;
        public UserController(UserContext userContext)
        {
            _userContext = userContext;

            if (_userContext.UserItems.Count() == 0)
            {
                _userContext.UserItems.Add(new UserItem { Id = 1, Name = "Super Admin" });
            }
        }

        // GET api/user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserItem>>> GetUsers()
        {
            return await _userContext.UserItems.ToListAsync();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserItem>> GetUser(long id)
        {
            var userItem = await _userContext.UserItems.FindAsync(id);

            if (userItem == null)
            {
                return NotFound();
            }

            return userItem;
        }

    }
}
