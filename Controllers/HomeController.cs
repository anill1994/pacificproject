using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PacificProject.Models;
using PacificProject.ViewModel;

namespace PacificProject.Controllers
{
    public class HomeController : Controller
    {
        private PacificContext _context;
        public HomeController(PacificContext context)
        {
            _context = context;
        }
        HomePageViewModel homepage = new HomePageViewModel();

        public IActionResult Index()
        {
            homepage.Blogs = _context.Blogs.ToList();
            homepage.Comments = _context.Comments.ToList();
            homepage.Destinations = _context.Destinations.ToList();
            return View(homepage);
        }
    }
}