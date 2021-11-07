using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupT.Models.Tables
{
    public class Learners
    {
        //Constructors
        public Learners() {
            Learner_Id = Guid.NewGuid();
            Created_On = DateTime.Now;
        }

        //Properties
        [Key]
        [Required]
        public Guid Learner_Id { get; set; }
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Next_Of_Kin { get; set; }
        [Required]
        public string Id_Number { get; set; }
        [Required]
        public string Contact_Num { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime Created_On { get; set; }

        //Navigation Properties
    }
}