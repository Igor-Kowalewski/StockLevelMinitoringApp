using System;
using System.Collections.Generic;

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
        public Address Address { get; set; }
    }
}
