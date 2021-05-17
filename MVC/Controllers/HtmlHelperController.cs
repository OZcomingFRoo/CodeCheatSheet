using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HtmlHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HowToUse()
        {
            return View(new HowToUseModel());
        }
    }
}
