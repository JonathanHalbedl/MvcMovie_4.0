using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie_4._0.Models;

namespace MvcMovie_4._0.Data
{
    public class MvcMovie_4_0Context : DbContext
    {
        public MvcMovie_4_0Context (DbContextOptions<MvcMovie_4_0Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie_4._0.Models.Movie> Movie { get; set; } = default!;
    }
}
