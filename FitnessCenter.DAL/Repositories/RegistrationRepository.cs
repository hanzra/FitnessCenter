using FitnessCenter.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Domain.Entities;
using FitnessCenter.Domain.Entities.Infrastructure;

namespace FitnessCenter.DAL.Repositories
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly ApplicationDBContext _context;

        public RegistrationRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public void AddRegistration(Registration registration)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Registration> GetAllRegistrations()
        {
            throw new NotImplementedException();
        }

        public Registration GetRegistrationById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveRegistration(Registration fitnessClass)
        {
            throw new NotImplementedException();
        }

        public Registration UpdateRegistration(Registration fitnessclass)
        {
            throw new NotImplementedException();
        }
    }
}
