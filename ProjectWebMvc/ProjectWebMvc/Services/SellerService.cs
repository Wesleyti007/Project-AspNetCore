using ProjectWebMvc.Data;
using ProjectWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebMvc.Services
{
    public class SellerService
    {
        private readonly ProjectWebMvcContext _context;

        public SellerService(ProjectWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
