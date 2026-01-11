using FinalMVCProject.Data;
using FinalMVCProject.Models;
using FinalMVCProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinalMVCProject.Services
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext _context; 
        public CarService(ApplicationDbContext context) 
        {
            _context = context; 
        }

        public async Task<IEnumerable<Car>> GetAllAsync() 
        { 
            return await _context.Cars.Include(c => c.Category)
                .Include(c => c.Manufacturer)
                .Include(c => c.Owner)
                .ToListAsync(); 
        }
        public async Task<Car> GetByIdAsync(int id) 
        { 
            return await _context.Cars
                .Include(c => c.Category)
                .Include(c => c.Manufacturer)
                .Include(c => c.Owner)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task CreateAsync(Car car) 
        { 
            _context.Cars.Add(car);
            await _context
                .SaveChangesAsync(); 
        }
        public async Task UpdateAsync(Car car) 
        { 
            _context.Cars.Update(car);
            await _context
                .SaveChangesAsync(); 
        }
        public async Task DeleteAsync(int id) 
        { 
            var car = await _context.Cars
                .FindAsync(id); 

            if (car != null) 
            { 
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync(); 
            } 
        }

        public async Task<IEnumerable<Car>> GetLatestAsync(int count) 
        { 
            return await _context.Cars
                .Include(c => c.Category)
                .Include(c => c.Manufacturer)
                .OrderByDescending(c => c.Id)
                .Take(count)
                .ToListAsync(); 
        }
    }
}
