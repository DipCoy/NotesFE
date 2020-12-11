using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Security.Claims;
using System.Threading.Tasks;
using Application;
using Domain.Models;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace NotesFE.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        [Route("/login")]
        public IActionResult Login()
        {
            //Console.WriteLine("LoginGet");
            return View();
        }

        [HttpPost]
        [Route("/login")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            //Console.WriteLine("LoginPost");
            if (ModelState.IsValid)
            {
                User user;
                if (userService.TryGetUser(model.Login, out user) && user.Password == model.Password)
                {
                    await Authenticate(model.Login);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Incorrect");
            }

            return View(model);
        }
        
        [HttpGet]
        [Route("/register")]
        public IActionResult Register()
        {
            //Console.WriteLine("RegisterGet");
            return View();
        }
        
        [HttpPost]
        //[ValidateAntiForgeryToken]
        [Route("/register")]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            //Console.WriteLine("RegisterPost");
            if (ModelState.IsValid)
            {
                User user;
                if (!(userService.TryGetUser(model.Login, out user) && user.Password == model.Password))
                {
                    userService.TryAddUser(new User(){Login = model.Login, Password = model.Password});

                    await Authenticate(model.Login);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect");
                }
            }
            return View(model);
        }
 
        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
 
        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}