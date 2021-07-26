using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class MoviesData : IMoviesData
    {
        private readonly ISqlDataAccess _db;

        public MoviesData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<MovieModel>> GetMovies()
        {
            string sql = "select * from MoviesList";

            return _db.LoadData<MovieModel, dynamic>(sql, new { });
        }

        public Task InsertMovie(MovieModel movie)
        {
            string sql = @"insert into MoviesList (Title, Director, Length, Rating)
                           values (@Title, @Director, @Length, @Rating);";

            return _db.SaveData(sql, movie);
        }
    }
}
