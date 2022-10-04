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
    public class About2Controller : Controller
    {
        private readonly AppDbContext _db;
        public About2Controller(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            About2 about = await _db.Abouts2.FirstOrDefaultAsync();
            return View(about);
        }
    }
}
