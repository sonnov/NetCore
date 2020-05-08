using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infestation.Models
{
    public class InfestationDbContext : DbContext
    {
        public InfestationDbContext(DbContextOptions<InfestationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Human> Humans { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
