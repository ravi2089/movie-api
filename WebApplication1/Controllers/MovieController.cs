using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.IServices;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService movieService;
        public MovieController(IMovieService movie)
        {
            movieService = movie;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movieService.GetMovies();
        }

        [HttpGet("{imdbID}")]
        public Movie Get(string imdbID)
        {
            return movieService.GetMovieById(imdbID);
        }
    }
}
