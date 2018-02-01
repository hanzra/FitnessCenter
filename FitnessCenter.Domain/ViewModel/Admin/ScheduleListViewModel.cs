using FitnessCenter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Domain.ViewModel.Admin
{
    public class ScheduleListViewModel
    {
        public Schedule Schedue { get; set; }
        public int AvailableSeats { get; set; }
        public FitnessClass FitnessClass { get; set; }
    }
}
