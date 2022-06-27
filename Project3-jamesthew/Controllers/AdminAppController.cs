using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Project3_jamesthew.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Project3_jamesthew.Entitites;

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
        public async Task<IActionResult> RegisterUser(UserModel model)
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
                throw ex;
            }
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = await _userMng.FindByNameAsync(model.UserName);
            int days = 0;
            if (model.RememberMe)
            {
                days = 7;
            }
            else
            {
                days = 1;
            }
            if(user != null && await _userMng.CheckPasswordAsync(user, model.Password))
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserId",user.Id.ToString()),
                        new Claim("UserName",user.UserName.ToString()),
                        new Claim("UserEntity",user.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(days),
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
