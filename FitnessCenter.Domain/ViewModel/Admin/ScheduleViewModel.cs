using FitnessCenter.Domain.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Domain.ViewModel.Admin
{
    public class ScheduleViewModel
    {
        public Schedule Schedue { get; set; }
        public IEnumerable<FitnessClass> FitnessClass { get; set; }
    }
}
