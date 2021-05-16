using System;
using System.Collections.Generic;

#nullable disable

namespace FormUI.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrdersDetails>();
        }

        public int IdItem { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public int? Location { get; set; }
        public int Category { get; set; }

        public virtual Categories CategoryNavigation { get; set; }
        public virtual Warehouses LocationNavigation { get; set; }
        public virtual ICollection<OrdersDetails> OrderDetails { get; set; }
    }
}
