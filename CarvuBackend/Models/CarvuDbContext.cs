using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Models
{
    public class CarvuDbContext : DbContext
    {
        public CarvuDbContext(DbContextOptions<CarvuDbContext> options) : base(options)
        {
        }

        public DbSet<BusinessOwner> BusinessOwners { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
