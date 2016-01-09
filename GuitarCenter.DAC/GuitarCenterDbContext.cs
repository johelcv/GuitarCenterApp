using GuitarCenter.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarCenter.DAC
{
    public class GuitarCenterDbContext : DbContext
    {
        public DbSet<Entities.Guitar> Guitars{ get; set; }
        public DbSet<Entities.Review> Reviews { get; set; }
        public GuitarCenterDbContext(): base("Guitars")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Review>().ToTable("Reviews").HasKey(c => c.Id);
            modelBuilder.Entity<Guitar>().ToTable("Guitars").HasKey(c => c.Id).HasMany(c => c.Reviews).WithOptional(c => c.Guitar).HasForeignKey(c => c.GuitarId);
        }
    }
}
