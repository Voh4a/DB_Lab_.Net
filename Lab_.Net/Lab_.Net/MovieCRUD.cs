using DBContex.Classes;
using DBContex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_.Net
{
    class MovieCRUD
    {
        public static void PrintAll()
        {
            IMovieContex contex = new MovieContex();

            List<Movie> list = contex.GetAll().ToList();

            foreach (Movie item in list)
            {
                Console.WriteLine("ID: {0}", item.mID);
                Console.WriteLine("Name: {0}", item.Title);
                Console.WriteLine("Year: {0}", item.Year);
                Console.WriteLine("Dirrector: {0}", item.Director);
                Console.WriteLine(new string('-', 30));
            }
        }

        public static void Add()
        {
            IMovieContex contex = new MovieContex();

            Movie movie = new Movie();

            Console.Write("Enter Tiltle: ");
            movie.Title = Console.ReadLine();
            Console.Write("Enter Year: ");
            movie.Year = Console.ReadLine();
            Console.Write("Enter Diretor: ");
            movie.Director = Console.ReadLine();

            contex.Add(movie);
        }

        public static void Update()
        {
            IMovieContex contex = new MovieContex();

            Movie movie = new Movie();

            PrintAll();

            Console.Write("\nEnter ID: ");
            movie.mID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Tiltle: ");
            movie.Title = Console.ReadLine();
            Console.Write("Enter Year: ");
            movie.Year = Console.ReadLine();
            Console.Write("Enter Diretor: ");
            movie.Director = Console.ReadLine();

            contex.Update(movie);
        }

        public static void Delete()
        {
            IMovieContex contex = new MovieContex();

            int id = 0;

            PrintAll();

            Console.Write("\nEnter ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            contex.Delete(id);
        }
    }
}
