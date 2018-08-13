using DBContex.Classes;
using DBContex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_.Net
{
    class ReviewerCRUD
    {
        public static void PrintAll()
        {
            IReviewerContex contex = new ReviewerContex();

            List<Reviewer> list = contex.GetAll().ToList();

            foreach (Reviewer item in list)
            {
                Console.WriteLine("ID: {0}", item.rID);
                Console.WriteLine("Name: {0}", item.Name);
                Console.WriteLine(new string('-', 30));
            }
        }

        public static void Add()
        {
            IReviewerContex contex = new ReviewerContex();

            Reviewer reviewer = new Reviewer();

            Console.Write("Enter Name: ");
            reviewer.Name = Console.ReadLine();

            contex.Add(reviewer);
        }

        public static void Update()
        {
            IReviewerContex contex = new ReviewerContex();

            Reviewer reviewer = new Reviewer();

            PrintAll();

            Console.Write("\nEnter ID: ");
            reviewer.rID = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Name: ");
            reviewer.Name = Console.ReadLine();

            contex.Update(reviewer);
        }

        public static void Delete()
        {
            IReviewerContex contex = new ReviewerContex();

            int id = 0;

            PrintAll();

            Console.Write("\nEnter ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            contex.Delete(id);
        }
    }
}
