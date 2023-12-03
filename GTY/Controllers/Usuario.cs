using Microsoft.AspNetCore.Mvc;

namespace GTY.Controllers
{
    public class Usuario : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
