using ItBrains.DAL;
using ItBrains.Models;
using ItBrains.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ItBrains.Extentions.Helper;

namespace ItBrains.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager,
                                SignInManager<AppUser> signInManager,
                                RoleManager<IdentityRole> roleManager,
                                AppDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _db = db;
        }
        #region Login
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View("Error");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Email or password wrong!!!");
                return View();
            }

            if (user.IsDeleted)
            {
                ModelState.AddModelError("", "This account blocked!!!");
                return View();
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult =
                await _signInManager.PasswordSignInAsync(user, login.Password, true, true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Please,try few minutes later");
                return View(login);
            }

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password wrong!!!");
                return View();
            }


            return RedirectToAction("Index", "Home");
        }
        #endregion

        public async Task<IActionResult> MyRegister()
        {
            AppUser user = new AppUser
            {
                Name = "Aytaj",
                Surname = "Nesibova",
                Email = "aytaj.n@itbrains.edu.az",
                UserName= "aytaj.n@itbrains.edu.az",
            };
            await _userManager.CreateAsync(user, "AYtaj123qwe");
            await _userManager.AddToRoleAsync(user, "Admin");
            AppUser user2 = new AppUser
            {
                Name = "Aysel",
                Surname = "Huseynova",
                Email = "aysel.h@itbrains.edu.az",
                UserName = "aysel.h@itbrains.edu.az",
            };
            await _userManager.CreateAsync(user2, "AYsel123qwe");
            await _userManager.AddToRoleAsync(user2, "Admin");

            return RedirectToAction("Index");

        }

        #region Logout
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        #endregion


        #region CreateRoleManager

        public async Task CreateUserRole()
        {
            if (!(await _roleManager.RoleExistsAsync(Roles.Admin.ToString())))
                await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Admin.ToString() });
            if (!(await _roleManager.RoleExistsAsync(Roles.ConManager.ToString())))
                await _roleManager.CreateAsync(new IdentityRole { Name = Roles.ConManager.ToString() });
            if (!(await _roleManager.RoleExistsAsync(Roles.JrC.ToString())))
                await _roleManager.CreateAsync(new IdentityRole { Name = Roles.JrC.ToString() });
            if (!(await _roleManager.RoleExistsAsync(Roles.Teacher.ToString())))
                await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Teacher.ToString() });
        }
        #endregion
    }
}
