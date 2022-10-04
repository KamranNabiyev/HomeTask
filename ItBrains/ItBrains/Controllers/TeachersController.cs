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
   
    public class TeachersController : Controller
    {
        private readonly AppDbContext _db;
        public TeachersController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            List<Teacher> teachers = await _db.Teachers.Where(x=> !x.IsDeactive).ToListAsync();
            return View(teachers);
        }
    }
}
