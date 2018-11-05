using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Smastad.Models;

namespace Smastad.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult faq()
    {
      return View();
    }

    public IActionResult service()
    {
      return View();
    }

    public IActionResult logIn()
    {
      return View();
    }
  }
}
