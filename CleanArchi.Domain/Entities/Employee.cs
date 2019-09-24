using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchi.Domain.Entities
{
    public class Employee
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<EmployeeRole> Roles { get; set; }    

        public ICollection<Membership> Memberships { get; set; }

    }
}
