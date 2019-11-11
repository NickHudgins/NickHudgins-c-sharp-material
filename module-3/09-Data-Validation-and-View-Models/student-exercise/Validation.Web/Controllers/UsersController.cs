using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validation.Web.Models;

//Could not figure out how to get the buttons to display on the landing page. Going to submit assignment for now and 
//correct the code after I get some help. Will resubmit after I get it where I want it.
namespace Validation.Web.Controllers
{
    public class UsersController : Controller
    {
        // GET: User
        public IActionResult Index()
        {
            return View("Index");
        }

        // GET: User/Register
        // Return the empty registration view
        public IActionResult Register()
        {
            RegistrationViewModel register = new RegistrationViewModel();
            return View(register);
        }

        [HttpPost]
        public IActionResult Register(RegistrationViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            else
            {
                return RedirectToAction("Register");
            }
        }

        public IActionResult Login()
        {
            LoginViewModel login = new LoginViewModel();
            return View(login);
        }

        public IActionResult Login (LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }


        // POST: User/Register
        // Validate the model and redirect to confirmation (if successful) or return the 
        // registration view (if validation fails)        

        // GET: User/Login
        // Return the empty login view

        // POST: User/Login  
        // Validate the model and redirect to login (if successful) or return the 
        // login view (if validation fails)

        // GET: User/Confirmation
        // Return the confirmation view

    }
}