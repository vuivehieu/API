using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Patterns;
using Project3_jamesthew.Entitites;
using Project3_jamesthew.Models;

namespace Project3_jamesthew.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserProfileController : ControllerBase
{
    private UserManager<UserEntity> _userManager;

    public UserProfileController(UserManager<UserEntity> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    [Authorize]
    //GET :/api/Profile
    public async Task<Object> GetUserProfile()
    {
        string userId = User.Claims.First(c => c.Type == "UserId").Value;
        var user = await _userManager.FindByIdAsync(userId);
        return Ok(new
        {
            user.Id,
            user.UserName,
            user.FullName,
            user.Email,
            user.PhoneNumber
        });
    }

    [HttpPut("{id}")]
    [Authorize]
    public async Task<Object> UpdateUserProfile(UserModel model, string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        user.FullName = model.FullName;
        user.Email = model.Email;
        user.PhoneNumber = model.PhoneNumber;
        return Ok(await _userManager.UpdateAsync(user));
    }
}