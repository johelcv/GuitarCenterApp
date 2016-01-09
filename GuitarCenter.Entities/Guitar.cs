using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarCenter.Entities
{
    public class Guitar
    {
        public Guitar()
        {
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}