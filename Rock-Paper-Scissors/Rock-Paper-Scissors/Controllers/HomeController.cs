using Microsoft.AspNetCore.Mvc;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rock_Paper.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Instructions()
        {
            // Logic for displaying instructions goes here
            return View();
        }
    }
}