using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBContex.Classes;

namespace DBContex.Interfaces
{
    public interface IReviewerContex
    {
        IEnumerable<Reviewer> GetAll();
        void Add(Reviewer reviewer);
        void Update(Reviewer reviewer);
        void Delete(int _rID);
    }
}
