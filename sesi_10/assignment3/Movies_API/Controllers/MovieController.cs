using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Movies_API.Models;
// using Microsoft.Extensions.Logging;

namespace Movies_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            this._context = context;
        }

        // GET: api/User
        public ActionResult<IEnumerable<MovieItem>> GetMovieItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            // retirm new string[]
            return _context.GetAllMovie();
        }

        // GET: api/user/{id}
        [HttpGet("{id}", Name ="Get")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItems(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetMovie(id);
        }

        [HttpPost]
        public string AddMovie(MovieItem movie) {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.AddMovie(movie);
        }

        [HttpPut("{id}")]
        public string UpdateMovie(int id, MovieItem movie)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.UpdateMovie(id, movie);
        }

        [HttpDelete("{id}")]
        public string DeleteMovie(int id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.DeleteMovie(id);
        }        
    }
}
