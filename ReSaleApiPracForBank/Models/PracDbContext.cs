using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReSaleApiPracForBank.Models
{
    public class PracDbContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }

        public PracDbContext(DbContextOptions<PracDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) { }
    }
}
