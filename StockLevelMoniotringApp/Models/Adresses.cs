using System;
using System.Collections.Generic;

#nullable disable

namespace FormUI.Models
{
    public partial class Adresses
    {
        public Adresses()
        {
            Companies = new HashSet<Companies>();
            OrderFromNavigations = new HashSet<Orders>();
            OrderToNavigations = new HashSet<Orders>();
            Warehouses = new HashSet<Warehouses>();
        }

        public int IdAdres { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Local { get; set; }

        public virtual ICollection<Companies> Companies { get; set; }
        public virtual ICollection<Orders> OrderFromNavigations { get; set; }
        public virtual ICollection<Orders> OrderToNavigations { get; set; }
        public virtual ICollection<Warehouses> Warehouses { get; set; }
    }
}
