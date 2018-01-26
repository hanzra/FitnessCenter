using FitnessCenter.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Domain.ViewModel.Admin
{
    public class ScheduleViewModel
    {
        public Schedule Schedule { get; set; }
        public IEnumerable<SelectListItem> Classes { get; set; }
    }
}
