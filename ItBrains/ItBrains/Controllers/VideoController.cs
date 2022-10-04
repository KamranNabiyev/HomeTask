using ItBrains.DAL;
using ItBrains.Models;
using ItBrains.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Controllers
{
    public class VideoController : Controller
    {
        private readonly AppDbContext _db;
        public VideoController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index(int? videoLessonId)
        {
            if (videoLessonId == null)
            {
                return View("Error");
            }
            VideoLesson videoLesson = await _db.VideoLessons.Include(x=>x.Videos.Where(x => !x.IsDeactive)).FirstOrDefaultAsync(x => x.Id == videoLessonId);
            if (videoLesson == null)
            {
                return View("Error");
            }
            return View(videoLesson);
        }
    }
}
