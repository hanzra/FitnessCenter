using FitnessCenter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Domain.Repositories
{
    public interface IRegistrationRepository
    {
        void AddRegistration(Registration registration);
        void RemoveRegistration(Registration fitnessClass);
        IEnumerable<Registration> GetAllRegistrations();
        Registration GetRegistrationById(int id);
        Registration UpdateRegistration(Registration fitnessclass);
    }
}
