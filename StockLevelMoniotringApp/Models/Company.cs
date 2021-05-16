using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FormUI.Models
{
    public partial class Company
    {
        public Company()
        {
            Users = new HashSet<User>();
            Warehouses = new HashSet<Warehous>();
        }


        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Nip { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Warehous> Warehouses { get; set; }
    }
}
