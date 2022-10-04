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
    public class VideoLessonsController : Controller
    {
        private readonly AppDbContext _db;
        public VideoLessonsController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<VideoLesson> videoLesson = await _db.VideoLessons.Where(x => !x.IsDeactive).ToListAsync();
            return View(videoLesson);
        }
    }
}
