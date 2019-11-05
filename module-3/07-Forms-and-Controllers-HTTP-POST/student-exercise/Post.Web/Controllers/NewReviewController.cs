using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class NewReviewController : Controller
    {
        public string connectionString = "Data Source=.\\sqlexpress;Initial Catalog = squirrels; Integrated Security = True";
        // GET: NewReview
        public ActionResult Index()
        {
            Review newReview = new Review();
            
            return View(newReview);
        }

        public ActionResult GetAllReviews(Review reviews)
        {
            ReviewSqlDAO dao = new ReviewSqlDAO(connectionString);
            IList<Review> result = dao.GetAllReviews();
            return View(result);
        }
    }
}