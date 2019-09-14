using MegaOnlineStore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MegaOnlineStore.Models.DataAccess
{
    public class ProductsCatalogDBContext : DbContext
    {
        public ProductsCatalogDBContext():base("DefaultConnection")
        { }
        public DbSet<SaleItem> SaleItems { get; set; }
    }
}