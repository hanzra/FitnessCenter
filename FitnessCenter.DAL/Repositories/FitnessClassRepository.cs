using FitnessCenter.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Domain.Entities;
using FitnessCenter.Domain.Entities.Infrastructure;
using System.Linq;

namespace FitnessCenter.DAL.Repositories
{
    public class FitnessClassRepository : IFitnessClassRepository
    {
        private readonly ApplicationDBContext _context;

        public FitnessClassRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public void AddFitnessClass(FitnessClass fitnessClass)
        {
            _context.FitnessClass.Add(fitnessClass);
        }

        public IEnumerable<FitnessClass> AllFitnessClasses()
        {
            return _context.FitnessClass;                
        }

        public FitnessClass GetFitnessClassByID(int id)
        {
            return _context.FitnessClass.Where(x=>x.ID == id).FirstOrDefault();
        }

        public void RemoveFitnessClass(FitnessClass fitnessClass)
        {
            throw new NotImplementedException();
        }

        public void UpdateFitnessClass(FitnessClass updatedFitnessClass)
        {
            var fitnessClass = _context.FitnessClass.Where(x=>x.ID == updatedFitnessClass.ID).FirstOrDefault();
            fitnessClass.Name = updatedFitnessClass.Name;
            fitnessClass.Instructor = updatedFitnessClass.Instructor;
            fitnessClass.Description = updatedFitnessClass.Description;
        }
    }
}
