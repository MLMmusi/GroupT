using System;
using System.ComponentModel.DataAnnotations;

namespace GroupT.Models.Tables
{
    public class Bookings
    {
        //Constructors
        public Bookings() {
            Booking_Id = Guid.NewGuid();
            Booking_Date = DateTime.Now;
        }

        //Properties
        [Key]
        [Required]
        public Guid Booking_Id { get; set; }
        [Required]
        public Guid Learner_Id { get; set; }
        [Required]
        public Guid Instructor_Id { get; set; }
        [Required]
        public Guid Vehicle_Id { get; set; }
        [Required]
        public DateTime Booking_Date { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Booking_Status { get; set; }

        //Navigation Property
        public Learners Learners { get; set; }
        public Instructors Instructor { get; set; }
        public Vehicles Vehicles { get; set; }
    }
}