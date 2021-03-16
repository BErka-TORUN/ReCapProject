using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Concrete.EntittyFaremwork
{
    public class CarDataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;database=cardatabase;Trueted_Connection = true");
        }   

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Color> Color { get; set; }

    }
}
