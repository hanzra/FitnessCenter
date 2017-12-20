using FitnessCenter.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Domain.Entities;
using FitnessCenter.Domain.Entities.Infrastructure;

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
            return _context
                 .FitnessClass;
                
        }

        public FitnessClass GetFitnessClassByID(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveFitnessClass(FitnessClass fitnessClass)
        {
            throw new NotImplementedException();
        }

        public FitnessClass UpdateFitnessClass(FitnessClass fitnessclass)
        {
            throw new NotImplementedException();
        }
    }
}
