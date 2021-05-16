using System;
using System.Collections.Generic;

#nullable disable

namespace FormUI.Models
{
    public partial class OrdersDetails
    {
        public OrdersDetails()
        {
            Orders = new HashSet<Orders>();
        }

        public int IdOrderDetail { get; set; }
        public int Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double? Discount { get; set; }

        public virtual Products ProductNavigation { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
