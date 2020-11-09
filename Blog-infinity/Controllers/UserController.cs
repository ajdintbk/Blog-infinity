using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_infinity_dal.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Blog_infinity.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userRepository.GetUsers();
            return Ok(users);
        }

        public async Task<IActionResult> Search([FromQuery] string search)
        {
            var users = await _userRepository.Search(search);
            return Ok(users);
        }

        public async Task<IActionResult> Details([FromQuery] int userId)
        {
            var users = await _userRepository.Details(userId);
            return Ok(users);
        }
    }
}
