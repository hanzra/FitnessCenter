using FitnessCenter.Domain.Entities;
using FitnessCenter.Domain.ViewModel.Admin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Domain.Repositories
{
    public interface IScheduleRepository
    {
        void AddSchedule(Schedule schedule);
        void RemoveSchedule(Schedule schedule);
        IEnumerable<ScheduleListViewModel> GetAllSchedules();
        Schedule GetSchedulesById(int id);
        Schedule UpdateSchedule(Schedule schedule);
    }
}
