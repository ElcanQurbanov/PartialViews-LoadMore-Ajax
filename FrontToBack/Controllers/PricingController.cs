using FrontToBack.Data;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            

            return View();
        }
    }
}
