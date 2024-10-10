using CodeFirstBasic.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CodeFirstBasic.Data
{
    
    public class PatikaFirsDbContext :DbContext
    {
        public DbSet<MovieEntity> Movies => Set<MovieEntity>();
        public DbSet<GameEntity> Games => Set<GameEntity>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=ZEYNEP\SQLEXPRESS; database=PatikaCodeFirstDb1; Trusted_Connection=true; TrustServerCertificate=true");


            //optionsBuilder.UseSqlServer(@"server=ZEYNEP\SQLEXPRESS; database=PatikaFirstDb; uid=sa; pwd=sa; TrustedServerCertificate=true");

            base.OnConfiguring(optionsBuilder);



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
