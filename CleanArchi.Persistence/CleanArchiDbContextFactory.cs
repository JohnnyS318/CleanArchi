using System;
using System.Collections.Generic;
using System.Text;
using CleanArchi.Persistence.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CleanArchi.Persistence
{
    public class CleanArchiDbContextFactory : DesignTimeDbContextFactoryBase<CleanArchiDbContext>
    {
        protected override CleanArchiDbContext CreateNewInstance(DbContextOptions<CleanArchiDbContext> options)
        {
            return new CleanArchiDbContext(options);
        }
    }
}
