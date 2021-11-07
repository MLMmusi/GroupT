using System;
using System.ComponentModel.DataAnnotations;

namespace GroupT.Models.Tables
{
    public class Administrators
    {
        //Constructors
        public Administrators() {
            Admin_Id = Guid.NewGuid();
            Booking_Date = DateTime.Now;
        }
        //Properties
        [Key]
        [Required]
        public Guid Admin_Id { get; set; }
        [Required]
        public Guid Id { get; set; }
        [Required]
        public DateTime Booking_Date { get; set; }



    }
}