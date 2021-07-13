using System;

namespace MovieDB
{
    /// <summary>
    /// Hlavní třída programu
    /// Created by: Tomáš Pour
    /// </summary>
    class Program
    {
        /// <summary>
        /// Vstupní metoda programu
        /// </summary>
        /// <param name="args">Parametry příkazové řádky</param>
        static void Main(string[] args)
        {
            MovieDatabase db = new MovieDatabase();
            db.LoadMovies("../../../movies.txt");
            Console.WriteLine("Filmová databáze 1.0");
            Console.WriteLine("------------------------------");
            PrintMenu();
            char volba = '0';
            while (volba != '4')
            {
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();
                switch (volba)
                {
                    case '1':
                        db.AddMovie();
                        break;
                    case '2':
                        db.PrintMoviesByName();
                        break;
                    case '3':
                        db.PrintAllMovies();
                        break;
                    case '4':
                        Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení programu.");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba! Opakujte pokus.");
                        break;
                }
                PrintMenu();
            }
        }

        /// <summary>
        /// Vypíše všechny uživatelské možnosti
        /// </summary>
        public static void PrintMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("----");
            Console.WriteLine("1 - Přidat film");
            Console.WriteLine("2 - Vyhledat film");
            Console.WriteLine("3 - Vypsat všechny filmy");
            Console.WriteLine("4 - Ukončit aplikaci");
        }
    }
}
