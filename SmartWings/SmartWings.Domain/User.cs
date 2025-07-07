using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWings.Domain
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string UserPassword { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [EmailAddress]
        public string UserEmail { get; set; }

    }
}
