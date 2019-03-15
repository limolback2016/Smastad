using Microsoft.AspNetCore.Mvc;
using Smastad.Models;

namespace Smastad.Controllers
{
  public class ManagerController : Controller
  {
        private ISmastadRepository repository;

        public ManagerController(ISmastadRepository repo)
        {
            repository = repo;
        }

        

        // GET: /<controller>/
        public IActionResult manager() // Should be named start instead of manager
        {
          return View();
        }

        public IActionResult crimeManager()
        {
          return View();
        }

  }
}
