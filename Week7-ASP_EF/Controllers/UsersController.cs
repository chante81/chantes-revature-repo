using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
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
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetUsers()
        {
            var users = _context.Users
                        .Select(u => new UserDTO
                        {
                            UserId = u.UserId,
                            Name = u.Name
                        }).ToList();
            return users;
        }
        
        [HttpGet("{UserId}")]
        public ActionResult<UserDTO> GetUserById(int UserId)
        {
            var user = _context.Users.Find(UserId);
            var userDto = new UserDTO
            {
                Name = user.Name,
                UserId = user.UserId
            };
            return userDto;
        }

        [HttpPost]
        public ActionResult<UserDTO> PostUser(UserDTO userDto)
        {
            var user = new User
            {
                Name = userDto.Name
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            // return Ok(userDto);
            return CreatedAtAction(nameof(GetUserById), new {UserId = user.UserId}, userDto);

        }

        [HttpPut("{UserId}")]
        public ActionResult<UserDTO> UpdateUser(int UserId, UserDTO UpdatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);

            user.Name = UpdatedUser.Name;

            _context.Users.Update(user);

            _context.SaveChanges();

            return Ok(UpdatedUser);
        }

        [HttpDelete]
        public IActionResult DeleteUser(int UserId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);
            _context.Users.Remove(user);
            _context.SaveChanges();

            return Ok();
        }

    }
}
