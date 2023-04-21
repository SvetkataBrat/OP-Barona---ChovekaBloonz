using Microsoft.EntityFrameworkCore;
using Buisiness_Layer;
using System;


namespace Data_Layer
{
    public class ColetoContext : DbContext
    {
        public ColetoContext ()
        {

        }

        public ColetoContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Svetkata - Server=TIMI-PC\MSSQLSERVER03;Database=MusicDB;Trusted_Connection=True;Encrypt=false" -Provider "Microsoft.EntityFrameworkCore.SqlServer
            // Ico - 
            // Lucho -


            optionsBuilder.UseSqlServer("Server=TIMI-PC\\MSSQLSERVER03;Database=MusicDB;Trusted_Connection=True;Encrypt=false\" -Provider \"Microsoft.EntityFrameworkCore.SqlServer");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Auto> Autos { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<AutoSalon> AutoSalons { get; set; }
    }
}
