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
    public class About1Controller : Controller
    {
        private readonly AppDbContext _db;
        public About1Controller(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            About1 about = await _db.Abouts1.FirstOrDefaultAsync();
            return View(about);
        }
    }
}
