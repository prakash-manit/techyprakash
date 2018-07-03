using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace techyprakash.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Resource()
        {
            ViewData["Message"] = "Your Resource page.";

            return View();
        }

        public IActionResult Post()
        {
            ViewData["Message"] = "Your Post page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
