using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOR.Models
{
    public class SORContext : DbContext
    {
        public SORContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PacjentModel> Pacjenci { get; set; }
    }
}

