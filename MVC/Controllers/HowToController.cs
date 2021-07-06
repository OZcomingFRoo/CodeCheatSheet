using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HowToController : Controller
    {
        public HowToController()
        {

        }

        public IActionResult UseTypeScript()
        {
            return View();
        }

        public IActionResult UsejQueryPromise()
        {
            return View();
        }

        public IActionResult UseDependencyInjection()
        {
            return View();
        }
    }
}
