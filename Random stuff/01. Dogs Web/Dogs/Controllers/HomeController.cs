using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dogs.Models;
using Dogs.Services;

namespace Dogs.Controllers
{
    public class HomeController : Controller
    {
        private DogsService dogsService;

        public HomeController(DogsService service)
        {
            this.dogsService = service;
        }

        public IActionResult Index()
        {
            var allDogs = this.dogsService.GetAllDogs();
            var model = new HomeViewModel(allDogs);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
