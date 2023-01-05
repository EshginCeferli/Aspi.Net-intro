using EntityFrameworkProject.Data;
using EntityFrameworkProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderTextController : Controller
    {
        private AppDbContext _context;
        public SliderTextController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            SliderDetail sliderDetail = _context.SliderDetails.Where(m=>!m.IsDeleted).FirstOrDefault();
            return View(sliderDetail);
        }
    }
}
