using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CircusTreinView.Models;
using Logic;
using Logic.LogicInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace CircusTreinView.Controllers
{
    public class AccountController : Controller
    {

        private IAccountDataHandler _accountManager;

        public AccountController(IAccountDataHandler accountManager)
        {
            _accountManager = accountManager;
        }

        
        [AllowAnonymous]
        [Route("register")]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("register")]
        public IActionResult Submit(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return Register();
            PasswordHasher<RegisterViewModel> passwordHasher = new PasswordHasher<RegisterViewModel>();
            string hasherPassword = passwordHasher.HashPassword(new RegisterViewModel(), model.Password);
            
            _accountManager.CreateAccount(model.Username, hasherPassword, model.Email);

            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        [Route("login")]
        public ViewResult Login()
        {
            return View();
        }

        //[HttpPost]
        //[AllowAnonymous]
        //[Route("login")]
        //public IActionResult LoginAction(LogInModel model)
        //{
        //    if (!ModelState.IsValid) return Login();

        //    var user = _accountManager.GetAccountByEmail(model.Email);


        //    return RedirectToAction("ShowAnimals", "AnimalModel");
        //}
    }

}