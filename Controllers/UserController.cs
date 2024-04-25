using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using testLeenAuto.Shared;
using testLeenAUto.Entities;
using testLeenAUto.Services;

namespace testLeenAUto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(UserService userService) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = userService.getUsers();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            var createUser = userService.CreateUser(user);
            return Ok(createUser);
        }
    }

}
