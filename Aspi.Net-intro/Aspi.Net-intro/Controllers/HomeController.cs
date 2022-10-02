using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspi.Net_intro.Controllers
{
    public class HomeController:Controller
    {
        //public string Index(int id,string name)
        //{
        //    return "Home page" + " " + id + "" + name;
        //}
        public IActionResult Index()
        {
            return View();
        }

        //public string FullName(string name,string surname)
        //{
        //    return "Name" + name + "Surname" + surname;
        //}
    }
}
