﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {
        public string connectionString = "Data Source=.\\sqlexpress;Initial Catalog = squirrels; Integrated Security = True";

        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }        

        [HttpPost]
        public IActionResult AddReview(Review review)
        {
            ReviewSqlDAO dao = new ReviewSqlDAO(connectionString);
            dao.SaveReview(review);
            return RedirectToAction("GetAllReviews");
        }

        public ActionResult GetAllReviews()
        {
            ReviewSqlDAO dao = new ReviewSqlDAO(connectionString);
            IList<Review> result = dao.GetAllReviews();
            return View(result);
        }
    }
}
