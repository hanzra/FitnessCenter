using FitnessCenter.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Domain.Entities;
using FitnessCenter.Domain.Entities.Infrastructure;
using FitnessCenter.Domain.ViewModel.Admin;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenter.DAL.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ApplicationDBContext _context;

        public ScheduleRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public void AddSchedule(Schedule schedule)
        {
            _context.Schedule.Add(schedule);
        }

        public IEnumerable<ScheduleListViewModel> GetAllSchedules()
        {
            return (from s in _context.Schedule
                    join fc in _context.FitnessClass
                    on s.ClassID equals fc.ID
                    select new ScheduleListViewModel
                    {
                        Schedue = s,
                        FitnessClass = fc,
                        AvailableSeats = s.Capacity - s.Registration.Count
                    } ).ToList();
            
        }

        public Schedule GetSchedulesById(int id)
        {
            return _context.Schedule
                .Include(x=>x.FitnessClass)
                .Include(y=>y.Registration).ThenInclude(z => z.AppUser)
                .Where(x => x.ID == id).FirstOrDefault();
        }

        public void RemoveSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public Schedule UpdateSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }
    }
}
