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

    public class ServiceController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public ServiceController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Service> Services = await _db.Services.ToListAsync();
            return View(Services);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string[] imgsCropped, Service service)
        {

            if (imgsCropped.Length !=4)
            {
                ModelState.AddModelError("", "Zəhmət olmasa 4 şəkil seçin !");
                return View();
            }

            List<ServiceImage> serviceImages = new List<ServiceImage>();
            string folder = Path.Combine("src", "img", "courses");
            foreach (string imgCropped in imgsCropped)
            {
                ServiceImage serviceImage = new ServiceImage();
                serviceImage.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
                serviceImages.Add(serviceImage);
            }
            service.ServiceImages = serviceImages;
            await _db.Services.AddAsync(service);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return View("Error");
            Service service = await _db.Services.Include(x=>x.ServiceImages).Include(c=>c.ServiceDetail).FirstOrDefaultAsync(x => x.Id == id);
            if (service == null)
                return NotFound(service);
            List<string> serviceImages = new List<string>();
            string fullPath = Path.Combine(_env.WebRootPath, "src", "img", "courses");
            foreach (ServiceImage serviceImage in service.ServiceImages)
            {
                serviceImages.Add(Helper.GetFileForName(fullPath, serviceImage.Image));
            }
            ViewBag.OldImages = serviceImages;
            return View(service);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Service service, string[] imgsCropped)
        {
            if (id == null)
                return View("Error");
            Service dbService = await _db.Services.Include(x => x.ServiceImages).Include(c => c.ServiceDetail).FirstOrDefaultAsync(x => x.Id == id);
            if (dbService == null)
                return View("Error");
            if (imgsCropped.Length != 4)
            {
                ModelState.AddModelError("", "Zəhmət olmasa 4 şəkil seçin !");
                return View();
            }
            
            List<string> serviceImages = new List<string>();
            string fullPath = Path.Combine(_env.WebRootPath, "src", "img", "courses");
            foreach (ServiceImage serviceImage in dbService.ServiceImages)
            {
                serviceImages.Add(Helper.GetFileForName(fullPath, serviceImage.Image));
            }
            ViewBag.OldImages = serviceImages;
           
            
            string folder = Path.Combine("src", "img", "courses");
            string fullpathFile = "";
            foreach (ServiceImage oldImg in dbService.ServiceImages)
            {
                fullpathFile = Path.Combine(_env.WebRootPath, folder, oldImg.Image);
                Helper.DeleteImage(fullpathFile);
                fullpathFile = "";
            }
            List<ServiceImage> newServiceImages = new List<ServiceImage>();
            foreach (string imgCropped in imgsCropped)
            {
                ServiceImage serviceImage = new ServiceImage();
                serviceImage.Image = Helper.UploadImage(imgCropped, _env.WebRootPath, folder);
                newServiceImages.Add(serviceImage);
            }
            dbService.ServiceImages = newServiceImages;
            dbService.AzServiceName = service.AzServiceName;
            dbService.ServiceIcon = service.ServiceIcon;
            dbService.EnServiceName = service.EnServiceName;
            dbService.RuServiceName = service.RuServiceName;
            dbService.AzServiceDescription = service.AzServiceDescription;
            dbService.EnServiceDescription = service.EnServiceDescription;
            dbService.RuServiceDescription = service.RuServiceDescription;
            dbService.ServiceDetail.AzDescription = service.ServiceDetail.AzDescription;
            dbService.ServiceDetail.RuDescription = service.ServiceDetail.RuDescription;
            dbService.ServiceDetail.EnDescription = service.ServiceDetail.EnDescription;
            dbService.ServiceDetail.AzCertfDescription = service.ServiceDetail.AzCertfDescription;
            dbService.ServiceDetail.EnCertfDescription = service.ServiceDetail.EnCertfDescription;
            dbService.ServiceDetail.RuCertfDescription = service.ServiceDetail.RuCertfDescription;
            dbService.ServiceDetail.AzLessDescription = service.ServiceDetail.AzLessDescription;
            dbService.ServiceDetail.RuLessDescription = service.ServiceDetail.RuLessDescription;
            dbService.ServiceDetail.EnLessDescription = service.ServiceDetail.EnLessDescription;
            dbService.ServiceDetail.EnTagDescription = service.ServiceDetail.EnTagDescription;
            dbService.ServiceDetail.AzTagDescription = service.ServiceDetail.AzTagDescription;
            dbService.ServiceDetail.RuTagDescription = service.ServiceDetail.RuTagDescription;
            dbService.ServiceDetail.AzDateDescription = service.ServiceDetail.AzDateDescription;
            dbService.ServiceDetail.RuDateDescription = service.ServiceDetail.RuDateDescription;
            dbService.ServiceDetail.EnDateDescription = service.ServiceDetail.EnDateDescription;
            dbService.ServiceDetail.AzTimeDescription = service.ServiceDetail.AzTimeDescription;
            dbService.ServiceDetail.RuTimeDescription = service.ServiceDetail.RuTimeDescription;
            dbService.ServiceDetail.EnTimeDescription = service.ServiceDetail.EnTimeDescription;
            dbService.ServiceDetail.TagIcon = service.ServiceDetail.TagIcon;
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return View("Error");
            Service Service = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (Service == null)
                return View("Error");
            Service.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activate(int? id)
        {
            if (id == null)
                return View("Error");
            Service Service = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (Service == null)
                return View("Error");
            Service.IsDeactive = false;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
