using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoConsoleApp.Entities
{
    public class Product
    {
        public int ID { get; set; } //primary key--> class name + ID or ID
        public string Name { get; set; }
        [Range(10, 100000)]
        public double Price { get; set; }
        
        public bool InStock { get; set; }
        public int Qty { get; set; }

        public Category category { get; set; }
    }
}
