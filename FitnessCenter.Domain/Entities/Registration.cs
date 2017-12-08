using FitnessCenter.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessCenter.Domain.Entities
{
    public class Registration
    {
        [Key]
        public int RegistrationID { get; set; }        
        public int ScheduleID { get; set; }
        [ForeignKey("AppUser")]
        public string UserID { get; set; }
        public int WaitNumber { get; set; }
        public DateTime DateTime { get; set; }
        public RegisrtationStatus Status { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual AppUser AppUser { get; set; }
    }

    public enum RegisrtationStatus
    {
        Confirmed,
        Waiting
    }
}
