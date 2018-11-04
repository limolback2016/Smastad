
using Microsoft.AspNetCore.Mvc;

namespace Smastad.Controllers
{
    public class InvestigatorController : Controller
    {
        // GET: /<controller>/
        public IActionResult investigator()
        {
            return View();
        }

        public IActionResult crimeInvestigator()
        {
          return View();
        }
  }
}
