using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWings.Domain
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }


        [Required]
        public int BookingId { get; set; }


        [ForeignKey("BookingId")]
        public Booking Booking { get; set; }
    }
}
