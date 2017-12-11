using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessCenter.Domain.Entities.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace FitnessCenter.Test
{
    [TestClass]
        public class SimpleIntegrationTest : IDisposable
        {
            ApplicationDBContext _context;

            public SimpleIntegrationTest()
            {
                var serviceProvider = new ServiceCollection()
                    .AddEntityFrameworkSqlServer()
                    .BuildServiceProvider();

                var builder = new DbContextOptionsBuilder<ApplicationDBContext>();

                builder.($"Server=Data Source=SHANZRA-D1\\sqlexpress;Database=temp_{Guid.NewGuid()};Trusted_Connection=True;MultipleActiveResultSets=true")
                        .UseInternalServiceProvider(serviceProvider);

                _context = new ApplicationDBContext(builder.Options);
                _context.Database.Migrate();

            }  

        [TestMethod]
        public void CreateDB() { }

            public void Dispose()
            {
                _context.Database.EnsureDeleted();
            }
        }
    }

