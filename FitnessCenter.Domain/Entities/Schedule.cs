using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessCenter.Domain.Entities
{
        public class Schedule
        {
            [Key]
            public int ID { get; set; }
            [ForeignKey("FitnessClass")]
            public int ClassID { get; set; }
            [Required]
            public DateTime Date { get; set; }
            [Required]
            public DateTime StartTime { get; set; }
            [Required]
            public DateTime EndTime { get; set; }
            [Required]
            public int Capacity { get; set; }
            [Required]
            public Status Status { get; set; } 
            public virtual FitnessClass FitnessClass { get; set; }
            public virtual ICollection<Registration> Registration { get; set; }
        }
        public enum Status
        {
            Active,
            Inactive
        }    
}
