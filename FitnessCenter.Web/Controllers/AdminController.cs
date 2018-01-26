using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessCenter.Domain;
using FitnessCenter.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using FitnessCenter.Domain.ViewModel.Admin;

namespace FitnessCenter.Web.Controllers
{    
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdminController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListClasses()
        {
            return View(_unitOfWork.FitnessClass.AllFitnessClasses());
        }

        public IActionResult AddEditClass(int id = 0)
        {
            if (id == 0)
            {
                return View(new FitnessClass());
            } else
            {
                var fitnessClass = _unitOfWork.FitnessClass.GetFitnessClassByID(id);

                if (fitnessClass != null)
                {
                    return View(fitnessClass);
                }
                else
                {
                    //Add model error
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public IActionResult AddEditClass(FitnessClass fitnessClass)
        {
            if (ModelState.IsValid)
            {
                var classExists = _unitOfWork.FitnessClass.GetFitnessClassByID(fitnessClass.ID) != null ? true : false;

                if (!classExists)
                {
                    _unitOfWork.FitnessClass.AddFitnessClass(fitnessClass);
                    _unitOfWork.Complete();

                    return View(fitnessClass);

                } else
                {
                    _unitOfWork.FitnessClass.UpdateFitnessClass(fitnessClass);
                    _unitOfWork.Complete();
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult ListSchedules()
        {
            var schedules = _unitOfWork.Schedule.GetAllSchedules();
            return View(schedules);
        }

        [HttpGet]
        public IActionResult AddEditSchedule(int id = 0)
        {
            var classes = _unitOfWork.FitnessClass.AllFitnessClasses();

            if (id == 0)
            {
                return View(new ScheduleViewModel {
                    Schedue = new Schedule(),
                    FitnessClass = classes
                });
            }
            else
            {
                var Schedule = _unitOfWork.Schedule.GetSchedulesById(id);
                return View(Schedule);
            }            
        }

        [HttpPost]
        public IActionResult AddEditSchedule(Schedule schedule)
        {
            var existSchdule = _unitOfWork.Schedule.GetSchedulesById(schedule.ID) == null ? false: true;

            if (!existSchdule)
            {
                _unitOfWork.Schedule.AddSchedule(schedule);
                _unitOfWork.Complete();

                return View("ListSchedules");
            }
            else
            {
                return View("ListSchedules");
            }
        }

    }
}