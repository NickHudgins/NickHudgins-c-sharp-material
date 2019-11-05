using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class FilmsController : Controller
    {
        public string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=dvdstore;Integrated Security=True";
        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            FilmSearch movie = new FilmSearch();
            return View(movie);
        }

        /// <summary>
        /// Receives the search result request and goes to th database looking for the information.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(FilmSearch search)
        {
            FilmDAO dao = new FilmDAO(connectionString);
            IList<Film> result = dao.GetFilmsBetween(search.Genre, search.MinLength, search.MaxLength);
            return View(result);
            /* Call the DAL and pass the values as a model back to the View */
        }
    }
}