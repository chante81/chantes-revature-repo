using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;

namespace EFCoreExample.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public User CreateUser(UserDTO userDTO)
        {
            var user = new User
            {
                Name = userDTO.Name
            };
                _context.Users.Add(user);
                _context.SaveChanges();

                return user;
        }

        public void DeleteUser(int UserId)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            var users = _context.Users
            .Select(u => new UserDTO
            {
                UserId = u.UserId,
                Name = u.Name
            }).ToList();
            return users;
        }

        public UserDTO GetUserById(int UserId)
        {
            var user = _context.Users.Find(UserId);
            var userDto = new UserDTO
            {
                Name = user.Name,
                UserId = user.UserId
            };
            return userDto;
        }

        public void UpdateUser(int UserId, UserDTO UpdatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == UserId);

            user.Name = UpdatedUser.Name;

            _context.Users.Update(user);

            _context.SaveChanges();         
        }
    }
}