using System;
using System.Collections.Generic;

#nullable disable

namespace FormUI.Models
{
    public partial class Users
    {
        public Users()
        {
            OrderPurchaserNavigations = new HashSet<Orders>();
            OrderSenderNavigations = new HashSet<Orders>();
        }

        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Pesel { get; set; }
        public int? Job { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual Companies JobNavigation { get; set; }
        public virtual ICollection<Orders> OrderPurchaserNavigations { get; set; }
        public virtual ICollection<Orders> OrderSenderNavigations { get; set; }
    }
}
