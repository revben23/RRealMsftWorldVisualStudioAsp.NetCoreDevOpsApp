using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.ViewModels;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<UsersLogin> _userManager;
        private SignInManager<UsersLogin> _signInManager;

        //private SignInManager<UsersLogin> signInManager;
        //private readonly UserManager<IdentityUser> _userManager;


        /*  public IActionResult Register()
          {


              return View("Register");
          }*/

        public AccountController(SignInManager<UsersLogin> signInManager, UserManager<UsersLogin> userManager)
        {

            _signInManager = signInManager;

            _userManager = userManager;

        }

        public IActionResult Login(string returnUrl)
            {
                return View(new LoginViewModel
                {
                    ReturnUrl = returnUrl
                });

        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
                return View(loginViewModel);

            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);

                if (result.Succeeded)
                {

                    if (string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                        return RedirectToAction("Index", "Home");

                    return Redirect(loginViewModel.ReturnUrl);


                }
            }
            ModelState.AddModelError("", "Username/password not found");
            return View(loginViewModel);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new UsersLogin() { UserName = registerViewModel.UserName, Email = registerViewModel.Email1, LastName = registerViewModel.LastName, FirstName = registerViewModel.FirstName, PasswordHash = registerViewModel.Password };

                var result = await _userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(registerViewModel);

        }
    }
}
