using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RokanRaiders.Models;
using Microsoft.EntityFrameworkCore;
using RokanRaiders.Data;

namespace RokanRaiders.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Start()
        {
            //Returnera nästkommande event, sorterat efter datum
            return View(await _context.Event.OrderBy(x => x.Date).Take(1).ToListAsync());
        }

        public async Task<ActionResult> Events()
        {
            //Returnera alla event, sorterat efter datum
            return View(await _context.Event.OrderBy(x => x.Date).ToListAsync());
        }

        public async Task<ActionResult> Membership()
        {
            //Returnera nästkommande event, sorterat efter datum
            return View(await _context.Event.OrderBy(x => x.Date).Take(1).ToListAsync());
        }
    }
}
