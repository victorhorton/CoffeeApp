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

        // GET: Brews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brews/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Brew brew)
        {
            if (ModelState.IsValid)
            {
                // Add the new brew to the database
                _context.Brews.Add(brew);
                _context.SaveChanges();

                return RedirectToAction("Index"); // Redirect to the index action after successful creation
            }

            return View(brew); // If ModelState is not valid, return to the create view with validation errors
        }
    }
}

