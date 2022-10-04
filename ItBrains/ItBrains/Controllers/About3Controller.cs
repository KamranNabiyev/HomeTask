using ItBrains.DAL;
using ItBrains.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Controllers
{
    public class About3Controller : Controller
    {
        private readonly AppDbContext _db;
        public About3Controller(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            About3 about = await _db.Abouts3.FirstOrDefaultAsync();
            return View(about);
        }
    }
}
