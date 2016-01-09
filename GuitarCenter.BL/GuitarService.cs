using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarCenter.Entities;

namespace GuitarCenter.BL
{
    public class GuitarService : IGuitarService
    {
        private DAC.IGuitarRepositorio GuitarRepositorio = new DAC.GuitarRepository();

        public void Create(Guitar Model)
        {
            this.GuitarRepositorio.Create(Model);
        }

        public void CreateReview(Review Model)
        {
            this.GuitarRepositorio.CreateReview(Model);
        }

        public IEnumerable<Guitar> GetAll()
        {
            return this.GuitarRepositorio.GetAll();
        }

        public Guitar GetOne(int Id)
        {
            return this.GuitarRepositorio.GetOne(Id);
        }
    }
}
