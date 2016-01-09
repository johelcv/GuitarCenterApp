using GuitarCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarCenter.DAC
{
    public interface IGuitarRepositorio
    {
        IEnumerable<Guitar> GetAll();
        Guitar GetOne(int Id);
        void Create(Guitar Model);
        void CreateReview(Review Model);
        int Count();
    }
}
