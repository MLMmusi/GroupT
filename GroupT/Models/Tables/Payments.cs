using System;
using System.ComponentModel.DataAnnotations;

namespace GroupT.Models.Tables
{
    public class Payments
    {
        //Constructors
        public Payments() {
            Payment_Id = Guid.NewGuid();
            Payment_Date = DateTime.Now;
        }
        //Propterties
        [Key]
        [Required]
        public Guid Payment_Id { get; set; }
        [Required]
        public Guid Booking_Id { get; set; }

        [Required]
        public DateTime Payment_Date { get; set; }
        [Required]
        public string Payment_Status { get; set; }

        //Navigation Property
        public Bookings Bookings { get; set; }

    }
}