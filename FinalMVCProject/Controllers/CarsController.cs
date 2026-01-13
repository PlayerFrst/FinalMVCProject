using FinalMVCProject.Models;
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

        [HttpGet]
        public async Task<IActionResult> Create() 
        { 
            var model = new CarCreateViewModel 
            { 
                Categories = await _carService.GetCategoriesAsync()
            }; 
            return View(model); 
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarCreateViewModel model)
        { 
            if (!ModelState.IsValid) 
            {
                model.Categories = await _carService.GetCategoriesAsync();
                return View(model); 
            } 

            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            var car = new Car 
            { 
                Brand = model.Brand,
                Model = model.Model,
                Year = model.Year,
                CategoryId = model.CategoryId,
                OwnerId = userId 
            }; 
            
            await _carService.CreateAsync(car);
            return RedirectToAction(nameof(Index)); 
        }
    }
}
