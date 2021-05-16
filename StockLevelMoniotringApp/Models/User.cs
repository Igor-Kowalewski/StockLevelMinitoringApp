using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FormUI.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
    }
}
