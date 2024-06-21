using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using EFCoreExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UsersController : ControllerBase
    {
        // This appdbContext is used to interact with our database
        // The constructor is used by our dependency manager to inject it into our clases
        // We do not have to initialize the controller or provide the abb db context into the constructor
        // this is managed for us by the dependency Injection Container  
        // private readonly AppDbContext _context;

        // public UsersController(AppDbContext context)
        // {
        //     _context = context;
        // }

        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{UserId}")]
        public ActionResult<UserDTO> GetUserById(int UserId)
        {
            var user = _userService.GetUserById(UserId);

            return user;
        }

        [HttpPost]
        public ActionResult<UserDTO> PostUser(UserDTO userDto)
        {
            var user = _userService.CreateUser(userDto);
            return CreatedAtAction(nameof(GetUserById), new { UserId = user.UserId }, userDto);

        }

        [HttpPut("{UserId}")]
        public ActionResult<UserDTO> UpdateUser(int UserId, UserDTO UpdatedUser)
        {
            _userService.UpdateUser(UserId, UpdatedUser);
            return Ok(UpdatedUser);
        }

        [HttpDelete]
        public IActionResult DeleteUser(int UserId)
        {
            _userService.DeleteUser(UserId);
            return Ok();
        }

    }
}
