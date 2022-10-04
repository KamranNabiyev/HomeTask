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
    public class SuccessesController : Controller
    {
        private readonly AppDbContext _db;
        public SuccessesController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Success> successes = await _db.Successes.Where(x=> !x.IsDeactive).ToListAsync();
            return View(successes);
        }
    }
}
