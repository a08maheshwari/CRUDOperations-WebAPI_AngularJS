using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularCrudWebApi.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("EmployeeStringConnection")
        {
        }
        public DbSet<Employee> Employees{get;set;}
    }  
}