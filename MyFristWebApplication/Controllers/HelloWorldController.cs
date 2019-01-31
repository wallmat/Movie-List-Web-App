using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFristWebApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        /// <summary>
        /// GET: MyFirstWebApplication/Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET: /MyFirstWebApplication/Welcome
        /// </summary>
        /// <returns></returns>
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}