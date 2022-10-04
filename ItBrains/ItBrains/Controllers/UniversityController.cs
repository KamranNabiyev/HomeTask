using ItBrains.DAL;
using ItBrains.Extentions;
using ItBrains.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Controllers
{
   
    public class UniversityController : Controller
    {
        private readonly AppDbContext _db;
        public UniversityController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> StudentAsync()
        {
            ViewBag.Services = await _db.Services.ToListAsync();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Student(SosialVM sosialVM,string courseName)
        {
            ViewBag.Services = await _db.Services.ToListAsync();
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            var message = $"<p> Müraciət edən Şəxs : {sosialVM.FullName}</p></br> <p>Şəxsin Nömrəsi : {sosialVM.Mobile}</p></br><p>Kursun Adı : {courseName}</p></br>";
            await Helper.SendMessage("Sosial Qeydiyyat", message, "sosial@itbrains.az");
            //await Helper.SendMessageWithFile("Sosial Qeydiyyat", message, "students@itbrains.az",sosialVM.Pdf);
            return RedirectToAction("Success", "Contact");
        }
    }
}
