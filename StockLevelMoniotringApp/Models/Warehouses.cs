using System;
using System.Collections.Generic;

#nullable disable

namespace FormUI.Models
{
    public partial class Warehouses
    {
        public Warehouses()
        {
            Items = new HashSet<Products>();
        }

        public int IdWarehouse { get; set; }
        public int WarehouseAdres { get; set; }
        public string WarehouseName { get; set; }
        public int Company { get; set; }

        public virtual Companies CompanyNavigation { get; set; }
        public virtual Adresses WarehouseAdresNavigation { get; set; }
        public virtual ICollection<Products> Items { get; set; }
    }
}
