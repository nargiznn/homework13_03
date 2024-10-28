using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hmwork_1.Data;
using Hmwork_1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hmwork_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            return View(new HomeVM
            {
                Sliders = await _context.Sliders.ToListAsync(),
                SliderLogos = await _context.SliderLogos.FirstOrDefaultAsync(),
                Courses = await _context.Courses.Include(m=>m.Images).Include(m=>m.Category).ToListAsync(),
                Categories = await _context.Categories.ToListAsync()

        });

        }
    }
}

