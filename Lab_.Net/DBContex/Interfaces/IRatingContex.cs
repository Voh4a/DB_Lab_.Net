using DBContex.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContex.Interfaces
{
    public interface IRatingContex
    {
        IEnumerable<Rating> GetAll();
        void Add(Rating rating);
        void Update(Rating rating);
        void Delete(int _rID, int _mID);
    }
}
