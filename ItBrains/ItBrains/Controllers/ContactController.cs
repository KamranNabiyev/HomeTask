using ItBrains.DAL;
using ItBrains.Extentions;
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
    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            Bio bio = await _db.Bios.FirstOrDefaultAsync();
            ContactVM contactVM = new ContactVM
            {
                Email = "",
                Name = "",
                Message = "",
                Subject = "",
                ContectEmail = bio.Email,
                ContectNumber = bio.Mobile,

            };
           
            return View(contactVM);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactVM contactVM)
        {
            Bio bio = await _db.Bios.FirstOrDefaultAsync();
            ContactVM dbContactVM = new ContactVM
            {
                Email = "",
                Name = "",
                Message = "",
                Subject = "",
                ContectEmail = bio.Email,
                ContectNumber = bio.Mobile,

            };
            
            //if (ModelState.IsValid)
            //{
            //    return View(dbContactVM);
            //}
            var remoteIpAddress = HttpContext.Connection.RemoteIpAddress;
            var message = $"<p>Subject : {contactVM.Subject}</p></br> <p>Message : {contactVM.Message}</p></br> <p> By : {contactVM.Email}</p></br> <p> IpAdress : {remoteIpAddress}</p>";
            await Helper.SendMessage("Bizimlə Əlaqə", message, "info@itbrains.edu.az");
            return RedirectToAction("Success", "Contact");

        }
        public IActionResult Success()
        {
            return View();
        }
    }
}
