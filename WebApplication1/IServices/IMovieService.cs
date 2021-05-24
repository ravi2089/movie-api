using System.Collections.Generic;
using WebApplication1.Model;

namespace WebApplication1.IServices
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovieById(string imdbID);
    }
}
