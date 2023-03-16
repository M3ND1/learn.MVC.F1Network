using F1Network.Models;
using System.Runtime.InteropServices;

namespace F1Network.Data.Services
{
    public class CarsService : ICarsService
    {
        private readonly AppDbContext _context;
        public CarsService(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Car> GetAll()
        {
            var cars = _context.Cars.ToList();
            return cars;
        }
    }
}
