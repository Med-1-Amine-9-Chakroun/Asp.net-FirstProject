using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HelloworldController : Controller 
    {

        private static List<dogviewmodel> dogs = new List<dogviewmodel>();
        public IActionResult Index()
        {
            /*dogviewmodel dog = new dogviewmodel()
            { Name = "django", Age = 20 };
            return View(dog);*/
            return View(dogs);
        }
        public IActionResult Create()            
        {
            var dogo = new dogviewmodel();
            return View(dogo);
        }

        public IActionResult CreateDog(dogviewmodel dogviewmodel)
        {
            dogs.Add(dogviewmodel);
            //return View("index");
            return RedirectToAction(nameof(Index));
        }
        public string hello()
        {
            return "Whos there";
        }
    }
}
