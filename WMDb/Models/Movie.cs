using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDB
{
    /// <summary>
    /// Třída reprezentuje film v databázi
    /// Created by: Tomáš Pour
    /// </summary>
    class Movie
    {
        /// <summary>Název filmu</summary>
        public string Name { get; }
        /// <summary>Délka filmu [min]</summary>
        public int Length { get; }
        /// <summary>Hodnocení v * (1 - 5)</summary>
        public int Rating { get; }

        public Movie(string name, int length, int rating)
        {
            Name = name;
            Length = length;
            Rating = rating;
        }

        /// <summary>
        /// Převede hodnocení do grafické podoby ("*")
        /// </summary>
        /// <returns>Grafické hodnocení</returns>
        public string RatingToStars()
        {
            string output = "";

            for (int i = 0; i < Rating; i++)
            {
                output += "*";
            }

            return output;

        }

        /// <summary>
        /// Vypíše formátované údaje o filmu
        /// </summary>
        /// <returns>Údaje o filmu</returns>
        public override string ToString()
        {
            return String.Format("Název: {0}\nDélka: {1} minut\nHodnocení: {2}\n------------------------------", Name, Length, RatingToStars());
        }

    }
}
