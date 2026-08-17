using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
