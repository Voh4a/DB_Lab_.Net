using DBContex.Classes;
using DBContex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_.Net
{
    class RatingCRUD
    {
        public static void PrintAll()
        {
            IRatingContex contex = new RatingContex();

            List<Rating> list = contex.GetAll().ToList();

            foreach (Rating item in list)
            {
                Console.WriteLine("Reviewer ID: {0} | Movie ID: {1}", item.rID, item.mID);
                Console.WriteLine("Title: {0} | Director: {1} | Stars: {2}", item.movie.Title, item.movie.Director, item.Stars);
                Console.WriteLine("Reviewer: {0}", item.reviewer.Name);
                Console.WriteLine("Rating date: {0}", item.RatingDate);
                Console.WriteLine(new string('-', 30));
            }
        }

        public static void Add()
        {
            IRatingContex contex = new RatingContex();

            Rating rating = new Rating();

            Console.WriteLine("REVIEWERS");
            ReviewerCRUD.PrintAll();

            Console.WriteLine("MOVIES");
            MovieCRUD.PrintAll();

            Console.Write("/nEnter Reviewer ID: ");
            rating.rID = Convert.ToInt32(Console.ReadLine());
            Console.Write("/nEnter Movie ID: ");
            rating.mID = Convert.ToInt32(Console.ReadLine());
            Console.Write("/nEnter Stars: ");
            rating.Stars = Convert.ToInt32(Console.ReadLine());
            Console.Write("/nEnter Date: ");
            rating.RatingDate = Convert.ToDateTime(Console.ReadLine());

            contex.Add(rating);
        }

        public static void Update()
        {
            IRatingContex contex = new RatingContex();

            Rating rating = new Rating();

            PrintAll();

            Console.Write("/nEnter Reviewer ID: ");
            rating.rID = Convert.ToInt32(Console.ReadLine());
            Console.Write("/nEnter Movie ID: ");
            rating.mID = Convert.ToInt32(Console.ReadLine());
            Console.Write("/nEnter Stars: ");
            rating.Stars = Convert.ToInt32(Console.ReadLine());
            Console.Write("/nEnter Date: ");
            rating.RatingDate = Convert.ToDateTime(Console.ReadLine());

            contex.Update(rating);
        }

        public static void Delete()
        {
            IRatingContex contex = new RatingContex();

            int rID = 0;
            int mID = 0;

            PrintAll();

            Console.Write("/nEnter Reviewer ID: ");
            rID = Convert.ToInt32(Console.ReadLine());
            Console.Write("/nEnter Movie ID: ");
            mID = Convert.ToInt32(Console.ReadLine());

            contex.Delete(rID, mID);
        }
    }
}
