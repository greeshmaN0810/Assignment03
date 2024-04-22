using Assignment03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Purchase()
        {
            return View();


        }
        public IActionResult Guide()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Review()
        {
            return View();
        }
       

        
        
    }
}