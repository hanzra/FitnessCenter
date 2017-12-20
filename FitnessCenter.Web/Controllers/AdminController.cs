using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitnessCenter.Domain;
using FitnessCenter.Domain.Entities;

namespace FitnessCenter.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AdminController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View(_unitOfWork.FitnessClass.AllFitnessClasses());
        }

        public IActionResult AddClass()
        {
            return View(new FitnessClass());
        }

        [HttpPost]
        public IActionResult AddClass(FitnessClass fitnessClass)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.FitnessClass.AddFitnessClass(fitnessClass);
                _unitOfWork.Complete();

                return View(fitnessClass);
            }
            return View();
        }
    }
}