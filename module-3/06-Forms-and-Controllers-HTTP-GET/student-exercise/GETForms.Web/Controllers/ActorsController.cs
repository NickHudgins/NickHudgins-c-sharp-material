using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class ActorsController : Controller
    {
        public string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=dvdstore;Integrated Security=True";
        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ActorSearch search = new ActorSearch();
            return View(search);
        }

        /// <summary>
        /// The request to display search results.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(ActorSearch search)
        {
            /* Call the DAL and pass the values as a model back to the View */
            ActorDAO dao = new ActorDAO(connectionString);
            IList<Actor> result = dao.FindActors(search.FirstName);
            return View(result);
        }
    }
}