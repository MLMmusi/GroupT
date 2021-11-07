using System;
using System.ComponentModel.DataAnnotations;

namespace GroupT.Models.Tables
{
    public class DrivingGrounds
    {
        //Constructors
        public DrivingGrounds() {
            DrivingGround_Id = Guid.NewGuid();
            Created_On = DateTime.Now;
        }

        //Properties
        [Key]
        [Required]
        public Guid DrivingGround_Id { get; set; }
        [Required]
        public DateTime Created_On { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public Guid Instructor_Id { get; set; }

        //Navigation Property
        public Instructors Instructor { get; set; }

    }
}