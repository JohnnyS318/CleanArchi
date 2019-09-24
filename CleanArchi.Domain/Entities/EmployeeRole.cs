using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchi.Domain.Entities
{
    public class EmployeeRole
    {

        public string Id { get; set; }

        public string EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public string RoleId { get; set; }
        public Role Role { get; set; }

    }
}
