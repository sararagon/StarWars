using Microsoft.AspNetCore.Mvc;

namespace StarWarsApi.Controllers
{
    public class CitizenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}