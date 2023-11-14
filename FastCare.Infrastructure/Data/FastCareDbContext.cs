using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FastCare.Infrastructure.Data
{
    public class FastCareDbContext : DbContext
    {
        public FastCareDbContext(DbContextOptions options) : base(options)
        {
        }

        
    }
}