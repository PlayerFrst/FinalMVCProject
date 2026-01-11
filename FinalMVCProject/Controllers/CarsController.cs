using FinalMVCProject.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinalMVCProject.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarService _carService;
        public CarsController(ICarService carService) 
        { 
            _carService = carService; 
        }

        public async Task<IActionResult> Index() 
        { 
            var cars = await _carService.GetAllAsync();
            return View(cars); 
        }
    }
}
