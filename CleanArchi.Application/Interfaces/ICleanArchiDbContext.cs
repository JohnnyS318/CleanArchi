using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CleanArchi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchi.Application.Interfaces
{
    public interface ICleanArchiDbContext
    {

        #region Db Sets

        DbSet<Domain.Entities.Employee> Employees { get; set; }

        DbSet<Project> Projects { get; set; }

        DbSet<Membership> Memberships { get; set; }

        DbSet<EmployeeRole> Roles { get; set; }

        #endregion

        #region Methods

        Task<int> SaveChangesAsync(CancellationToken cancellation);

        #endregion

    }
}
