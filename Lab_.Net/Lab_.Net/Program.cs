using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_.Net
{
    class Program
    {
        static void Reviewer()
        {
            int x = 1;
            while (x > 0)
            {
                Console.WriteLine("1. Get all Reviewer");
                Console.WriteLine("2. Add Reviewer");
                Console.WriteLine("3. Update Reviewer");
                Console.WriteLine("4. Delete Reviewer");
                Console.WriteLine("5. Back");

                x = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (x)
                {
                    case 1:
                        ReviewerCRUD.PrintAll();
                        Console.ReadKey();
                        break;
                    case 2:
                        ReviewerCRUD.Add();
                        break;
                    case 3:
                        ReviewerCRUD.Update();
                        break;
                    case 4:
                        ReviewerCRUD.Delete();
                        break;
                    case 5:
                        x = -1;
                        break;
                }

                Console.Clear();
            }
        }

        static void Movie()
        {
            int x = 1;
            while (x > 0)
            {
                Console.WriteLine("1. Get all Movie");
                Console.WriteLine("2. Add Reviewer");
                Console.WriteLine("3. Update Reviewer");
                Console.WriteLine("4. Delete Reviewer");
                Console.WriteLine("5. Back");

                x = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (x)
                {
                    case 1:
                        MovieCRUD.PrintAll();
                        Console.ReadKey();
                        break;
                    case 2:
                        MovieCRUD.Add();
                        break;
                    case 3:
                        MovieCRUD.Update();
                        break;
                    case 4:
                        MovieCRUD.Delete();
                        break;
                    case 5:
                        x = -1;
                        break;
                }

                Console.Clear();
            }
        }

        static void Rating()
        {
            int x = 1;
            while (x > 0)
            {
                Console.WriteLine("1. Get all Rating");
                Console.WriteLine("2. Add Rating");
                Console.WriteLine("3. Update Rating");
                Console.WriteLine("4. Delete Rating");
                Console.WriteLine("5. Back");

                x = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (x)
                {
                    case 1:
                        RatingCRUD.PrintAll();
                        Console.ReadKey();
                        break;
                    case 2:
                        RatingCRUD.Add();
                        break;
                    case 3:
                        RatingCRUD.Update();
                        break;
                    case 4:
                        RatingCRUD.Delete();
                        break;
                    case 5:
                        x = -1;
                        break;
                }

                Console.Clear();
            }
        }

        static void Main(string[] args)
        {
            int x = 1;

            while (x > 0)
            {

                Console.WriteLine("1. Reviewer");
                Console.WriteLine("2. Movie");
                Console.WriteLine("3. Rating");
                Console.WriteLine("4. Exit");

                x = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(x)
                {
                    case 1:
                        Reviewer();
                        break;
                    case 2:
                        Movie();
                        break;
                    case 3:
                        Rating();
                        break;
                    case 4:
                        x = -1;
                        break;
                }
            }
        }
    }
}
