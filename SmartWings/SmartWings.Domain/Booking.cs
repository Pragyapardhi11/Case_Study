using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWings.Domain
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }


        [Required]
        public int UserId { get; set; }


        [Required]
        public int FlightId { get; set; }


        [ForeignKey("UserId")]
        public User User { get; set; }


        [ForeignKey("FlightId")]
        public Flight Flight { get; set; }
    }
}
