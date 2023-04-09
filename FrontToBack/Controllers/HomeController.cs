
using FrontToBack.Data;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FrontToBack.Controllers
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
            IEnumerable<Slider> sliders = await _context.Sliders.Where(m => !m.SoftDelete).ToListAsync();

            IEnumerable<RecentWork> recentWorks = await _context.RecentWorks.Where(m => !m.SoftDelete).ToListAsync();

            SliderBackground sliderBackground = await _context.SliderBackgrounds.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            IEnumerable<Service> services = await _context.Services.Where(m=>  !m.SoftDelete).ToListAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                RecentWorks = recentWorks,
                SliderBackground = sliderBackground,
                Services = services
            };

            return View(model);
        }

        



    }
}