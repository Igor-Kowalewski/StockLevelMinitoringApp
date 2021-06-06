using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FormUI.Models
{
    public partial class OrderItem
    {
        [Key, Column(Order = 0)]
        public int OrderId { get; set; }
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
