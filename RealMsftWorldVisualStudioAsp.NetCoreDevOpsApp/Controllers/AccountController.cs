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

        public AccountController(SignInManager<UsersLogin> signInManager)
        {

            _signInManager = signInManager;
        }
        public AccountController(UserManager<UsersLogin> userManager)
        {

            _userManager = userManager;
        }

        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    
                        RedirectToAction("Forum", "Home");
                    

                }
            }
            ModelState.AddModelError("", "Failed to login");
            return View("Login");
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

      /*  [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new UsersLogin() { UserName = registerViewModel.UserName, Email= registerViewModel.Email1, LastName = registerViewModel.LastName, FirstName = registerViewModel.FirstName, PasswordHash= registerViewModel.Password};
               
                var result = await _userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    return View("ContactMessage");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View(registerViewModel);

        }*/
    }
}
