using System;
using System.Collections.Generic;

#nullable disable

namespace FormUI.Models
{
    public partial class Orders
    {
        public int IdOrder { get; set; }
        public int Sender { get; set; }
        public int Purchaser { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public int OrderItem { get; set; }

        public virtual Adresses FromNavigation { get; set; }
        public virtual OrdersDetails OrderItemNavigation { get; set; }
        public virtual Users PurchaserNavigation { get; set; }
        public virtual Users SenderNavigation { get; set; }
        public virtual Adresses ToNavigation { get; set; }
    }
}
