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
    public class GalleryController : Controller
    {
        private readonly AppDbContext _db;
        public GalleryController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Gallery> galleries = await _db.Galleries.Where(x => !x.IsDeactive).ToListAsync();
            return View(galleries);
        }
    }
}
