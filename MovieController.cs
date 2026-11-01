using Microsoft.AspNetCore.Mvc;
using MovieList.Models;

namespace MovieList.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext context { get; set; }

        public MovieController(MovieContext ctx)
        {
            context = ctx;
        }
        
        public IActionResult Index()
        {
            var movies = context.Movies.OrderBy(n => n.Name).ToList();
            return View(movies);               
        }
    }
}