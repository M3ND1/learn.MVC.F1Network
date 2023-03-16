using F1Network.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace F1Network.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsService _service;
        public CarsController(ICarsService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var carsData = _service.GetAll();
            return View(carsData);
        }
    }
}
