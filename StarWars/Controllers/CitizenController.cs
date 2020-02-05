using Microsoft.AspNetCore.Mvc;
using StarWarsServices.Repositories;

namespace StarWarsApi.Controllers
{
    public class CitizenController : Controller
    {

        private readonly IRepository _repository;

        public CitizenController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}