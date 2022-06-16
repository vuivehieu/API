using Microsoft.AspNetCore.Mvc;

namespace Project3_jamesthew.Controllers
{
    public class TipsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
