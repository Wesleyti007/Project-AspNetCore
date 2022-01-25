using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectWebMvc.Models;

namespace ProjectWebMvc.Data
{
    public class ProjectWebMvcContext : DbContext
    {
        public ProjectWebMvcContext (DbContextOptions<ProjectWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord>  SalesRecord{ get; set; }

    }
}
