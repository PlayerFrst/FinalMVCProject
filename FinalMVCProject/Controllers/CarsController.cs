using Microsoft.AspNetCore.Mvc;

namespace FinalMVCProject.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
