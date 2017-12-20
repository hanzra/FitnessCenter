using FitnessCenter.DAL.Repositories;
using FitnessCenter.Domain;
using FitnessCenter.Domain.Entities.Infrastructure;
using FitnessCenter.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.DAL.UnitOfWork
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;
        public IFitnessClassRepository FitnessClass { get; private set; }

        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
            FitnessClass = new FitnessClassRepository(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
