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

    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Bio> bios = await _db.Bios.ToListAsync();
            return View(bios);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Bio bio)
        {

           
            await _db.Bios.AddAsync(bio);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return View("Error");
            Bio Bio = await _db.Bios.FirstOrDefaultAsync(x => x.Id == id);
            if (Bio == null)
                return View("Error");
            return View(Bio);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Bio Bio)
        {
            if (id == null)
                return View("Error");
            Bio dbBio = await _db.Bios.FirstOrDefaultAsync(x => x.Id == id);
            if (dbBio == null)
                return View("Error");

          
            dbBio.Facebook = Bio.Facebook;
            dbBio.Instagram = Bio.Instagram;
            dbBio.Telegram = Bio.Telegram;
            dbBio.Email = Bio.Email;
            dbBio.Linkedin = Bio.Linkedin;
            dbBio.Mobile = Bio.Mobile;
            dbBio.Youtube = Bio.Youtube;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        
    }
}
