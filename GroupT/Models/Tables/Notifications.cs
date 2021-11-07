using System;
using System.ComponentModel.DataAnnotations;

namespace GroupT.Models.Tables
{
    public class Notifications
    {
        //Constructor
        public Notifications() {
            Notification_Id = Guid.NewGuid();
            Booking_Date = DateTime.Now;
        }

        //Properties
        [Key]
        [Required]
        public Guid Notification_Id { get; set; }
        [Required]
        public Guid Admin_Id { get; set; }
        [Required]
        public Guid Learner_Id { get; set; }
        [Required]
        public Guid Instructor_Id { get; set; }
        [Required]
        public string Application_Status { get; set; }
        [Required]
        public string Reasons { get; set; }
        [Required]
        public DateTime Booking_Date { get; set; }
        //Navigation Properties
        public Learners Learners { get; set; }
        public Instructors Instructor { get; set; }
        public Administrators Administrators { get; set; }

    }
}