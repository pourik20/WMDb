using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MovieDB
{
    /// <summary>
    /// Trída reprezentuje filmovou databázi
    /// Filmy se načítají ze zadaného souboru a
    /// musí být v následujícím formátu:
    ///     1. řádek: NÁZEV
    ///     2. řádek: DÉLKA
    ///     3. řádek: HODNOCENÍ
    /// Created by: Tomáš Pour
    /// </summary>
    class MovieDatabase
    {
        private List<Movie> Movies;

        public MovieDatabase()
        {
            Movies = new List<Movie>();
        }

        /// <summary>
        /// Načte data o jednotlivých filmech ze zadaného souboru a
        /// uloží je do listu Movies
        /// </summary>
        /// <param name="fileName">Název souboru</param>
        public void LoadMovies(string fileName)
        {
            try
            {
                using (var sr = new StreamReader(@fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string name = line;
                        int length = Int32.Parse(sr.ReadLine());
                        int rating = Int32.Parse(sr.ReadLine());
                        Movie movie = new Movie(name, length, rating);
                        Movies.Add(movie);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Vypíše seznam všech filmů v databázi
        /// </summary>
        public void PrintAllMovies()
        {
            Console.WriteLine("My Movies");
            Console.WriteLine("------------------------------");
            foreach (Movie movie in Movies)
            {
                Console.WriteLine(movie);
            }
        }

        /// <summary>
        /// Vyhledá všechny filmy podle zadaného řetězce
        /// </summary>
        /// <returns>List nalezených filmů</returns>
        public List<Movie> FindMovies()
        {
            Console.Write("Název filmu: ");
            string title = Console.ReadLine();
            Console.WriteLine("------------------------------");
            List<Movie> found = new List<Movie>();
            foreach (Movie movie in Movies)
            {
                if (movie.Name.ToLower().Contains(title.ToLower()))
                {
                    found.Add(movie);
                }
            }

            return found;
        }

        /// <summary>
        /// Vypíše všechny filmy nalezené pomocí metody <code>FindMovies()</code>
        /// </summary>
        public void PrintMoviesByName()
        {
            List<Movie> found = FindMovies();

            if (found.Count == 0)
            {
                Console.WriteLine("Nebyly nalezeny žádné filmy");
            }
            else
            {
                foreach (Movie movie in found)
                {
                    Console.WriteLine(movie);
                }
            }   
        }

        public void AddMovie()
        {
            Console.Write("Název: ");
            string title = Console.ReadLine();
            Console.Write("Délka: ");
            int duration = Int32.Parse(Console.ReadLine());
            Console.Write("Hodnocení (1 - 5): ");
            int rating = Int32.Parse(Console.ReadLine());

            Movies.Add(new Movie(title, duration, rating));

            using (StreamWriter sw = new StreamWriter(@".. / .. / .. / movies.txt"))
            {
                sw.WriteLine(title);
                sw.WriteLine(duration);
                sw.WriteLine(rating);
            }
        }
    }
}
