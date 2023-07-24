using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HelloworldController : Controller
    {
        public IActionResult Index()
        {
            dogviewmodel dog = new dogviewmodel()
            { Name = "django", Age = 20 };
            return View(dog);
        }
        public IActionResult Create()            
        {
            /*var dogo = new dogviewmodel();*/
            return View(/*doggo*/);
        }

        public IActionResult CreateDog(dogviewmodel dogviewmodel)
        {
            return View("index");
        }
        public string hello()
        {
            return "Whos there";
        }
    }
}
