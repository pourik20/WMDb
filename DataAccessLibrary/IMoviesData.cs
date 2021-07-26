using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IMoviesData
    {
        Task<List<MovieModel>> GetMovies();
        Task InsertMovie(MovieModel movie);
    }
}