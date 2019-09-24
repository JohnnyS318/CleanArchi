using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchi.Domain.Entities
{
    public class Project
    {

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; } 

        public string Progress { get; set; }

        public ICollection<Membership> Members { get; set; }

    }
}
