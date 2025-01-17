﻿using LessonForum.EntityLayer.Entities;
using LessonForum.PresentationLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LessonForum.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;


        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            await _signInManager.SignOutAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, true, true);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(model.Username);
                    if (user.Status)
                    {
                        var roles = await _userManager.GetRolesAsync(user);
                        if (roles[0] == "Üye")
                        {
                            return Redirect("/Guest/Note/Index/");
                        }
                        return RedirectToAction("Index", "Category");
                    }
                    else
                    {
                        await _signInManager.SignOutAsync();
                        ModelState.AddModelError("", "Kullanıcı banlanmıştır..!");
                        return View();
                    }
                }
                else
                {
                    if (result.IsLockedOut)
                    {
                        ModelState.AddModelError("", "Çok fazla hatalı giriş nedeniyle hesap kilitlenmiştir. Daha sonra tekrar deneyin..!");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Kullanıcı bulunamadı..!");
                    }

                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    Email = model.Mail,
                    UserName = model.Username,
                    Status = true

                };

                var result = await _userManager.CreateAsync(appUser, model.Password);


                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(appUser.UserName);
                    await _userManager.AddToRoleAsync(user,"Üye");
                    user.RoleID = _roleManager.Roles.Where(x => x.Name == "Üye").FirstOrDefault().Id;
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View();
        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
