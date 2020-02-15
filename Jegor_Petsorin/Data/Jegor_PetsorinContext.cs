using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Jegor_Petsorin.Models;

namespace Jegor_Petsorin.Data
{
    public class Jegor_PetsorinContext : DbContext
    {
        public Jegor_PetsorinContext (DbContextOptions<Jegor_PetsorinContext> options)
            : base(options)
        {
        }

        public DbSet<Jegor_Petsorin.Models.Movie> Movie { get; set; }
    }
}
