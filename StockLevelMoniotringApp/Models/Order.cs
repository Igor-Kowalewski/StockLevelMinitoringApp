using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FormUI.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        [Key]
        public int OrderId { get; set; }
        public decimal Subotal { get; set; }
        public string AdditionalInformations { get; set; }
        public int OrderAddressId { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }

        [ForeignKey("OrderAddressId")]
        public virtual Address OrderAddress { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
