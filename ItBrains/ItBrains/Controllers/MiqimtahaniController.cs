using ItBrains.DAL;
using ItBrains.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItBrains.Controllers
{
    public class MiqimtahaniController : Controller
    {
        private readonly AppDbContext _db;
        public MiqimtahaniController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            Miq miq = _db.Miqs.FirstOrDefault();
            return View(miq);
        }
    }
}
