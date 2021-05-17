using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FormUI.Models
{
    public partial class CompanyRole
    {
        [Key]
        public int CompanyRoleId { get; set; }
        public string RoleName { get; set; }
    }
}
