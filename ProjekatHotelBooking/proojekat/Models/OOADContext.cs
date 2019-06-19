using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proojekat.Models
{
    public class OOADContext: DbContext
    {
        public OOADContext(DbContextOptions<OOADContext> options) : base(options)
        {

        }
        public DbSet<Gost> Gost { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }
        public DbSet<Ponuda> Ponuda { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gost>().ToTable("Gost");
            modelBuilder.Entity<Rezervacija>().ToTable("Rezervacija");
            modelBuilder.Entity<Ponuda>().ToTable("Ponuda");
        }


}
}
