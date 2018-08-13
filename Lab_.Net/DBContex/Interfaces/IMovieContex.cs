using DBContex.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContex.Interfaces
{
    public interface IMovieContex
    {
        IEnumerable<Movie> GetAll();
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(int _mID);
    }
}
