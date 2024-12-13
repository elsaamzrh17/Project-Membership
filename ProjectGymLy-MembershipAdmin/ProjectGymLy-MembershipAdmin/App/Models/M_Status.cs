using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGymLy_MembershipAdmin.App.Models
{
    public class M_Status
    {
        [Key]
        public int id { get; set; }
        [Required]
        public required string status_membership { get; set; }
    }
}
