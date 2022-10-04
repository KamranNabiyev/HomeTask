
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

    public class PersonesController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public PersonesController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Persone> famous = await _db.Persones.ToListAsync();
            return View(famous);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Persone famous)
        {
            
            await _db.Persones.AddAsync(famous);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return View("Error");
            Persone famous = await _db.Persones.FirstOrDefaultAsync(x => x.Id == id);
            if (famous == null)
                return NotFound();
            famous.IsView = true;
            await _db.SaveChangesAsync();
            return View(famous);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return View("Error");
            Persone famous = await _db.Persones.FirstOrDefaultAsync(x => x.Id == id);
            if (famous == null)
                return NotFound();
            return View(famous);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Persone famous)
        {
            if (id == null)
                return View("Error");
            Persone dbfamous = await _db.Persones.FirstOrDefaultAsync(x => x.Id == id);
            if (dbfamous == null)
                return NotFound();

           
            dbfamous.FullName = famous.FullName;

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Reset()
        {

            List<Persone> persones = await _db.Persones.ToListAsync();
            foreach (var item in persones)
            {
                item.IsView = false;
            }

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activate(int? id)
        {
            if (id == null)
                return View("Error");
            Persone dbfamous = await _db.Persones.FirstOrDefaultAsync(x => x.Id == id);
            if (dbfamous == null)
                return NotFound();
            dbfamous.IsView = false;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
