using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talabalar.Models;

namespace Talabalar.Data
{
    public class TalabaContext:DbContext
    {
        public TalabaContext(DbContextOptions<TalabaContext> options)
            :base(options)
        { }
        public DbSet<Talaba> Talabalar { get; set; }
    }
}
