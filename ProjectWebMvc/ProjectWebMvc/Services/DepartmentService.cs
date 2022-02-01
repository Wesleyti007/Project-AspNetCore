using ProjectWebMvc.Data;
using ProjectWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebMvc.Services
{
    public class DepartmentService
    {
        private readonly ProjectWebMvcContext _context;

        public DepartmentService(ProjectWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
