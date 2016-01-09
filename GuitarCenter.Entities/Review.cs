using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarCenter.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int Score { get; set; }
        public int? GuitarId { get; set; }

        public virtual Guitar Guitar { get; set; }
    }
}
