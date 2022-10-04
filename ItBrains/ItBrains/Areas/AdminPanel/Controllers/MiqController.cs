


using ItBrains.DAL;
using ItBrains.Extentions;
using ItBrains.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize]

    public class MiqController : Controller
    {
        private readonly AppDbContext _db;
        public MiqController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Miq> successes = await _db.Miqs.ToListAsync();
            return View(successes);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return View("Error");
            Miq success = await _db.Miqs.FirstOrDefaultAsync(x => x.Id == id);
            if (success == null)
                return NotFound();
            return View(success);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Miq success)
        {
            if (id == null)
                return View("Error");
            Miq dbSuccess = await _db.Miqs.FirstOrDefaultAsync(x => x.Id == id);
            if (dbSuccess == null)
                return NotFound();



            dbSuccess.Link = success.Link;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
