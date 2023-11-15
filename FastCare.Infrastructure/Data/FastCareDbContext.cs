using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FastCare.Infrastructure.Data
{
    public class FastCareDbContext : DbContext
    {
        public FastCareDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Facility> Facilities {get;set;}
    }
}