using EFCoreExample.Data;
using EFCoreExample.DTOs;
using EFCoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProfilesController : ControllerBase
    {
        // This appdbContext is used to interact with our database
        // The constructor is used by our dependency manager to inject it into our clases
        // We do not have to initialize the controller or provide the abb db context into the constructor
        // this is managed for us by the dependency Injection Container  
        private readonly AppDbContext _context;

        public ProfilesController(AppDbContext context)
        {
            _context = context;
        }
                [HttpGet]
        public ActionResult<IEnumerable<ProfileDTO>> GetProfiles()
        {
            var profiles = _context.Profiles
                .Include(p => p.User)
                .Select(p => new ProfileDTO
                {
                    Bio = p.Bio,
                    UserId = p.User.UserId
                }).ToList();

            return profiles;
        }

        [HttpGet("{UserId}")]
        public ActionResult<ProfileDTO> GetProfileByUserId(int UserId)
        {
            var profile =  _context.Profiles.Find(UserId);
            var profileDto = new ProfileDTO
            {
                Bio = profile.Bio,
                UserId = profile.UserId
            };
            return profileDto;
        }



        [HttpPost]
        public ActionResult<ProfileDTO> PostProfile(ProfileDTO profileDto)
        {

            var user = _context.Users.Find(profileDto.UserId);
            var NewProfile = new Profile
            {
                Bio = profileDto.Bio,
                UserId = profileDto.UserId,
                User = user
            };

            _context.Profiles.Add(NewProfile);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetProfiles), new { ProfileId = NewProfile.ProfileId }, profileDto);
        }

        [HttpPut]
        public ActionResult<ProfileDTO> UpdateProfile(int UserId, ProfileDTO UpdatedProfile)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.UserId == UserId);
            profile.Bio = UpdatedProfile.Bio;

            _context.Profiles.Update(profile);
            _context.SaveChanges();

            return Ok(UpdatedProfile);
        }

        [HttpDelete]
        public IActionResult DeleteProfile(int UserId)
        {
            var profile = _context.Profiles.FirstOrDefault(p => p.UserId == UserId);
            _context.Profiles.Remove(profile);
            _context.SaveChanges();

            return Ok();

        }
    }
}
