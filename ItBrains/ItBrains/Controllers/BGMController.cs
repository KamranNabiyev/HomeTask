using ItBrains.Extentions;
using ItBrains.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Controllers
{
    public class BGMController : Controller
    {
        public IActionResult Index()
        {
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(SosialVM sosialVM, string courseName)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            var message = $"<p> Müraciət edən Şəxs : {sosialVM.FullName}</p></br> <p>Şəxsin Nömrəsi : {sosialVM.Mobile}</p></br>";
            await Helper.SendMessage("Seminar Qeydiyyat", message, "bgm@itbrains.edu.az");
            //await Helper.SendMessageWithFile("Sosial Qeydiyyat", message, "students@itbrains.az",sosialVM.Pdf);
            return RedirectToAction("Success", "Contact");
        }
    }
}
