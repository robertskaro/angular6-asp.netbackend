using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private static readonly string rootViewPath = "~/wwwroot/Index.cshtml";
        public IActionResult Index()
        {
            AppendHeaderValues("home");
            return View(rootViewPath);
        }

        [Route("some/dude")]
        public IActionResult somedude()
        {
            AppendHeaderValues("someDude");
            return View(rootViewPath);
        }


        private void AppendHeaderValues(string value)
        {
            //*if user agent == facebook
            ViewBag.SomeCrazyHeader = value;
        }
    }
}
