using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FormUI.Models
{
   public partial class WarehousProduct
    {
        [Key]
        public int WarehouseProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public int? WarehousId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("WarehousId")]
        public virtual Warehous Warehous { get; set; }
    }
}
