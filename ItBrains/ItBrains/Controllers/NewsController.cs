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
    public class NewsController : Controller
    {
        private readonly AppDbContext _db;
        public NewsController(AppDbContext db)
        {
            _db=db;
        }
        public async Task<IActionResult> Index()
        {
            List<News> news = await _db.News.Where(x => !x.IsDeactive).ToListAsync();
            return View(news);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return View("Error");
            News news = await _db.News.FirstOrDefaultAsync(x=>x.Id==id);
            if (news == null)
                return View("Error");
            return View(news);
        }
    }
}
