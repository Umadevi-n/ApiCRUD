using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiCRUD.Models;

namespace ApiCRUD.Data
{
    public class EmployeeCrudContext : DbContext
    {
        public EmployeeCrudContext (DbContextOptions<EmployeeCrudContext> options)
            : base(options)
        {
        }

        public DbSet<ApiCRUD.Models.Employee> Employee { get; set; }
    }
}

