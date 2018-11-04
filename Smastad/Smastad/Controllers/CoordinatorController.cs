using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Smastad.Controllers
{
  public class CoordinatorController : Controller
  {
    public IActionResult coordinator()
    {
      return View();
    }

    public IActionResult crimeCoordinator()
    {
      return View();
    }

    public IActionResult reportCrime()
    {
      return View();
    }

    public IActionResult thanks()
    {
      return View();
    }

    public IActionResult validate()
    {
      return View();
    }
  }
}
