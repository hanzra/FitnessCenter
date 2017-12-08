using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessCenter.Domain.Entities
{
    public class FitnessClass
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Instructor { get; set; }
        public virtual IEnumerable<Schedule> schedule { get; set; }
    }
}