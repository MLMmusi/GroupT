using System;
using System.ComponentModel.DataAnnotations;

namespace GroupT.Models.Tables
{
    public class Vehicles
    {
        //Constructors
        public Vehicles() {
            Vehicle_Id = Guid.NewGuid();
            Created_On = DateTime.Now;
        }
        //Properties
        [Key]
        [Required]
        public Guid Vehicle_Id { get; set; }
        [Required]
        public DateTime Created_On { get; set; }
        [Required]
        public string Vehicle_Name { get; set; }
        [Required]
        public string Vehicle_Model { get; set; }
        [Required]
        public string Vehicle_Color { get; set; }
        [Required]
        public string Vehicle_Type { get; set; }
        [Required]
        public byte Vehicle_Picture { get; set; }
        [Required]
        public double Vehicle_Price { get; set; }
        [Required]
        public Guid Instructors_Id { get; set; }

        //Navigation Property
        public Instructors Instructor { get; set; }
    }
}