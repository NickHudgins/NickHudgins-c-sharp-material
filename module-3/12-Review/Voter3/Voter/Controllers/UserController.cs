using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Voter.DAL.Interfaces;
using Voter.Models;

namespace Voter.Controllers
{   //inherits from home controller. All other controllers have access to the session info.
    //session is specifically a cotroller based function.
    public class UserController : HomeController
    {
        IUserDao userDao; //class level variable. Accessible by other methods.
        //constructor to use dependency injection.
        //remember: constructors do not get inherited.
        public UserController(IUserDao userDao)
        {
            this.userDao = userDao;
        }


        public IActionResult Register()
        {
            Register register = new Register();
            return View(register);
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            User user = userDao.SaveUser(register.UserName, register.Password, 0);

            if (user is null || user.Id <= 0)
            {   
                //TempData will hang onto the string and pass it to the next contoller action
                //ViewBag will not do this.
                TempData["ErrorMessage"] = "Unable to register user. Duplicate?";
                return RedirectToAction("Error", "Home");
            }

            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            Login login = new Login();
            return View(login);
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            bool OK = userDao.IsUsernameAndPasswordValid(login.UserName, login.Password);

            if (!OK)
            {
                return RedirectToAction("Login");
            }

            User user = userDao.GetUserByUserName(login.UserName);
            //base not needed as LogUserIn is unique.
            base.LogUserIn(user);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            base.LogUserOut();
            return RedirectToAction("Login", "User");
        }

        public IActionResult List()
        {
            //for admin only
            if (!base.IsAdmin)
            {
                TempData["ErrorMessage"] = "You're not important enough for that function.";
                return RedirectToAction("Error", "Home"); //action name/controller name.
            }                                             //can change rolls in SQL
            IList<User> users = userDao.GetAllUsers();

            return View(users);
        }
    }
}