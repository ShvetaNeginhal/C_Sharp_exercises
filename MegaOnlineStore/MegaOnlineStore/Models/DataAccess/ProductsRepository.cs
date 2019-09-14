using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MegaOnlineStore.Models.Entities;
using MegaOnlineStore.Models.Exceptions;

namespace MegaOnlineStore.Models.DataAccess
{
    public class ProductsRepository : IProductsRepository
    {
        private ProductsCatalogDBContext db = new ProductsCatalogDBContext();
        public void DeleteSaleItem(SaleItem s)
        {
            //S1: get item to delete
            var itemToDelete = db.SaleItems.Find(s);
            if (itemToDelete == null)
                throw new ProductNotFoundException($"Sale item Id {s} not found");
            //S2: delete item
            db.SaleItems.Remove(itemToDelete);
            //S3: save changes
            db.SaveChanges();
        }

        public void EditSaleItem(SaleItem s)
        {
            db.Entry(s).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public SaleItem GetSaleItem(int id)
        {
            var item = db.SaleItems.Find(id);
            if (item == null)
                throw new ProductNotFoundException($"Sale item Id {id} not found");
            return item;
        }

        public List<SaleItem> GetSaleItemByCategory(string category)
        {
            var items = from item in db.SaleItems
                        where item.Category.Contains(category)
                        select item;
            return items.ToList();
        }

        public List<SaleItem> GetSaleItemByPriceRange(double min, double max)
        {
            return db.SaleItems.Where(si => si.Price >= min && si.Price <= max).ToList();
         
        }

        public List<SaleItem> GetSaleItems()
        {
            return db.SaleItems.ToList();
        }

        public void SaveSaleItem(SaleItem s)
        {
            db.SaleItems.Add(s);
            db.SaveChanges();
        }
    }
}