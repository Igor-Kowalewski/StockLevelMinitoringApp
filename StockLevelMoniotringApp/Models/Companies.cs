using System;
using System.Collections.Generic;

#nullable disable

namespace FormUI.Models
{
    public partial class Companies
    {
        public Companies()
        {
            Users = new HashSet<Users>();
            Warehouses = new HashSet<Warehouses>();
        }

        public int IdCompany { get; set; }
        public string CompanyNape { get; set; }
        public string Nip { get; set; }
        public int CompanAdres { get; set; }

        public virtual Adresses CompanAdresNavigation { get; set; }
        public virtual ICollection<Users> Users { get; set; }
        public virtual ICollection<Warehouses> Warehouses { get; set; }
    }
}
