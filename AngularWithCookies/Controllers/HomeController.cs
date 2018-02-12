using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ESA.DAL.Almaty.Entities.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AngularWithCookies.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<User> signInManager;

        public HomeController(SignInManager<User> signInManager)
        {
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return Json(true);
            }
            return View();
        }

        public async Task<IActionResult> Auth()
        {
            try
            {
               
                var result = await signInManager.PasswordSignInAsync("960224350816", "ASD123qwe", false, false);
            }
            catch (Exception ex)
            {
                var z = 0;
            }
            return View("Index");
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
