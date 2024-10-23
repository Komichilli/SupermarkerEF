using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SupermarkerEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketEF.Models;

namespace SupermarkerEF.Data
{
    internal class SupermarketContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=SupermarketEF;Trusted_Connection=True;");

        }

    }
}
