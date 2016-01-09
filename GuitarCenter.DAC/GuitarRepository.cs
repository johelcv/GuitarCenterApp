using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarCenter.Entities;
using Dapper;

namespace GuitarCenter.DAC
{
    public class GuitarRepository : IGuitarRepositorio
    {
        private string ConnectionString = null;

        public GuitarRepository()
        {
            this.ConnectionString = ConfigurationManager.ConnectionStrings["Guitars"].ConnectionString;
        }

        public int Count()
        {
            int result = 0;
            using (var con = new SqlConnection(this.ConnectionString))
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = "usp_guitars_count";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                result = (int)cmd.ExecuteScalar();
            }
            return result;
        }

        public void Create(Guitar Model)
        {
            var context = new GuitarCenterDbContext();
            context.Guitars.Add(Model);
            context.SaveChanges();
        }

        public void CreateReview(Review Model)
        {
            var context = new GuitarCenterDbContext();
            context.Reviews.Add(Model);
            context.SaveChanges();
        }

        public IEnumerable<Entities.Guitar> GetAll()
        {
            IEnumerable<Entities.Guitar> result = new List<Entities.Guitar>();
            using (var con = new SqlConnection(this.ConnectionString))
            {
                result = con.Query<Entities.Guitar>("usp_guitar_get", commandType: System.Data.CommandType.StoredProcedure);
            }
            return result;
        }

        public Guitar GetOne(int Id)
        {
            Entities.Guitar result = null;

            var context = new GuitarCenterDbContext();

            result = (from c in context.Guitars.Include("Reviews")
                      where c.Id == Id
                      select c).FirstOrDefault();

            return result;
        }
    }
}
