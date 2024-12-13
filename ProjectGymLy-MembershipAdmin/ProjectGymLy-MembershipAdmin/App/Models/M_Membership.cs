using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGymLy_MembershipAdmin.App.Models
{
    public class M_Membership
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nama { get; set; }
        [ForeignKey("M_Status")]
        public int id_status { get; set; }
    }
}
