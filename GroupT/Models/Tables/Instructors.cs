using System;
using System.ComponentModel.DataAnnotations;

namespace GroupT.Models.Tables
{
    public class Instructors
    {
        //Constructor
        public Instructors(){
            Instructor_Id = Guid.NewGuid();
            Created_On = DateTime.Now;
        }

        //Properties
        [Key]
        [Required]
        public Guid Instructor_Id{get;set;}
        [Required]
        public Guid Id { get; set; }
        [Required]
        public DateTime Created_On { get; set; }
        
        [Required]
        public string License_Num{get; set;}
        [Required]
        public string Alt_ContactNum{get; set;}

    }
}
