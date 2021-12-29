using System;
using System.Threading.Tasks;
using Identity_Security.Models;
using Microsoft.AspNetCore.Mvc;

namespace Identity_Security.Controllers
{
    public class IdentityController : Controller
    {
        public async Task<IActionResult> Signup()
        {
            var model = new SignupViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Signup(SignupViewModel model)
        {
            return View(model);
        }

        public async Task<IActionResult> SignIn()
        {
            return View();
        }

        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }
    }
}