using FitnessCenter.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter.Domain.Entities.Infrastructure
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<FitnessClass> FitnessClass { get; set; }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
    }
}
