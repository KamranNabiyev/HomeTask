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
    public class CoursesController : Controller
    {
        private readonly AppDbContext _db;
        public CoursesController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            List<Service> services = await _db.Services.Where(x=> !x.IsDeactive).ToListAsync();
            return View(services);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return View("Error");
            Service service = await _db.Services.Include(x=>x.ServiceDetail).Include(x=>x.ServiceImages).FirstOrDefaultAsync(x=>x.Id==id);
            if(service==null)
                return View("Error");
            return View(service);
        }
        public async Task<IActionResult> Registration(int? id=1)
        {
            
            if (id == null)
                return View("Error");
            Service service = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (service == null)
                return View("Error");
            List<Service> services = await _db.Services.Where(x => !x.IsDeactive).ToListAsync();
            ViewBag.ServiceId = id;
            ViewBag.Services = services;
            RegistrationVM registration = new RegistrationVM
            {
                Services = services,
            };
            return View(registration);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegistrationVM registration, int? serId, int? id = 1)
        {
            if (id == null)
                return View("Error");
            Service service = await _db.Services.FirstOrDefaultAsync(x => x.Id == serId);
            if (service == null)
                return View("Error");
            List<Service> services = await _db.Services.Where(x => !x.IsDeactive).ToListAsync();
            ViewBag.ServiceId = id;
            ViewBag.Services = services;
            registration.Services = services;
            if (!ModelState.IsValid)
                return View(registration);
            var message = $"<p>Kursun Adı : {service.AzServiceName}</p></br> <p>Message : {registration.Message}</p></br><p> Nömrəsi : {registration.Phone}</p></br> <p> Kim tərəfindən : {registration.Name}</p></br> ";
            await Helper.SendMessage("Kursa Qeydiyyat", message, "qeydiyyat@itbrains.az");
            return RedirectToAction("Success", "Contact");

        }
        public IActionResult Student()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Student(RegistrationVM registration, string courseName)
        {
            if (!ModelState.IsValid)
                return View(registration);
            var message = $"<p>Kursun Adı : {registration.Services}</p></br> <p>Message : {registration.Message}</p></br><p> Nömrəsi : {registration.Phone}</p></br> <p> Kim tərəfindən : {registration.Name}</p></br> ";
            await Helper.SendMessage("Kursa Qeydiyyat", message, "qeydiyyat@itbrains.az");
            //await Helper.SendMessageWithFile("Sosial Qeydiyyat", message, "students@itbrains.az",sosialVM.Pdf);
            return RedirectToAction("Success", "Contact");
        }
    }
}
