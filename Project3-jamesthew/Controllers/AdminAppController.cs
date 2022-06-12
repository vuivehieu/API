using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Project3_jamesthew.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminAppController : ControllerBase
    {
        private UserManager<User> _userMng;
        private SignInManager<User> _signInMng;
        private readonly ApplicationSettings _appSettings;
        public AdminAppController(UserManager<User> userManager, SignInManager<User> signInMng,IOptions<ApplicationSettings> appSettings)
        {
            _userMng = userManager;
            _signInMng = signInMng;
            _appSettings = appSettings.Value;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterUser(UserViewModel model)
        {
            var user = new User()
            {
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName,
            };
            try
            {
                var result = await _userMng.CreateAsync(user, model.Password);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = await _userMng.FindByNameAsync(model.UserName);
            if(user != null && await _userMng.CheckPasswordAsync(user, model.Password))
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserId",user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.Jwt_Secret)), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var sercurityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(sercurityToken);
                return Ok(new {token});
            }
            else
            {
                return BadRequest(new {message ="Usename or password incorrect."});
            }
        }
    }
}
