using GuitarCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarCenter.BL
{
    public interface IGuitarService
    {
        Guitar GetOne(int Id);
        IEnumerable<Guitar> GetAll();
        void Create(Guitar Model);
        void CreateReview(Review Model);
    }
}
