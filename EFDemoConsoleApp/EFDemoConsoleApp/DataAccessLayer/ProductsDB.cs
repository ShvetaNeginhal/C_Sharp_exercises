using EFDemoConsoleApp.Entities;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoConsoleApp.DataAccessLayer
{
   public class ProductsDB : DbContext // map to db
    {
        public DbSet<Product> Products { get; set; } //maps entity to table
        public DbSet<Category> Categories { get; set; }
    }
}
