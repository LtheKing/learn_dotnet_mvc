using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.ViewModel
{
    public class ProductRequest
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string UnitPrice { get; set; }
        public string AvailableQuantity { get; set; }
    }
}
