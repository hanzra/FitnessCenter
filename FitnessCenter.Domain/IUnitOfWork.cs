using FitnessCenter.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Domain
{
    public interface IUnitOfWork
    {
        IFitnessClassRepository FitnessClass { get; }
        void Complete();
    }
}
