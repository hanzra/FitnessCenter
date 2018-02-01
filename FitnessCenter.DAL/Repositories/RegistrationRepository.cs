using FitnessCenter.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter.Domain.Entities;
using FitnessCenter.Domain.Entities.Infrastructure;
using System.Linq;

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
            _context.Add(registration);
        }

        public IEnumerable<Registration> GetAllRegistrations()
        {
            return _context.Registration;
        }

        public IEnumerable<Registration> GetRegistrationsByUser(string userId)
        {
            return _context.Registration.Where(x => x.UserID == userId);
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
