using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FormUI.Models
{
    public partial class Warehous
    {
        public Warehous()
        {
            WarehousProducts = new HashSet<WarehousProduct>();
        }

        [Key]
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public int AddressId { get; set; }
        public int? CompanyId { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
        public virtual ICollection<WarehousProduct> WarehousProducts { get; set; }
    }
}
