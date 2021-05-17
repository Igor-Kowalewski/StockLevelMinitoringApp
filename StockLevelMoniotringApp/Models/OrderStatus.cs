using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FormUI.Models
{
    public partial class OrderStatus
    {
        [Key]
        public int OrderStatusId { get; set; }
        public string StatusName { get; set; }
    }
}
