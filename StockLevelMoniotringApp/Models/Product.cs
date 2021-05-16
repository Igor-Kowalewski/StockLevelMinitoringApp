using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FormUI.Models
{
    public partial class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string DisplayName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int? WarehouseId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Warehous Warehouse { get; set; }
    }
}
