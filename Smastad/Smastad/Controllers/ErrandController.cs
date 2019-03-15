using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Smastad.Models;

namespace Smastad.Controllers
{
    public class ErrandController : Controller
    {
        private FakeSmastadRepository repository;
        public ErrandController(FakeSmastadRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Errands);
    }
}