using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeApp.Data;
using Microsoft.AspNetCore.Mvc;
using CoffeeApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoffeeApp.Controllers
{
    public class BrewsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public BrewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Brew
        public IActionResult Index()
        {
            var brews = _context.Brews.ToList();
            return View(brews);
        }
    }
}

