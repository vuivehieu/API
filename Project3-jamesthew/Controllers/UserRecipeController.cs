using Microsoft.AspNetCore.Mvc;

namespace Project3_jamesthew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRecipeController : ControllerBase
    {
        // GET
        public IActionResult Index()
        {
            return null;
        }
    }
}
