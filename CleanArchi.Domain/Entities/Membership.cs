using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchi.Domain.Entities
{
    public class Membership
    {

        public string Id { get; set; }

        public string EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public string ProjectId { get; set; }

        public Project Project { get; set; }

        public DateTime Accedence { get; set; }

    }
}
