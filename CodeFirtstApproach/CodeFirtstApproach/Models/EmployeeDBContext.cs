using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirtstApproach.Models
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }
    }
}