using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Project3_jamesthew.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.CSharp.RuntimeBinder;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminAppController : ControllerBase
    {
        private UserManager<UserEntity> _userMng;
        private SignInManager<UserEntity> _signInMng;
        private readonly ApplicationSettings _appSettings;
        public AdminAppController(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInMng,IOptions<ApplicationSettings> appSettings)
        {
            _userMng = userManager;
            _signInMng = signInMng;
            _appSettings = appSettings.Value;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterUser(UserViewModel model)
        {
            var user = new UserEntity()
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
                throw new RuntimeBinderException("Not found");
            }
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = await _userMng.FindByNameAsync(model.Username);
            SecurityTokenDescriptor tokenDescriptor = null;
            if (user != null && await _userMng.CheckPasswordAsync(user, model.Password))
            {
                if (model.Remember)
                {
                    tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("UserId",user.Id.ToString())
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JwtSecret)), SecurityAlgorithms.HmacSha256Signature)
                    };
                }
                else
                {
                    tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("UserId",user.Id.ToString())
                        }),
                        Expires = DateTime.UtcNow.AddDays(7),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JwtSecret)), SecurityAlgorithms.HmacSha256Signature)
                    };
                }
                
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new {token});
            }
            else
            {
                return BadRequest(new {message ="Username or password incorrect."});
            }
        }
    }
}
