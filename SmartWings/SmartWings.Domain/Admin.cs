using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWings.Domain
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string AdminName { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string AdminPassword { get; set; }
    }
}
