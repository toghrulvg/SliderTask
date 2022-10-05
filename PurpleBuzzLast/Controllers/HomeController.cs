using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PurpleBuzzLast.Data;
using PurpleBuzzLast.Models;
using PurpleBuzzLast.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PurpleBuzzLast.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        

        public HomeController(AppDbContext context)
        {
            _context = context;  
            
        }

        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                SliderImages = _context.SliderImages.ToList(),
                SliderSides=_context.SliderSides.ToList()
            };

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
