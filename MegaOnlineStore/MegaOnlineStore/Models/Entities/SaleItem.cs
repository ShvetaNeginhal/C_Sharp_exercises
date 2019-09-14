using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MegaOnlineStore.Models.Entities
{
    public class SaleItem
    {
        public int SaleItemID { get; set; }
        [Required]
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        [Range(1,99999)]
        public double Price { get; set; }
        
        public int Quantity { get; set; }

    }
}