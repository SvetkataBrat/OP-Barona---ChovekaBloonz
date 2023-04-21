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
            optionsBuilder.UseSqlServer("Server=LAPTOP-AT94SBBO\\SQLEXPRESS;Database=ShopDb11J;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
