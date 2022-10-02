using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspi.Net_intro.Controllers
{
    public class AboutController:Controller
    {
        //public string Index()
        //{
        //    return "About page";
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}
