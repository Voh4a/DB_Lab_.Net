using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContex.Classes
{
    public class Rating
    {
        public int rID { get; set; }
        public int mID { get; set; }
        public int Stars { get; set; }
        public DateTime RatingDate { get; set; }

        public Movie movie { get; set; }
        public Reviewer reviewer { get; set; }

        public Rating()
        {
            movie = new Movie();
            reviewer = new Reviewer();
        }
    }
}
