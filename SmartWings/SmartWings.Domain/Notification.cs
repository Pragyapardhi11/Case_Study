using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWings.Domain
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookingId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("BookingId")]
        public Booking Booking { get; set; }

    }
}
