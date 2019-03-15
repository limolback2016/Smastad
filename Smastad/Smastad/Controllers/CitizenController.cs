using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Smastad.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Smastad.Controllers
{
  public class CitizenController : Controller
  {
        // GET: /<controller>/
        public IActionResult validate()
        {
          return View();
        }

        // GET: /<controller>/
        public IActionResult thanks()
        {
          return View();
        }

        public IActionResult contact()
        {
          return View();
        }

  }
}
