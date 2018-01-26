using FitnessCenter.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Domain.Repositories
{
    public interface IFitnessClassRepository
    {
        void AddFitnessClass(FitnessClass fitnessClass);
        void RemoveFitnessClass(FitnessClass fitnessClass);
        IEnumerable<FitnessClass> AllFitnessClasses();
        FitnessClass GetFitnessClassByID(int id);
        void UpdateFitnessClass(FitnessClass fitnessclass);
    }
}
