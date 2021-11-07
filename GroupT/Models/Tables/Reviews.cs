using System;
using System.ComponentModel.DataAnnotations;

namespace GroupT.Models.Tables
{
    public class Reviews
    {
        //Constructors
        public Reviews()
        {

            Review_Id = Guid.NewGuid();
            Booking_Date= DateTime.Now;
        }
        //Properties
        [Key]
        [Required]
        public Guid Review_Id { get; set; }
        [Required]
        public Guid Booking_Id { get; set; }
        [Required]
        public string Review { get; set; }
        [Required]
        public float Rating { get; set; }
        [Required]

        public DateTime Booking_Date { get; set; }
        //Navigation Properties
        public Bookings Bookings { get; set; }

    }
}