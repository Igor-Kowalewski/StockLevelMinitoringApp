using System;
using System.Collections.Generic;

#nullable disable

namespace FormUI.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Items = new HashSet<Products>();
        }

        public int IdCategory { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Products> Items { get; set; }
    }
}
