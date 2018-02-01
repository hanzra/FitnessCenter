using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCenter.Domain;
using FitnessCenter.Domain.Entities;
using FitnessCenter.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitnessCenter.Web.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;        
        private readonly UserManager<AppUser> _userManager;

        public RegistrationController(IUnitOfWork unitOfWork, UserManager<AppUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> ListRegistrations()
        {
            var user = await GetCurrentUserAsync();
            _unitOfWork.Register.GetRegistrationsByUser(user.Id);
            return View();
        }

        [HttpGet]
        public IActionResult Registration(int id)
        {
            var registration = new Registration()
            {
                Schedule = _unitOfWork.Schedule.GetSchedulesById(id)
            };

            return View(registration);
        }

        [HttpPost]
        public async Task<IActionResult> Registration(Registration reg)
        {
            var user = await GetCurrentUserAsync();

                var schedule = _unitOfWork.Schedule.GetSchedulesById(reg.Schedule.ID);

                int waitNumber = 0;

                if (schedule.Registration != null)
                {
                waitNumber = schedule.Capacity < schedule.Registration.Count ? schedule.Registration.Count - schedule.Capacity : 0;
                }

                Registration newRegistration = new Registration()
                {
                    ScheduleID = reg.Schedule.ID,
                    UserID = user.Id,
                    WaitNumber = waitNumber,
                    Status = waitNumber > 0 ? RegisrtationStatus.Waiting : RegisrtationStatus.Confirmed,
                    DateTime = DateTime.Now                    
                };

                _unitOfWork.Register.AddRegistration(newRegistration);
                _unitOfWork.Complete();

                RedirectToAction("ListRegistrations");
        
            return RedirectToAction("Index", "Home");
        }

        private Task<AppUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}