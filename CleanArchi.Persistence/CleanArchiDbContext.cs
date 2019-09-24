using System;
using System.Collections.Generic;
using System.Text;
using CleanArchi.Application.Interfaces;
using CleanArchi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchi.Persistence
{
    public class CleanArchiDbContext : DbContext, ICleanArchiDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<EmployeeRole> Roles { get; set; }

        #region Constructors

        public CleanArchiDbContext(DbContextOptions<CleanArchiDbContext> options) : base(options)
        {
            
        }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CleanArchiDbContext).Assembly);
        }
    }
}
