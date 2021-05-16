using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public int UserId { get; set; }
        public int CompanyId { get; set; }

        public virtual Address OrderAddress { get; set; }
        public virtual User User { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
