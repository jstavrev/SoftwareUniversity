using Dogs.Data.DBModels;
using Dogs.Models;
using Dogs.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dogs.Controllers
{
    public class DogsController : Controller
    {
        private DogsService dogsService;

        public DogsController(DogsService service)
        {
            this.dogsService = service;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DogsViewModel newDog)
        {
            var dog = new Dog()
            {
                Age = newDog.Age,
                Name = newDog.Name,
                Breed = newDog.Breed,
                ImageURL = newDog.ImageURL
            };
            this.dogsService.AddDog(dog);
            return RedirectToAction("", "");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var dog = this.dogsService.GetDog(id);

            var viewDog = new DogsViewModel(dog);
            return View(viewDog);
        }
    }
}
