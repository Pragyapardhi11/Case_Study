using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWings.Domain
{
    public class Flight
    {
        [Key]
        
        public int FlightId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string FlightName { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string StartLocation { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Destination { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required]
        [Column(TypeName = "time")]
        public TimeSpan Time { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Rate { get; set; }
    }
}
