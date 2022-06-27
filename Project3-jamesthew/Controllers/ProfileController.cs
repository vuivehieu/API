using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Models;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private UserManager<UserEntity> _userMng;
        public ProfileController(UserManager<UserEntity> userMng)
        {
            _userMng = userMng;
        }
        [HttpGet]
        [Authorize]
        public async Task<Object> GetUserProfile()
        {
            string userId = User.Claims.First(c => c.Type == "UserId").Value;
            var user = await _userMng.FindByIdAsync(userId);
            return new
            {
                user.FullName,
                user.Email,
                user.UserName
            };
        }
        [NonAction]
        public async Task<UserEntity> getCurrentUser()
        {
            String userId = User.Claims.First(c => c.Type == "User").Value;
            return await _userMng.FindByIdAsync(userId);
        }
    }
}
