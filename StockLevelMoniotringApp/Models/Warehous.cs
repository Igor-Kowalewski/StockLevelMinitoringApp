using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FormUI.Models
{
    public partial class Warehous
    {
        public Warehous()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public int AddressId { get; set; }
        public int CompanyId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
