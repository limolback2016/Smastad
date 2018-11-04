using Microsoft.AspNetCore.Mvc;

namespace Smastad.Controllers
{
  public class ManagerController : Controller
  {
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
