using MegaOnlineStore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaOnlineStore.Models.DataAccess
{
    public interface IProductsRepository
    {
        List<SaleItem> GetSaleItems();
        SaleItem GetSaleItem(int id);
        List<SaleItem> GetSaleItemByCategory(string category);
        List<SaleItem> GetSaleItemByPriceRange(double min,double max);
        void SaveSaleItem(SaleItem s);
        void DeleteSaleItem(SaleItem s);
        void EditSaleItem(SaleItem s);

        

    }
}
